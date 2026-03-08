
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSubjectTypeEN
 表名:SubjectType(00140036)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:24:06
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:系统参数(SysPara)
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
 /// 表SubjectType的关键字(SubjectTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_SubjectTypeId_SubjectType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSubjectTypeId">表关键字</param>
public K_SubjectTypeId_SubjectType(string strSubjectTypeId)
{
if (IsValid(strSubjectTypeId)) Value = strSubjectTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strSubjectTypeId)
{
if (string.IsNullOrEmpty(strSubjectTypeId) == true) return false;
if (strSubjectTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SubjectTypeId_SubjectType]类型的对象</returns>
public static implicit operator K_SubjectTypeId_SubjectType(string value)
{
return new K_SubjectTypeId_SubjectType(value);
}
}
 /// <summary>
 /// 学科类型(SubjectType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSubjectTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "SubjectType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "SubjectTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"SubjectTypeId", "SubjectTypeName", "Memo"};

protected string mstrSubjectTypeId;    //学科类型ID
protected string mstrSubjectTypeName;    //学科类型
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSubjectTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SubjectTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSubjectTypeId">关键字:学科类型ID</param>
public clsSubjectTypeEN(string strSubjectTypeId)
 {
strSubjectTypeId = strSubjectTypeId.Replace("'", "''");
if (strSubjectTypeId.Length > 2)
{
throw new Exception("在表:SubjectType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSubjectTypeId)  ==  true)
{
throw new Exception("在表:SubjectType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSubjectTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSubjectTypeId = strSubjectTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("SubjectTypeId");
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
if (strAttributeName  ==  conSubjectType.SubjectTypeId)
{
return mstrSubjectTypeId;
}
else if (strAttributeName  ==  conSubjectType.SubjectTypeName)
{
return mstrSubjectTypeName;
}
else if (strAttributeName  ==  conSubjectType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conSubjectType.SubjectTypeId)
{
mstrSubjectTypeId = value.ToString();
 AddUpdatedFld(conSubjectType.SubjectTypeId);
}
else if (strAttributeName  ==  conSubjectType.SubjectTypeName)
{
mstrSubjectTypeName = value.ToString();
 AddUpdatedFld(conSubjectType.SubjectTypeName);
}
else if (strAttributeName  ==  conSubjectType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSubjectType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conSubjectType.SubjectTypeId  ==  AttributeName[intIndex])
{
return mstrSubjectTypeId;
}
else if (conSubjectType.SubjectTypeName  ==  AttributeName[intIndex])
{
return mstrSubjectTypeName;
}
else if (conSubjectType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conSubjectType.SubjectTypeId  ==  AttributeName[intIndex])
{
mstrSubjectTypeId = value.ToString();
 AddUpdatedFld(conSubjectType.SubjectTypeId);
}
else if (conSubjectType.SubjectTypeName  ==  AttributeName[intIndex])
{
mstrSubjectTypeName = value.ToString();
 AddUpdatedFld(conSubjectType.SubjectTypeName);
}
else if (conSubjectType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conSubjectType.Memo);
}
}
}

/// <summary>
/// 学科类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubjectTypeId
{
get
{
return mstrSubjectTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubjectTypeId = value;
}
else
{
 mstrSubjectTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conSubjectType.SubjectTypeId);
}
}
/// <summary>
/// 学科类型(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SubjectTypeName
{
get
{
return mstrSubjectTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSubjectTypeName = value;
}
else
{
 mstrSubjectTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conSubjectType.SubjectTypeName);
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
 AddUpdatedFld(conSubjectType.Memo);
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
  return mstrSubjectTypeId;
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
  return mstrSubjectTypeName;
 }
 }
}
 /// <summary>
 /// 学科类型(SubjectType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conSubjectType
{
public const string _CurrTabName = "SubjectType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SubjectTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"SubjectTypeId", "SubjectTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"SubjectTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubjectTypeId = "SubjectTypeId";    //学科类型ID

 /// <summary>
 /// 常量:"SubjectTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubjectTypeName = "SubjectTypeName";    //学科类型

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}