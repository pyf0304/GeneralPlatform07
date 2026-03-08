
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxProjectsEN
 表名:QxProjects(00140006)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:17:25
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程管理(PrjManage_GP)
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
 /// 表QxProjects的关键字(QxPrjId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QxPrjId_QxProjects
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strQxPrjId">表关键字</param>
public K_QxPrjId_QxProjects(string strQxPrjId)
{
if (IsValid(strQxPrjId)) Value = strQxPrjId;
else
{
Value = null;
}
}
private static bool IsValid(string strQxPrjId)
{
if (string.IsNullOrEmpty(strQxPrjId) == true) return false;
if (strQxPrjId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QxPrjId_QxProjects]类型的对象</returns>
public static implicit operator K_QxPrjId_QxProjects(string value)
{
return new K_QxPrjId_QxProjects(value);
}
}
 /// <summary>
 /// 工程(QxProjects)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxProjectsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxProjects"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QxPrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"QxPrjId", "PrjName", "PrjDomain", "IsDefaultPrj", "QxPrjDataBaseId", "UpdDate", "UpdUser", "Memo"};

protected string mstrQxPrjId;    //项目Id
protected string mstrPrjName;    //工程名
protected string mstrPrjDomain;    //工程域名
protected bool mbolIsDefaultPrj;    //是否默认工程
protected string mstrQxPrjDataBaseId;    //项目数据库Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxProjectsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QxPrjId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strQxPrjId">关键字:项目Id</param>
public clsQxProjectsEN(string strQxPrjId)
 {
strQxPrjId = strQxPrjId.Replace("'", "''");
if (strQxPrjId.Length > 4)
{
throw new Exception("在表:QxProjects中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQxPrjId)  ==  true)
{
throw new Exception("在表:QxProjects中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQxPrjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrQxPrjId = strQxPrjId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QxPrjId");
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
if (strAttributeName  ==  conQxProjects.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxProjects.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  conQxProjects.PrjDomain)
{
return mstrPrjDomain;
}
else if (strAttributeName  ==  conQxProjects.IsDefaultPrj)
{
return mbolIsDefaultPrj;
}
else if (strAttributeName  ==  conQxProjects.QxPrjDataBaseId)
{
return mstrQxPrjDataBaseId;
}
else if (strAttributeName  ==  conQxProjects.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxProjects.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQxProjects.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxProjects.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxProjects.QxPrjId);
}
else if (strAttributeName  ==  conQxProjects.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(conQxProjects.PrjName);
}
else if (strAttributeName  ==  conQxProjects.PrjDomain)
{
mstrPrjDomain = value.ToString();
 AddUpdatedFld(conQxProjects.PrjDomain);
}
else if (strAttributeName  ==  conQxProjects.IsDefaultPrj)
{
mbolIsDefaultPrj = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxProjects.IsDefaultPrj);
}
else if (strAttributeName  ==  conQxProjects.QxPrjDataBaseId)
{
mstrQxPrjDataBaseId = value.ToString();
 AddUpdatedFld(conQxProjects.QxPrjDataBaseId);
}
else if (strAttributeName  ==  conQxProjects.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxProjects.UpdDate);
}
else if (strAttributeName  ==  conQxProjects.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxProjects.UpdUser);
}
else if (strAttributeName  ==  conQxProjects.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxProjects.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxProjects.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxProjects.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (conQxProjects.PrjDomain  ==  AttributeName[intIndex])
{
return mstrPrjDomain;
}
else if (conQxProjects.IsDefaultPrj  ==  AttributeName[intIndex])
{
return mbolIsDefaultPrj;
}
else if (conQxProjects.QxPrjDataBaseId  ==  AttributeName[intIndex])
{
return mstrQxPrjDataBaseId;
}
else if (conQxProjects.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxProjects.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQxProjects.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxProjects.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxProjects.QxPrjId);
}
else if (conQxProjects.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(conQxProjects.PrjName);
}
else if (conQxProjects.PrjDomain  ==  AttributeName[intIndex])
{
mstrPrjDomain = value.ToString();
 AddUpdatedFld(conQxProjects.PrjDomain);
}
else if (conQxProjects.IsDefaultPrj  ==  AttributeName[intIndex])
{
mbolIsDefaultPrj = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxProjects.IsDefaultPrj);
}
else if (conQxProjects.QxPrjDataBaseId  ==  AttributeName[intIndex])
{
mstrQxPrjDataBaseId = value.ToString();
 AddUpdatedFld(conQxProjects.QxPrjDataBaseId);
}
else if (conQxProjects.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxProjects.UpdDate);
}
else if (conQxProjects.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxProjects.UpdUser);
}
else if (conQxProjects.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxProjects.Memo);
}
}
}

/// <summary>
/// 项目Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QxPrjId
{
get
{
return mstrQxPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQxPrjId = value;
}
else
{
 mstrQxPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxProjects.QxPrjId);
}
}
/// <summary>
/// 工程名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxProjects.PrjName);
}
}
/// <summary>
/// 工程域名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjDomain
{
get
{
return mstrPrjDomain;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjDomain = value;
}
else
{
 mstrPrjDomain = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxProjects.PrjDomain);
}
}
/// <summary>
/// 是否默认工程(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDefaultPrj
{
get
{
return mbolIsDefaultPrj;
}
set
{
 mbolIsDefaultPrj = value;
//记录修改过的字段
 AddUpdatedFld(conQxProjects.IsDefaultPrj);
}
}
/// <summary>
/// 项目数据库Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QxPrjDataBaseId
{
get
{
return mstrQxPrjDataBaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQxPrjDataBaseId = value;
}
else
{
 mstrQxPrjDataBaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxProjects.QxPrjDataBaseId);
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
 AddUpdatedFld(conQxProjects.UpdDate);
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
 AddUpdatedFld(conQxProjects.UpdUser);
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
 AddUpdatedFld(conQxProjects.Memo);
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
  return mstrQxPrjId;
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
  return mstrPrjName;
 }
 }
}
 /// <summary>
 /// 工程(QxProjects)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxProjects
{
public const string _CurrTabName = "QxProjects"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QxPrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QxPrjId", "PrjName", "PrjDomain", "IsDefaultPrj", "QxPrjDataBaseId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名

 /// <summary>
 /// 常量:"PrjDomain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjDomain = "PrjDomain";    //工程域名

 /// <summary>
 /// 常量:"IsDefaultPrj"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefaultPrj = "IsDefaultPrj";    //是否默认工程

 /// <summary>
 /// 常量:"QxPrjDataBaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjDataBaseId = "QxPrjDataBaseId";    //项目数据库Id

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