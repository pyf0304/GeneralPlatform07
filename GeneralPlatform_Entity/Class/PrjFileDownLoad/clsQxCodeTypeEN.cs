
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxCodeTypeEN
 表名:QxCodeType(00140057)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:26:37
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程文件下载(PrjFileDownLoad)
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
 /// 表QxCodeType的关键字(QxCodeTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QxCodeTypeId_QxCodeType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strQxCodeTypeId">表关键字</param>
public K_QxCodeTypeId_QxCodeType(string strQxCodeTypeId)
{
if (IsValid(strQxCodeTypeId)) Value = strQxCodeTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strQxCodeTypeId)
{
if (string.IsNullOrEmpty(strQxCodeTypeId) == true) return false;
if (strQxCodeTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QxCodeTypeId_QxCodeType]类型的对象</returns>
public static implicit operator K_QxCodeTypeId_QxCodeType(string value)
{
return new K_QxCodeTypeId_QxCodeType(value);
}
}
 /// <summary>
 /// 代码类型(QxCodeType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxCodeTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxCodeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QxCodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"QxCodeTypeId", "CodeTypeName", "Memo"};

protected string mstrQxCodeTypeId;    //代码类型Id
protected string mstrCodeTypeName;    //代码类型名
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxCodeTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QxCodeTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strQxCodeTypeId">关键字:代码类型Id</param>
public clsQxCodeTypeEN(string strQxCodeTypeId)
 {
strQxCodeTypeId = strQxCodeTypeId.Replace("'", "''");
if (strQxCodeTypeId.Length > 4)
{
throw new Exception("在表:QxCodeType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQxCodeTypeId)  ==  true)
{
throw new Exception("在表:QxCodeType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQxCodeTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrQxCodeTypeId = strQxCodeTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QxCodeTypeId");
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
if (strAttributeName  ==  conQxCodeType.QxCodeTypeId)
{
return mstrQxCodeTypeId;
}
else if (strAttributeName  ==  conQxCodeType.CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  conQxCodeType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxCodeType.QxCodeTypeId)
{
mstrQxCodeTypeId = value.ToString();
 AddUpdatedFld(conQxCodeType.QxCodeTypeId);
}
else if (strAttributeName  ==  conQxCodeType.CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(conQxCodeType.CodeTypeName);
}
else if (strAttributeName  ==  conQxCodeType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxCodeType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxCodeType.QxCodeTypeId  ==  AttributeName[intIndex])
{
return mstrQxCodeTypeId;
}
else if (conQxCodeType.CodeTypeName  ==  AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (conQxCodeType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxCodeType.QxCodeTypeId  ==  AttributeName[intIndex])
{
mstrQxCodeTypeId = value.ToString();
 AddUpdatedFld(conQxCodeType.QxCodeTypeId);
}
else if (conQxCodeType.CodeTypeName  ==  AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(conQxCodeType.CodeTypeName);
}
else if (conQxCodeType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxCodeType.Memo);
}
}
}

/// <summary>
/// 代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QxCodeTypeId
{
get
{
return mstrQxCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQxCodeTypeId = value;
}
else
{
 mstrQxCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxCodeType.QxCodeTypeId);
}
}
/// <summary>
/// 代码类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeName
{
get
{
return mstrCodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeName = value;
}
else
{
 mstrCodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxCodeType.CodeTypeName);
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
 AddUpdatedFld(conQxCodeType.Memo);
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
  return mstrQxCodeTypeId;
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
  return mstrCodeTypeName;
 }
 }
}
 /// <summary>
 /// 代码类型(QxCodeType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxCodeType
{
public const string _CurrTabName = "QxCodeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QxCodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QxCodeTypeId", "CodeTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"QxCodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxCodeTypeId = "QxCodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"CodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeName = "CodeTypeName";    //代码类型名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}