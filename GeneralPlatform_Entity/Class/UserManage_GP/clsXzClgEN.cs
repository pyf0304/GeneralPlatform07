
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzClgEN
 表名:XzClg(00140122)
 * 版本:2024.02.03.1(服务器:WIN-SRV103-116)
 日期:2024/02/18 11:34:54
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
 /// 表XzClg的关键字(IdXzCollege)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdXzCollege_XzClg
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdXzCollege">表关键字</param>
public K_IdXzCollege_XzClg(string strIdXzCollege)
{
if (IsValid(strIdXzCollege)) Value = strIdXzCollege;
else
{
Value = null;
}
}
private static bool IsValid(string strIdXzCollege)
{
if (string.IsNullOrEmpty(strIdXzCollege) == true) return false;
if (strIdXzCollege.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdXzCollege_XzClg]类型的对象</returns>
public static implicit operator K_IdXzCollege_XzClg(string value)
{
return new K_IdXzCollege_XzClg(value);
}
}
 /// <summary>
 /// XzClg(XzClg)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzClgEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzClg"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdXzCollege"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "ClgEnglishName", "UserType", "CollegeIdInGP", "IdSchool", "IdUni", "PhoneNumber", "WebSite", "IsVisible", "IsVisible4Tea", "OrderNum", "ModifyDate", "ModifyUserId", "Memo"};

