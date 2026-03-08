
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxViewPotenceEN
 表名:vQxViewPotence(00140028)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:43:51
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:界面管理(InterfaceMan)
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
 /// 表vQxViewPotence的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vQxViewPotence
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vQxViewPotence(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vQxViewPotence]类型的对象</returns>
public static implicit operator K_mId_vQxViewPotence(long value)
{
return new K_mId_vQxViewPotence(value);
}
}
 /// <summary>
 /// v界面权限(vQxViewPotence)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxViewPotenceEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxViewPotence"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"mId", "QxPrjId", "PotenceId", "PotenceName", "PrjName", "ViewId", "ViewName", "Level", "ModuleId", "ModuleName", "Memo"};

protected long mlngmId;    //流水号
protected string mstrQxPrjId;    //项目Id
protected string mstrPotenceId;    //权限ID
protected string mstrPotenceName;    //权限名称
protected string mstrPrjName;    //工程名
protected string mstrViewId;    //界面编号
protected string mstrViewName;    //界面名称
protected int mintLevel;    //等级
protected string mstrModuleId;    //模块号
protected string mstrModuleName;    //模块名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxViewPotenceEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:流水号</param>
public clsvQxViewPotenceEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convQxViewPotence.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convQxViewPotence.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxViewPotence.PotenceId)
{
return mstrPotenceId;
}
else if (strAttributeName  ==  convQxViewPotence.PotenceName)
{
return mstrPotenceName;
}
else if (strAttributeName  ==  convQxViewPotence.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxViewPotence.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  convQxViewPotence.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  convQxViewPotence.Level)
{
return mintLevel;
}
else if (strAttributeName  ==  convQxViewPotence.ModuleId)
{
return mstrModuleId;
}
else if (strAttributeName  ==  convQxViewPotence.ModuleName)
{
return mstrModuleName;
}
else if (strAttributeName  ==  convQxViewPotence.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxViewPotence.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxViewPotence.mId);
}
else if (strAttributeName  ==  convQxViewPotence.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxViewPotence.QxPrjId);
}
else if (strAttributeName  ==  convQxViewPotence.PotenceId)
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(convQxViewPotence.PotenceId);
}
else if (strAttributeName  ==  convQxViewPotence.PotenceName)
{
mstrPotenceName = value.ToString();
 AddUpdatedFld(convQxViewPotence.PotenceName);
}
else if (strAttributeName  ==  convQxViewPotence.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxViewPotence.PrjName);
}
else if (strAttributeName  ==  convQxViewPotence.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(convQxViewPotence.ViewId);
}
else if (strAttributeName  ==  convQxViewPotence.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(convQxViewPotence.ViewName);
}
else if (strAttributeName  ==  convQxViewPotence.Level)
{
mintLevel = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxViewPotence.Level);
}
else if (strAttributeName  ==  convQxViewPotence.ModuleId)
{
mstrModuleId = value.ToString();
 AddUpdatedFld(convQxViewPotence.ModuleId);
}
else if (strAttributeName  ==  convQxViewPotence.ModuleName)
{
mstrModuleName = value.ToString();
 AddUpdatedFld(convQxViewPotence.ModuleName);
}
else if (strAttributeName  ==  convQxViewPotence.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxViewPotence.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxViewPotence.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convQxViewPotence.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxViewPotence.PotenceId  ==  AttributeName[intIndex])
{
return mstrPotenceId;
}
else if (convQxViewPotence.PotenceName  ==  AttributeName[intIndex])
{
return mstrPotenceName;
}
else if (convQxViewPotence.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxViewPotence.ViewId  ==  AttributeName[intIndex])
{
return mstrViewId;
}
else if (convQxViewPotence.ViewName  ==  AttributeName[intIndex])
{
return mstrViewName;
}
else if (convQxViewPotence.Level  ==  AttributeName[intIndex])
{
return mintLevel;
}
else if (convQxViewPotence.ModuleId  ==  AttributeName[intIndex])
{
return mstrModuleId;
}
else if (convQxViewPotence.ModuleName  ==  AttributeName[intIndex])
{
return mstrModuleName;
}
else if (convQxViewPotence.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxViewPotence.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxViewPotence.mId);
}
else if (convQxViewPotence.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxViewPotence.QxPrjId);
}
else if (convQxViewPotence.PotenceId  ==  AttributeName[intIndex])
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(convQxViewPotence.PotenceId);
}
else if (convQxViewPotence.PotenceName  ==  AttributeName[intIndex])
{
mstrPotenceName = value.ToString();
 AddUpdatedFld(convQxViewPotence.PotenceName);
}
else if (convQxViewPotence.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxViewPotence.PrjName);
}
else if (convQxViewPotence.ViewId  ==  AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(convQxViewPotence.ViewId);
}
else if (convQxViewPotence.ViewName  ==  AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(convQxViewPotence.ViewName);
}
else if (convQxViewPotence.Level  ==  AttributeName[intIndex])
{
mintLevel = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxViewPotence.Level);
}
else if (convQxViewPotence.ModuleId  ==  AttributeName[intIndex])
{
mstrModuleId = value.ToString();
 AddUpdatedFld(convQxViewPotence.ModuleId);
}
else if (convQxViewPotence.ModuleName  ==  AttributeName[intIndex])
{
mstrModuleName = value.ToString();
 AddUpdatedFld(convQxViewPotence.ModuleName);
}
else if (convQxViewPotence.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxViewPotence.Memo);
}
}
}

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convQxViewPotence.mId);
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
 AddUpdatedFld(convQxViewPotence.QxPrjId);
}
}
/// <summary>
/// 权限ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PotenceId
{
get
{
return mstrPotenceId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPotenceId = value;
}
else
{
 mstrPotenceId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxViewPotence.PotenceId);
}
}
/// <summary>
/// 权限名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PotenceName
{
get
{
return mstrPotenceName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPotenceName = value;
}
else
{
 mstrPotenceName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxViewPotence.PotenceName);
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
 AddUpdatedFld(convQxViewPotence.PrjName);
}
}
/// <summary>
/// 界面编号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewId
{
get
{
return mstrViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewId = value;
}
else
{
 mstrViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxViewPotence.ViewId);
}
}
/// <summary>
/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewName
{
get
{
return mstrViewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewName = value;
}
else
{
 mstrViewName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxViewPotence.ViewName);
}
}
/// <summary>
/// 等级(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int Level
{
get
{
return mintLevel;
}
set
{
 mintLevel = value;
//记录修改过的字段
 AddUpdatedFld(convQxViewPotence.Level);
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
 AddUpdatedFld(convQxViewPotence.ModuleId);
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
 AddUpdatedFld(convQxViewPotence.ModuleName);
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
 AddUpdatedFld(convQxViewPotence.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// v界面权限(vQxViewPotence)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxViewPotence
{
public const string _CurrTabName = "vQxViewPotence"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "QxPrjId", "PotenceId", "PotenceName", "PrjName", "ViewId", "ViewName", "Level", "ModuleId", "ModuleName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //流水号

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"PotenceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PotenceId = "PotenceId";    //权限ID

 /// <summary>
 /// 常量:"PotenceName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PotenceName = "PotenceName";    //权限名称

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名

 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面编号

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"Level"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Level = "Level";    //等级

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}