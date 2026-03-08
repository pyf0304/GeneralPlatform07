
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjModuleEN
 表名:QxPrjModule(00140021)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:17:03
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
 /// 表QxPrjModule的关键字(ModuleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ModuleId_QxPrjModule
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strModuleId">表关键字</param>
public K_ModuleId_QxPrjModule(string strModuleId)
{
if (IsValid(strModuleId)) Value = strModuleId;
else
{
Value = null;
}
}
private static bool IsValid(string strModuleId)
{
if (string.IsNullOrEmpty(strModuleId) == true) return false;
if (strModuleId.Length != 6) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ModuleId_QxPrjModule]类型的对象</returns>
public static implicit operator K_ModuleId_QxPrjModule(string value)
{
return new K_ModuleId_QxPrjModule(value);
}
}
 /// <summary>
 /// 项目模块(QxPrjModule)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxPrjModuleEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxPrjModule"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ModuleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"ModuleId", "ModuleName", "QxPrjId", "Memo"};

protected string mstrModuleId;    //模块号
protected string mstrModuleName;    //模块名称
protected string mstrQxPrjId;    //项目Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxPrjModuleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ModuleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strModuleId">关键字:模块号</param>
public clsQxPrjModuleEN(string strModuleId)
 {
strModuleId = strModuleId.Replace("'", "''");
if (strModuleId.Length > 6)
{
throw new Exception("在表:QxPrjModule中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strModuleId)  ==  true)
{
throw new Exception("在表:QxPrjModule中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strModuleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrModuleId = strModuleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ModuleId");
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
if (strAttributeName  ==  conQxPrjModule.ModuleId)
{
return mstrModuleId;
}
else if (strAttributeName  ==  conQxPrjModule.ModuleName)
{
return mstrModuleName;
}
else if (strAttributeName  ==  conQxPrjModule.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxPrjModule.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxPrjModule.ModuleId)
{
mstrModuleId = value.ToString();
 AddUpdatedFld(conQxPrjModule.ModuleId);
}
else if (strAttributeName  ==  conQxPrjModule.ModuleName)
{
mstrModuleName = value.ToString();
 AddUpdatedFld(conQxPrjModule.ModuleName);
}
else if (strAttributeName  ==  conQxPrjModule.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjModule.QxPrjId);
}
else if (strAttributeName  ==  conQxPrjModule.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjModule.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxPrjModule.ModuleId  ==  AttributeName[intIndex])
{
return mstrModuleId;
}
else if (conQxPrjModule.ModuleName  ==  AttributeName[intIndex])
{
return mstrModuleName;
}
else if (conQxPrjModule.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxPrjModule.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxPrjModule.ModuleId  ==  AttributeName[intIndex])
{
mstrModuleId = value.ToString();
 AddUpdatedFld(conQxPrjModule.ModuleId);
}
else if (conQxPrjModule.ModuleName  ==  AttributeName[intIndex])
{
mstrModuleName = value.ToString();
 AddUpdatedFld(conQxPrjModule.ModuleName);
}
else if (conQxPrjModule.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjModule.QxPrjId);
}
else if (conQxPrjModule.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjModule.Memo);
}
}
}

/// <summary>
/// 模块号(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModuleId
{
get
{
return mstrModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModuleId = value;
}
else
{
 mstrModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjModule.ModuleId);
}
}
/// <summary>
/// 模块名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModuleName
{
get
{
return mstrModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModuleName = value;
}
else
{
 mstrModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjModule.ModuleName);
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
 AddUpdatedFld(conQxPrjModule.QxPrjId);
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
 AddUpdatedFld(conQxPrjModule.Memo);
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
  return mstrModuleId;
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
  return mstrModuleName;
 }
 }
}
 /// <summary>
 /// 项目模块(QxPrjModule)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxPrjModule
{
public const string _CurrTabName = "QxPrjModule"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ModuleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ModuleId", "ModuleName", "QxPrjId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModuleId = "ModuleId";    //模块号

 /// <summary>
 /// 常量:"ModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModuleName = "ModuleName";    //模块名称

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}