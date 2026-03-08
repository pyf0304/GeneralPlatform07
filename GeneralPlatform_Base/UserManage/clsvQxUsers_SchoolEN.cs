
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUsers_SchoolEN
 表名:vQxUsers_School(00140075)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 09:58:37
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
 /// 表vQxUsers_School的关键字(UserId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_UserId_vQxUsers_School
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
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
public const string _CurrTabName_S = "vQxUsers_School"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 28;
public static string[] AttributeName = new string[] {"UserId", "UserName", "DepartmentId", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "DepartmentTypeName", "UpDepartmentId", "UpDepartmentName", "UserStateId", "UserStateName", "EffectiveDate", "IdentityID", "IdentityDesc", "CardNo", "StuTeacherId", "id_GradeBase", "GradeBaseID", "GradeBaseName", "EnterSchoolDate", "IsOffed", "BeginYearMonth", "EndYearMonth", "Card_State", "IsLeaved", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量

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
protected string mstrEffectiveDate;    //有效日期
protected string mstrIdentityID;    //身份编号
protected string mstrIdentityDesc;    //身份描述
protected string mstrCardNo;    //卡号
protected string mstrStuTeacherId;    //学工号
protected string mstrid_GradeBase;    //年级流水号
protected string mstrGradeBaseID;    //年级代号
protected string mstrGradeBaseName;    //年级名称
protected string mstrEnterSchoolDate;    //进校日期
protected bool mbolIsOffed;    //是否毕业
protected string mstrBeginYearMonth;    //开始年月
protected string mstrEndYearMonth;    //结束年月
protected string mstrCard_State;    //卡状态
protected bool mbolIsLeaved;    //IsLeaved
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
 /// 常量:"DepartmentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentTypeId = "DepartmentTypeId";    //部门类型ID

 /// <summary>
 /// 常量:"DepartmentTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentTypeName = "DepartmentTypeName";    //部门类型名

 /// <summary>
 /// 常量:"UpDepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpDepartmentId = "UpDepartmentId";    //所属部门号

 /// <summary>
 /// 常量:"UpDepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpDepartmentName = "UpDepartmentName";    //上级部门

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
 /// 常量:"EffectiveDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_EffectiveDate = "EffectiveDate";    //有效日期

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
 /// 常量:"CardNo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CardNo = "CardNo";    //卡号

 /// <summary>
 /// 常量:"StuTeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_StuTeacherId = "StuTeacherId";    //学工号

 /// <summary>
 /// 常量:"id_GradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_GradeBase = "id_GradeBase";    //年级流水号

 /// <summary>
 /// 常量:"GradeBaseID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GradeBaseID = "GradeBaseID";    //年级代号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"EnterSchoolDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_EnterSchoolDate = "EnterSchoolDate";    //进校日期

 /// <summary>
 /// 常量:"IsOffed"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsOffed = "IsOffed";    //是否毕业

 /// <summary>
 /// 常量:"BeginYearMonth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_BeginYearMonth = "BeginYearMonth";    //开始年月

 /// <summary>
 /// 常量:"EndYearMonth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_EndYearMonth = "EndYearMonth";    //结束年月

 /// <summary>
 /// 常量:"Card_State"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Card_State = "Card_State";    //卡状态

 /// <summary>
 /// 常量:"IsLeaved"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsLeaved = "IsLeaved";    //IsLeaved

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
 public clsvQxUsers_SchoolEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vQxUsers_School";
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
 _CurrTabName = "vQxUsers_School";
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
else if (strAttributeName  ==  con_DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  con_DepartmentAbbrName)
{
return mstrDepartmentAbbrName;
}
else if (strAttributeName  ==  con_DepartmentTypeId)
{
return mstrDepartmentTypeId;
}
else if (strAttributeName  ==  con_DepartmentTypeName)
{
return mstrDepartmentTypeName;
}
else if (strAttributeName  ==  con_UpDepartmentId)
{
return mstrUpDepartmentId;
}
else if (strAttributeName  ==  con_UpDepartmentName)
{
return mstrUpDepartmentName;
}
else if (strAttributeName  ==  con_UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  con_UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  con_EffectiveDate)
{
return mstrEffectiveDate;
}
else if (strAttributeName  ==  con_IdentityID)
{
return mstrIdentityID;
}
else if (strAttributeName  ==  con_IdentityDesc)
{
return mstrIdentityDesc;
}
else if (strAttributeName  ==  con_CardNo)
{
return mstrCardNo;
}
else if (strAttributeName  ==  con_StuTeacherId)
{
return mstrStuTeacherId;
}
else if (strAttributeName  ==  con_id_GradeBase)
{
return mstrid_GradeBase;
}
else if (strAttributeName  ==  con_GradeBaseID)
{
return mstrGradeBaseID;
}
else if (strAttributeName  ==  con_GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  con_EnterSchoolDate)
{
return mstrEnterSchoolDate;
}
else if (strAttributeName  ==  con_IsOffed)
{
return mbolIsOffed;
}
else if (strAttributeName  ==  con_BeginYearMonth)
{
return mstrBeginYearMonth;
}
else if (strAttributeName  ==  con_EndYearMonth)
{
return mstrEndYearMonth;
}
else if (strAttributeName  ==  con_Card_State)
{
return mstrCard_State;
}
else if (strAttributeName  ==  con_IsLeaved)
{
return mbolIsLeaved;
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
else if (strAttributeName  ==  con_DepartmentTypeId)
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(con_DepartmentTypeId);
}
else if (strAttributeName  ==  con_DepartmentTypeName)
{
mstrDepartmentTypeName = value.ToString();
 AddUpdatedFld(con_DepartmentTypeName);
}
else if (strAttributeName  ==  con_UpDepartmentId)
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(con_UpDepartmentId);
}
else if (strAttributeName  ==  con_UpDepartmentName)
{
mstrUpDepartmentName = value.ToString();
 AddUpdatedFld(con_UpDepartmentName);
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
else if (strAttributeName  ==  con_EffectiveDate)
{
mstrEffectiveDate = value.ToString();
 AddUpdatedFld(con_EffectiveDate);
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
else if (strAttributeName  ==  con_CardNo)
{
mstrCardNo = value.ToString();
 AddUpdatedFld(con_CardNo);
}
else if (strAttributeName  ==  con_StuTeacherId)
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(con_StuTeacherId);
}
else if (strAttributeName  ==  con_id_GradeBase)
{
mstrid_GradeBase = value.ToString();
 AddUpdatedFld(con_id_GradeBase);
}
else if (strAttributeName  ==  con_GradeBaseID)
{
mstrGradeBaseID = value.ToString();
 AddUpdatedFld(con_GradeBaseID);
}
else if (strAttributeName  ==  con_GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(con_GradeBaseName);
}
else if (strAttributeName  ==  con_EnterSchoolDate)
{
mstrEnterSchoolDate = value.ToString();
 AddUpdatedFld(con_EnterSchoolDate);
}
else if (strAttributeName  ==  con_IsOffed)
{
mbolIsOffed = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsOffed);
}
else if (strAttributeName  ==  con_BeginYearMonth)
{
mstrBeginYearMonth = value.ToString();
 AddUpdatedFld(con_BeginYearMonth);
}
else if (strAttributeName  ==  con_EndYearMonth)
{
mstrEndYearMonth = value.ToString();
 AddUpdatedFld(con_EndYearMonth);
}
else if (strAttributeName  ==  con_Card_State)
{
mstrCard_State = value.ToString();
 AddUpdatedFld(con_Card_State);
}
else if (strAttributeName  ==  con_IsLeaved)
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsLeaved);
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
else if (con_DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (con_DepartmentAbbrName  ==  AttributeName[intIndex])
{
return mstrDepartmentAbbrName;
}
else if (con_DepartmentTypeId  ==  AttributeName[intIndex])
{
return mstrDepartmentTypeId;
}
else if (con_DepartmentTypeName  ==  AttributeName[intIndex])
{
return mstrDepartmentTypeName;
}
else if (con_UpDepartmentId  ==  AttributeName[intIndex])
{
return mstrUpDepartmentId;
}
else if (con_UpDepartmentName  ==  AttributeName[intIndex])
{
return mstrUpDepartmentName;
}
else if (con_UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (con_UserStateName  ==  AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (con_EffectiveDate  ==  AttributeName[intIndex])
{
return mstrEffectiveDate;
}
else if (con_IdentityID  ==  AttributeName[intIndex])
{
return mstrIdentityID;
}
else if (con_IdentityDesc  ==  AttributeName[intIndex])
{
return mstrIdentityDesc;
}
else if (con_CardNo  ==  AttributeName[intIndex])
{
return mstrCardNo;
}
else if (con_StuTeacherId  ==  AttributeName[intIndex])
{
return mstrStuTeacherId;
}
else if (con_id_GradeBase  ==  AttributeName[intIndex])
{
return mstrid_GradeBase;
}
else if (con_GradeBaseID  ==  AttributeName[intIndex])
{
return mstrGradeBaseID;
}
else if (con_GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (con_EnterSchoolDate  ==  AttributeName[intIndex])
{
return mstrEnterSchoolDate;
}
else if (con_IsOffed  ==  AttributeName[intIndex])
{
return mbolIsOffed;
}
else if (con_BeginYearMonth  ==  AttributeName[intIndex])
{
return mstrBeginYearMonth;
}
else if (con_EndYearMonth  ==  AttributeName[intIndex])
{
return mstrEndYearMonth;
}
else if (con_Card_State  ==  AttributeName[intIndex])
{
return mstrCard_State;
}
else if (con_IsLeaved  ==  AttributeName[intIndex])
{
return mbolIsLeaved;
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
else if (con_DepartmentTypeId  ==  AttributeName[intIndex])
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(con_DepartmentTypeId);
}
else if (con_DepartmentTypeName  ==  AttributeName[intIndex])
{
mstrDepartmentTypeName = value.ToString();
 AddUpdatedFld(con_DepartmentTypeName);
}
else if (con_UpDepartmentId  ==  AttributeName[intIndex])
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(con_UpDepartmentId);
}
else if (con_UpDepartmentName  ==  AttributeName[intIndex])
{
mstrUpDepartmentName = value.ToString();
 AddUpdatedFld(con_UpDepartmentName);
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
else if (con_EffectiveDate  ==  AttributeName[intIndex])
{
mstrEffectiveDate = value.ToString();
 AddUpdatedFld(con_EffectiveDate);
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
else if (con_CardNo  ==  AttributeName[intIndex])
{
mstrCardNo = value.ToString();
 AddUpdatedFld(con_CardNo);
}
else if (con_StuTeacherId  ==  AttributeName[intIndex])
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(con_StuTeacherId);
}
else if (con_id_GradeBase  ==  AttributeName[intIndex])
{
mstrid_GradeBase = value.ToString();
 AddUpdatedFld(con_id_GradeBase);
}
else if (con_GradeBaseID  ==  AttributeName[intIndex])
{
mstrGradeBaseID = value.ToString();
 AddUpdatedFld(con_GradeBaseID);
}
else if (con_GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(con_GradeBaseName);
}
else if (con_EnterSchoolDate  ==  AttributeName[intIndex])
{
mstrEnterSchoolDate = value.ToString();
 AddUpdatedFld(con_EnterSchoolDate);
}
else if (con_IsOffed  ==  AttributeName[intIndex])
{
mbolIsOffed = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsOffed);
}
else if (con_BeginYearMonth  ==  AttributeName[intIndex])
{
mstrBeginYearMonth = value.ToString();
 AddUpdatedFld(con_BeginYearMonth);
}
else if (con_EndYearMonth  ==  AttributeName[intIndex])
{
mstrEndYearMonth = value.ToString();
 AddUpdatedFld(con_EndYearMonth);
}
else if (con_Card_State  ==  AttributeName[intIndex])
{
mstrCard_State = value.ToString();
 AddUpdatedFld(con_Card_State);
}
else if (con_IsLeaved  ==  AttributeName[intIndex])
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsLeaved);
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
 AddUpdatedFld(con_DepartmentTypeId);
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
 AddUpdatedFld(con_DepartmentTypeName);
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
 AddUpdatedFld(con_UpDepartmentId);
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
 AddUpdatedFld(con_UpDepartmentName);
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
 AddUpdatedFld(con_CardNo);
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
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_GradeBase
{
get
{
return mstrid_GradeBase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_GradeBase = value;
}
else
{
 mstrid_GradeBase = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_GradeBase);
}
}
/// <summary>
/// 年级代号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseID
{
get
{
return mstrGradeBaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseID = value;
}
else
{
 mstrGradeBaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(con_GradeBaseID);
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
 AddUpdatedFld(con_GradeBaseName);
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
 AddUpdatedFld(con_EnterSchoolDate);
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
 AddUpdatedFld(con_IsOffed);
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
 AddUpdatedFld(con_BeginYearMonth);
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
 AddUpdatedFld(con_EndYearMonth);
}
}
/// <summary>
/// 卡状态(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Card_State
{
get
{
return mstrCard_State;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCard_State = value;
}
else
{
 mstrCard_State = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Card_State);
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
 AddUpdatedFld(con_IsLeaved);
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
}
}