protected string mstrIdXzCollege;    //学院Id
protected string mstrCollegeId;    //CollegeId
protected string mstrCollegeName;    //学院名
protected string mstrCollegeNameA;    //CollegeNameA
protected string mstrClgEnglishName;    //ClgEnglishName
protected string mstrUserType;    //用户类型
protected string mstrCollegeIdInGP;    //CollegeIdInGP
protected string mstrIdSchool;    //学校流水号
protected string mstrIdUni;    //IdUni
protected string mstrPhoneNumber;    //电话号码
protected string mstrWebSite;    //WebSite
protected bool mbolIsVisible;    //是否显示
protected bool mbolIsVisible4Tea;    //IsVisible4Tea
protected int? mintOrderNum;    //排序号
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzClgEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdXzCollege");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdXzCollege">关键字:学院Id</param>
public clsXzClgEN(string strIdXzCollege)
 {
strIdXzCollege = strIdXzCollege.Replace("'", "''");
if (strIdXzCollege.Length > 4)
{
throw new Exception("在表:XzClg中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdXzCollege)  ==  true)
{
throw new Exception("在表:XzClg中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdXzCollege);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdXzCollege = strIdXzCollege;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdXzCollege");
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
if (strAttributeName  ==  conXzClg.IdXzCollege)
{
return mstrIdXzCollege;
}
else if (strAttributeName  ==  conXzClg.CollegeId)
{
return mstrCollegeId;
}
else if (strAttributeName  ==  conXzClg.CollegeName)
{
return mstrCollegeName;
}
else if (strAttributeName  ==  conXzClg.CollegeNameA)
{
return mstrCollegeNameA;
}
else if (strAttributeName  ==  conXzClg.ClgEnglishName)
{
return mstrClgEnglishName;
}
else if (strAttributeName  ==  conXzClg.UserType)
{
return mstrUserType;
}
else if (strAttributeName  ==  conXzClg.CollegeIdInGP)
{
return mstrCollegeIdInGP;
}
else if (strAttributeName  ==  conXzClg.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  conXzClg.IdUni)
{
return mstrIdUni;
}
else if (strAttributeName  ==  conXzClg.PhoneNumber)
{
return mstrPhoneNumber;
}
else if (strAttributeName  ==  conXzClg.WebSite)
{
return mstrWebSite;
}
else if (strAttributeName  ==  conXzClg.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conXzClg.IsVisible4Tea)
{
return mbolIsVisible4Tea;
}
else if (strAttributeName  ==  conXzClg.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conXzClg.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conXzClg.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conXzClg.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conXzClg.IdXzCollege)
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conXzClg.IdXzCollege);
}
else if (strAttributeName  ==  conXzClg.CollegeId)
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(conXzClg.CollegeId);
}
else if (strAttributeName  ==  conXzClg.CollegeName)
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(conXzClg.CollegeName);
}
else if (strAttributeName  ==  conXzClg.CollegeNameA)
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(conXzClg.CollegeNameA);
}
else if (strAttributeName  ==  conXzClg.ClgEnglishName)
{
mstrClgEnglishName = value.ToString();
 AddUpdatedFld(conXzClg.ClgEnglishName);
}
else if (strAttributeName  ==  conXzClg.UserType)
{
mstrUserType = value.ToString();
 AddUpdatedFld(conXzClg.UserType);
}
else if (strAttributeName  ==  conXzClg.CollegeIdInGP)
{
mstrCollegeIdInGP = value.ToString();
 AddUpdatedFld(conXzClg.CollegeIdInGP);
}
else if (strAttributeName  ==  conXzClg.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conXzClg.IdSchool);
}
else if (strAttributeName  ==  conXzClg.IdUni)
{
mstrIdUni = value.ToString();
 AddUpdatedFld(conXzClg.IdUni);
}
else if (strAttributeName  ==  conXzClg.PhoneNumber)
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(conXzClg.PhoneNumber);
}
else if (strAttributeName  ==  conXzClg.WebSite)
{
mstrWebSite = value.ToString();
 AddUpdatedFld(conXzClg.WebSite);
}
else if (strAttributeName  ==  conXzClg.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzClg.IsVisible);
}
else if (strAttributeName  ==  conXzClg.IsVisible4Tea)
{
mbolIsVisible4Tea = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzClg.IsVisible4Tea);
}
else if (strAttributeName  ==  conXzClg.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzClg.OrderNum);
}
else if (strAttributeName  ==  conXzClg.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conXzClg.ModifyDate);
}
else if (strAttributeName  ==  conXzClg.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conXzClg.ModifyUserId);
}
else if (strAttributeName  ==  conXzClg.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzClg.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzClg.IdXzCollege  ==  AttributeName[intIndex])
{
return mstrIdXzCollege;
}
else if (conXzClg.CollegeId  ==  AttributeName[intIndex])
{
return mstrCollegeId;
}
else if (conXzClg.CollegeName  ==  AttributeName[intIndex])
{
return mstrCollegeName;
}
else if (conXzClg.CollegeNameA  ==  AttributeName[intIndex])
{
return mstrCollegeNameA;
}
else if (conXzClg.ClgEnglishName  ==  AttributeName[intIndex])
{
return mstrClgEnglishName;
}
else if (conXzClg.UserType  ==  AttributeName[intIndex])
{
return mstrUserType;
}
else if (conXzClg.CollegeIdInGP  ==  AttributeName[intIndex])
{
return mstrCollegeIdInGP;
}
else if (conXzClg.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (conXzClg.IdUni  ==  AttributeName[intIndex])
{
return mstrIdUni;
}
else if (conXzClg.PhoneNumber  ==  AttributeName[intIndex])
{
return mstrPhoneNumber;
}
else if (conXzClg.WebSite  ==  AttributeName[intIndex])
{
return mstrWebSite;
}
else if (conXzClg.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conXzClg.IsVisible4Tea  ==  AttributeName[intIndex])
{
return mbolIsVisible4Tea;
}
else if (conXzClg.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conXzClg.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conXzClg.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conXzClg.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conXzClg.IdXzCollege  ==  AttributeName[intIndex])
{
mstrIdXzCollege = value.ToString();
 AddUpdatedFld(conXzClg.IdXzCollege);
}
else if (conXzClg.CollegeId  ==  AttributeName[intIndex])
{
mstrCollegeId = value.ToString();
 AddUpdatedFld(conXzClg.CollegeId);
}
else if (conXzClg.CollegeName  ==  AttributeName[intIndex])
{
mstrCollegeName = value.ToString();
 AddUpdatedFld(conXzClg.CollegeName);
}
else if (conXzClg.CollegeNameA  ==  AttributeName[intIndex])
{
mstrCollegeNameA = value.ToString();
 AddUpdatedFld(conXzClg.CollegeNameA);
}
else if (conXzClg.ClgEnglishName  ==  AttributeName[intIndex])
{
mstrClgEnglishName = value.ToString();
 AddUpdatedFld(conXzClg.ClgEnglishName);
}
else if (conXzClg.UserType  ==  AttributeName[intIndex])
{
mstrUserType = value.ToString();
 AddUpdatedFld(conXzClg.UserType);
}
else if (conXzClg.CollegeIdInGP  ==  AttributeName[intIndex])
{
mstrCollegeIdInGP = value.ToString();
 AddUpdatedFld(conXzClg.CollegeIdInGP);
}
else if (conXzClg.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(conXzClg.IdSchool);
}
else if (conXzClg.IdUni  ==  AttributeName[intIndex])
{
mstrIdUni = value.ToString();
 AddUpdatedFld(conXzClg.IdUni);
}
else if (conXzClg.PhoneNumber  ==  AttributeName[intIndex])
{
mstrPhoneNumber = value.ToString();
 AddUpdatedFld(conXzClg.PhoneNumber);
}
else if (conXzClg.WebSite  ==  AttributeName[intIndex])
{
mstrWebSite = value.ToString();
 AddUpdatedFld(conXzClg.WebSite);
}
else if (conXzClg.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzClg.IsVisible);
}
else if (conXzClg.IsVisible4Tea  ==  AttributeName[intIndex])
{
mbolIsVisible4Tea = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzClg.IsVisible4Tea);
}
else if (conXzClg.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzClg.OrderNum);
}
else if (conXzClg.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conXzClg.ModifyDate);
}
else if (conXzClg.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conXzClg.ModifyUserId);
}
else if (conXzClg.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzClg.Memo);
}
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
 AddUpdatedFld(conXzClg.IdXzCollege);
}
}
/// <summary>
/// CollegeId(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeId
{
get
{
return mstrCollegeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeId = value;
}
else
{
 mstrCollegeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzClg.CollegeId);
}
}
/// <summary>
/// 学院名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
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
 AddUpdatedFld(conXzClg.CollegeName);
}
}
/// <summary>
/// CollegeNameA(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeNameA
{
get
{
return mstrCollegeNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeNameA = value;
}
else
{
 mstrCollegeNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzClg.CollegeNameA);
}
}
/// <summary>
/// ClgEnglishName(说明:;字段类型:varchar;字段长度:60;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ClgEnglishName
{
get
{
return mstrClgEnglishName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrClgEnglishName = value;
}
else
{
 mstrClgEnglishName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzClg.ClgEnglishName);
}
}
/// <summary>
/// 用户类型(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserType
{
get
{
return mstrUserType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserType = value;
}
else
{
 mstrUserType = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzClg.UserType);
}
}
/// <summary>
/// CollegeIdInGP(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CollegeIdInGP
{
get
{
return mstrCollegeIdInGP;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCollegeIdInGP = value;
}
else
{
 mstrCollegeIdInGP = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzClg.CollegeIdInGP);
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
 AddUpdatedFld(conXzClg.IdSchool);
}
}
/// <summary>
/// IdUni(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdUni
{
get
{
return mstrIdUni;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdUni = value;
}
else
{
 mstrIdUni = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzClg.IdUni);
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
 AddUpdatedFld(conXzClg.PhoneNumber);
}
}
/// <summary>
/// WebSite(说明:;字段类型:varchar;字段长度:60;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string WebSite
{
get
{
return mstrWebSite;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrWebSite = value;
}
else
{
 mstrWebSite = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzClg.WebSite);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(conXzClg.IsVisible);
}
}
/// <summary>
/// IsVisible4Tea(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible4Tea
{
get
{
return mbolIsVisible4Tea;
}
set
{
 mbolIsVisible4Tea = value;
//记录修改过的字段
 AddUpdatedFld(conXzClg.IsVisible4Tea);
}
}
/// <summary>
/// 排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conXzClg.OrderNum);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzClg.ModifyDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserId
{
get
{
return mstrModifyUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserId = value;
}
else
{
 mstrModifyUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzClg.ModifyUserId);
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
 AddUpdatedFld(conXzClg.Memo);
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
  return mstrIdXzCollege;
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
  return mstrCollegeName;
 }
 }
}
 /// <summary>
 /// XzClg(XzClg)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzClg
{
public const string _CurrTabName = "XzClg"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdXzCollege"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdXzCollege", "CollegeId", "CollegeName", "CollegeNameA", "ClgEnglishName", "UserType", "CollegeIdInGP", "IdSchool", "IdUni", "PhoneNumber", "WebSite", "IsVisible", "IsVisible4Tea", "OrderNum", "ModifyDate", "ModifyUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdXzCollege"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdXzCollege = "IdXzCollege";    //学院Id

 /// <summary>
 /// 常量:"CollegeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeId = "CollegeId";    //CollegeId

 /// <summary>
 /// 常量:"CollegeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeName = "CollegeName";    //学院名

 /// <summary>
 /// 常量:"CollegeNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeNameA = "CollegeNameA";    //CollegeNameA

 /// <summary>
 /// 常量:"ClgEnglishName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ClgEnglishName = "ClgEnglishName";    //ClgEnglishName

 /// <summary>
 /// 常量:"UserType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserType = "UserType";    //用户类型

 /// <summary>
 /// 常量:"CollegeIdInGP"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CollegeIdInGP = "CollegeIdInGP";    //CollegeIdInGP

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"IdUni"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdUni = "IdUni";    //IdUni

 /// <summary>
 /// 常量:"PhoneNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PhoneNumber = "PhoneNumber";    //电话号码

 /// <summary>
 /// 常量:"WebSite"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebSite = "WebSite";    //WebSite

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"IsVisible4Tea"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible4Tea = "IsVisible4Tea";    //IsVisible4Tea

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}