
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsers_SchoolEN
 表名:QxUsers_School(00140074)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:00:55
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
 /// 表QxUsers_School的关键字(UserId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_UserId_QxUsers_School
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
public K_UserId_QxUsers_School(string strUserId)
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
 /// <returns>返回:[K_UserId_QxUsers_School]类型的对象</returns>
public static implicit operator K_UserId_QxUsers_School(string value)
{
return new K_UserId_QxUsers_School(value);
}
}
 /// <summary>
 /// 用户_学校(QxUsers_School)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUsers_SchoolEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUsers_School"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"UserId", "IdentityId", "CardNo", "StuTeacherId", "IdGradeBase", "CardState", "IsLeaved", "UpdDate", "UpdUser", "Memo"};

protected string mstrUserId;    //用户ID
protected string mstrIdentityId;    //身份编号
protected string mstrCardNo;    //卡号
protected string mstrStuTeacherId;    //学工号
protected string mstrIdGradeBase;    //年级流水号
protected string mstrCardState;    //卡状态
protected bool mbolIsLeaved;    //IsLeaved
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUsers_SchoolEN()
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
public clsQxUsers_SchoolEN(string strUserId)
 {
strUserId = strUserId.Replace("'", "''");
if (strUserId.Length > 18)
{
throw new Exception("在表:QxUsers_School中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserId)  ==  true)
{
throw new Exception("在表:QxUsers_School中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conQxUsers_School.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conQxUsers_School.IdentityId)
{
return mstrIdentityId;
}
else if (strAttributeName  ==  conQxUsers_School.CardNo)
{
return mstrCardNo;
}
else if (strAttributeName  ==  conQxUsers_School.StuTeacherId)
{
return mstrStuTeacherId;
}
else if (strAttributeName  ==  conQxUsers_School.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  conQxUsers_School.CardState)
{
return mstrCardState;
}
else if (strAttributeName  ==  conQxUsers_School.IsLeaved)
{
return mbolIsLeaved;
}
else if (strAttributeName  ==  conQxUsers_School.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxUsers_School.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQxUsers_School.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUsers_School.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUsers_School.UserId);
}
else if (strAttributeName  ==  conQxUsers_School.IdentityId)
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(conQxUsers_School.IdentityId);
}
else if (strAttributeName  ==  conQxUsers_School.CardNo)
{
mstrCardNo = value.ToString();
 AddUpdatedFld(conQxUsers_School.CardNo);
}
else if (strAttributeName  ==  conQxUsers_School.StuTeacherId)
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(conQxUsers_School.StuTeacherId);
}
else if (strAttributeName  ==  conQxUsers_School.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conQxUsers_School.IdGradeBase);
}
else if (strAttributeName  ==  conQxUsers_School.CardState)
{
mstrCardState = value.ToString();
 AddUpdatedFld(conQxUsers_School.CardState);
}
else if (strAttributeName  ==  conQxUsers_School.IsLeaved)
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsers_School.IsLeaved);
}
else if (strAttributeName  ==  conQxUsers_School.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUsers_School.UpdDate);
}
else if (strAttributeName  ==  conQxUsers_School.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxUsers_School.UpdUser);
}
else if (strAttributeName  ==  conQxUsers_School.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUsers_School.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUsers_School.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conQxUsers_School.IdentityId  ==  AttributeName[intIndex])
{
return mstrIdentityId;
}
else if (conQxUsers_School.CardNo  ==  AttributeName[intIndex])
{
return mstrCardNo;
}
else if (conQxUsers_School.StuTeacherId  ==  AttributeName[intIndex])
{
return mstrStuTeacherId;
}
else if (conQxUsers_School.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (conQxUsers_School.CardState  ==  AttributeName[intIndex])
{
return mstrCardState;
}
else if (conQxUsers_School.IsLeaved  ==  AttributeName[intIndex])
{
return mbolIsLeaved;
}
else if (conQxUsers_School.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxUsers_School.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQxUsers_School.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxUsers_School.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUsers_School.UserId);
}
else if (conQxUsers_School.IdentityId  ==  AttributeName[intIndex])
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(conQxUsers_School.IdentityId);
}
else if (conQxUsers_School.CardNo  ==  AttributeName[intIndex])
{
mstrCardNo = value.ToString();
 AddUpdatedFld(conQxUsers_School.CardNo);
}
else if (conQxUsers_School.StuTeacherId  ==  AttributeName[intIndex])
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(conQxUsers_School.StuTeacherId);
}
else if (conQxUsers_School.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conQxUsers_School.IdGradeBase);
}
else if (conQxUsers_School.CardState  ==  AttributeName[intIndex])
{
mstrCardState = value.ToString();
 AddUpdatedFld(conQxUsers_School.CardState);
}
else if (conQxUsers_School.IsLeaved  ==  AttributeName[intIndex])
{
mbolIsLeaved = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsers_School.IsLeaved);
}
else if (conQxUsers_School.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUsers_School.UpdDate);
}
else if (conQxUsers_School.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxUsers_School.UpdUser);
}
else if (conQxUsers_School.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUsers_School.Memo);
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
 AddUpdatedFld(conQxUsers_School.UserId);
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
 AddUpdatedFld(conQxUsers_School.IdentityId);
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
 AddUpdatedFld(conQxUsers_School.CardNo);
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
 AddUpdatedFld(conQxUsers_School.StuTeacherId);
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
 AddUpdatedFld(conQxUsers_School.IdGradeBase);
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
 AddUpdatedFld(conQxUsers_School.CardState);
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
 AddUpdatedFld(conQxUsers_School.IsLeaved);
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
 AddUpdatedFld(conQxUsers_School.UpdDate);
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
 AddUpdatedFld(conQxUsers_School.UpdUser);
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
 AddUpdatedFld(conQxUsers_School.Memo);
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
 /// 用户_学校(QxUsers_School)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUsers_School
{
public const string _CurrTabName = "QxUsers_School"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"UserId", "IdentityId", "CardNo", "StuTeacherId", "IdGradeBase", "CardState", "IsLeaved", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"IdentityId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityId = "IdentityId";    //身份编号

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