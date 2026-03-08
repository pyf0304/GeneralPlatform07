
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserIdentityEN
 表名:QxUserIdentity(00140042)
 * 版本:2023.12.07.1(服务器:WIN-SRV103-116)
 日期:2023/12/20 22:54:58
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
 /// 表QxUserIdentity的关键字(IdentityId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdentityId_QxUserIdentity
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdentityId">表关键字</param>
public K_IdentityId_QxUserIdentity(string strIdentityId)
{
if (IsValid(strIdentityId)) Value = strIdentityId;
else
{
Value = null;
}
}
private static bool IsValid(string strIdentityId)
{
if (string.IsNullOrEmpty(strIdentityId) == true) return false;
if (strIdentityId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdentityId_QxUserIdentity]类型的对象</returns>
public static implicit operator K_IdentityId_QxUserIdentity(string value)
{
return new K_IdentityId_QxUserIdentity(value);
}
}
 /// <summary>
 /// 用户权限身份(QxUserIdentity)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserIdentityEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUserIdentity"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdentityId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"IdentityId", "IdentityDesc", "IdentityEnName", "UserType", "Memo"};

protected string mstrIdentityId;    //身份编号
protected string mstrIdentityDesc;    //身份描述
protected string mstrIdentityEnName;    //身份英文名
protected string mstrUserType;    //用户类型
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserIdentityEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdentityId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdentityId">关键字:身份编号</param>
public clsQxUserIdentityEN(string strIdentityId)
 {
strIdentityId = strIdentityId.Replace("'", "''");
if (strIdentityId.Length > 2)
{
throw new Exception("在表:QxUserIdentity中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdentityId)  ==  true)
{
throw new Exception("在表:QxUserIdentity中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdentityId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdentityId = strIdentityId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdentityId");
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
if (strAttributeName  ==  conQxUserIdentity.IdentityId)
{
return mstrIdentityId;
}
else if (strAttributeName  ==  conQxUserIdentity.IdentityDesc)
{
return mstrIdentityDesc;
}
else if (strAttributeName  ==  conQxUserIdentity.IdentityEnName)
{
return mstrIdentityEnName;
}
else if (strAttributeName  ==  conQxUserIdentity.UserType)
{
return mstrUserType;
}
else if (strAttributeName  ==  conQxUserIdentity.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUserIdentity.IdentityId)
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(conQxUserIdentity.IdentityId);
}
else if (strAttributeName  ==  conQxUserIdentity.IdentityDesc)
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(conQxUserIdentity.IdentityDesc);
}
else if (strAttributeName  ==  conQxUserIdentity.IdentityEnName)
{
mstrIdentityEnName = value.ToString();
 AddUpdatedFld(conQxUserIdentity.IdentityEnName);
}
else if (strAttributeName  ==  conQxUserIdentity.UserType)
{
mstrUserType = value.ToString();
 AddUpdatedFld(conQxUserIdentity.UserType);
}
else if (strAttributeName  ==  conQxUserIdentity.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserIdentity.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUserIdentity.IdentityId  ==  AttributeName[intIndex])
{
return mstrIdentityId;
}
else if (conQxUserIdentity.IdentityDesc  ==  AttributeName[intIndex])
{
return mstrIdentityDesc;
}
else if (conQxUserIdentity.IdentityEnName  ==  AttributeName[intIndex])
{
return mstrIdentityEnName;
}
else if (conQxUserIdentity.UserType  ==  AttributeName[intIndex])
{
return mstrUserType;
}
else if (conQxUserIdentity.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxUserIdentity.IdentityId  ==  AttributeName[intIndex])
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(conQxUserIdentity.IdentityId);
}
else if (conQxUserIdentity.IdentityDesc  ==  AttributeName[intIndex])
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(conQxUserIdentity.IdentityDesc);
}
else if (conQxUserIdentity.IdentityEnName  ==  AttributeName[intIndex])
{
mstrIdentityEnName = value.ToString();
 AddUpdatedFld(conQxUserIdentity.IdentityEnName);
}
else if (conQxUserIdentity.UserType  ==  AttributeName[intIndex])
{
mstrUserType = value.ToString();
 AddUpdatedFld(conQxUserIdentity.UserType);
}
else if (conQxUserIdentity.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserIdentity.Memo);
}
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
 AddUpdatedFld(conQxUserIdentity.IdentityId);
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
 AddUpdatedFld(conQxUserIdentity.IdentityDesc);
}
}
/// <summary>
/// 身份英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdentityEnName
{
get
{
return mstrIdentityEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdentityEnName = value;
}
else
{
 mstrIdentityEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserIdentity.IdentityEnName);
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
 AddUpdatedFld(conQxUserIdentity.UserType);
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
 AddUpdatedFld(conQxUserIdentity.Memo);
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
  return mstrIdentityId;
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
  return mstrIdentityDesc;
 }
 }
}
 /// <summary>
 /// 用户权限身份(QxUserIdentity)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUserIdentity
{
public const string _CurrTabName = "QxUserIdentity"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdentityId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdentityId", "IdentityDesc", "IdentityEnName", "UserType", "Memo"};
//以下是属性变量


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
 /// 常量:"IdentityEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityEnName = "IdentityEnName";    //身份英文名

 /// <summary>
 /// 常量:"UserType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserType = "UserType";    //用户类型

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}