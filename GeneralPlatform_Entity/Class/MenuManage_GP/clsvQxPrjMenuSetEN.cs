
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenuSetEN
 表名:vQxPrjMenuSet(00140072)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:34:20
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:菜单管理(MenuManage_GP)
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
 /// 表vQxPrjMenuSet的关键字(MenuSetId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MenuSetId_vQxPrjMenuSet
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strMenuSetId">表关键字</param>
public K_MenuSetId_vQxPrjMenuSet(string strMenuSetId)
{
if (IsValid(strMenuSetId)) Value = strMenuSetId;
else
{
Value = null;
}
}
private static bool IsValid(string strMenuSetId)
{
if (string.IsNullOrEmpty(strMenuSetId) == true) return false;
if (strMenuSetId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MenuSetId_vQxPrjMenuSet]类型的对象</returns>
public static implicit operator K_MenuSetId_vQxPrjMenuSet(string value)
{
return new K_MenuSetId_vQxPrjMenuSet(value);
}
}
 /// <summary>
 /// v菜单集(vQxPrjMenuSet)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxPrjMenuSetEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxPrjMenuSet"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MenuSetId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"MenuSetId", "MenuSetName", "QxPrjId", "PrjName", "IsDefault", "Memo"};

protected string mstrMenuSetId;    //菜单集Id
protected string mstrMenuSetName;    //菜单集名称
protected string mstrQxPrjId;    //项目Id
protected string mstrPrjName;    //工程名
protected bool mbolIsDefault;    //是否默认
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxPrjMenuSetEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MenuSetId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strMenuSetId">关键字:菜单集Id</param>
public clsvQxPrjMenuSetEN(string strMenuSetId)
 {
strMenuSetId = strMenuSetId.Replace("'", "''");
if (strMenuSetId.Length > 4)
{
throw new Exception("在表:vQxPrjMenuSet中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strMenuSetId)  ==  true)
{
throw new Exception("在表:vQxPrjMenuSet中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMenuSetId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrMenuSetId = strMenuSetId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MenuSetId");
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
if (strAttributeName  ==  convQxPrjMenuSet.MenuSetId)
{
return mstrMenuSetId;
}
else if (strAttributeName  ==  convQxPrjMenuSet.MenuSetName)
{
return mstrMenuSetName;
}
else if (strAttributeName  ==  convQxPrjMenuSet.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxPrjMenuSet.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxPrjMenuSet.IsDefault)
{
return mbolIsDefault;
}
else if (strAttributeName  ==  convQxPrjMenuSet.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxPrjMenuSet.MenuSetId)
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(convQxPrjMenuSet.MenuSetId);
}
else if (strAttributeName  ==  convQxPrjMenuSet.MenuSetName)
{
mstrMenuSetName = value.ToString();
 AddUpdatedFld(convQxPrjMenuSet.MenuSetName);
}
else if (strAttributeName  ==  convQxPrjMenuSet.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPrjMenuSet.QxPrjId);
}
else if (strAttributeName  ==  convQxPrjMenuSet.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPrjMenuSet.PrjName);
}
else if (strAttributeName  ==  convQxPrjMenuSet.IsDefault)
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjMenuSet.IsDefault);
}
else if (strAttributeName  ==  convQxPrjMenuSet.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPrjMenuSet.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxPrjMenuSet.MenuSetId  ==  AttributeName[intIndex])
{
return mstrMenuSetId;
}
else if (convQxPrjMenuSet.MenuSetName  ==  AttributeName[intIndex])
{
return mstrMenuSetName;
}
else if (convQxPrjMenuSet.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxPrjMenuSet.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxPrjMenuSet.IsDefault  ==  AttributeName[intIndex])
{
return mbolIsDefault;
}
else if (convQxPrjMenuSet.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxPrjMenuSet.MenuSetId  ==  AttributeName[intIndex])
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(convQxPrjMenuSet.MenuSetId);
}
else if (convQxPrjMenuSet.MenuSetName  ==  AttributeName[intIndex])
{
mstrMenuSetName = value.ToString();
 AddUpdatedFld(convQxPrjMenuSet.MenuSetName);
}
else if (convQxPrjMenuSet.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPrjMenuSet.QxPrjId);
}
else if (convQxPrjMenuSet.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPrjMenuSet.PrjName);
}
else if (convQxPrjMenuSet.IsDefault  ==  AttributeName[intIndex])
{
mbolIsDefault = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjMenuSet.IsDefault);
}
else if (convQxPrjMenuSet.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPrjMenuSet.Memo);
}
}
}

/// <summary>
/// 菜单集Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuSetId
{
get
{
return mstrMenuSetId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuSetId = value;
}
else
{
 mstrMenuSetId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenuSet.MenuSetId);
}
}
/// <summary>
/// 菜单集名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuSetName
{
get
{
return mstrMenuSetName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuSetName = value;
}
else
{
 mstrMenuSetName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenuSet.MenuSetName);
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
 AddUpdatedFld(convQxPrjMenuSet.QxPrjId);
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
 AddUpdatedFld(convQxPrjMenuSet.PrjName);
}
}
/// <summary>
/// 是否默认(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDefault
{
get
{
return mbolIsDefault;
}
set
{
 mbolIsDefault = value;
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenuSet.IsDefault);
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
 AddUpdatedFld(convQxPrjMenuSet.Memo);
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
  return mstrMenuSetId;
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
  return mstrMenuSetName;
 }
 }
}
 /// <summary>
 /// v菜单集(vQxPrjMenuSet)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxPrjMenuSet
{
public const string _CurrTabName = "vQxPrjMenuSet"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MenuSetId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MenuSetId", "MenuSetName", "QxPrjId", "PrjName", "IsDefault", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"MenuSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuSetId = "MenuSetId";    //菜单集Id

 /// <summary>
 /// 常量:"MenuSetName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuSetName = "MenuSetName";    //菜单集名称

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
 /// 常量:"IsDefault"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDefault = "IsDefault";    //是否默认

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}