
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRelaOfPotenceAndSymbolEN
 表名:vQxRelaOfPotenceAndSymbol(00140049)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:30:04
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:权限管理(PotenceMan)
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
 /// 表vQxRelaOfPotenceAndSymbol的关键字(RelaMid)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RelaMid_vQxRelaOfPotenceAndSymbol
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngRelaMid">表关键字</param>
public K_RelaMid_vQxRelaOfPotenceAndSymbol(long lngRelaMid)
{
if (IsValid(lngRelaMid)) Value = lngRelaMid;
else
{
Value = 0;
}
}
private static bool IsValid(long lngRelaMid)
{
if (lngRelaMid == 0) return false;
if (lngRelaMid == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RelaMid_vQxRelaOfPotenceAndSymbol]类型的对象</returns>
public static implicit operator K_RelaMid_vQxRelaOfPotenceAndSymbol(long value)
{
return new K_RelaMid_vQxRelaOfPotenceAndSymbol(value);
}
}
 /// <summary>
 /// v权限编程标志关系(vQxRelaOfPotenceAndSymbol)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxRelaOfPotenceAndSymbolEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxRelaOfPotenceAndSymbol"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RelaMid"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"RelaMid", "PotenceTypeName", "QxPrjId", "PotenceId", "PotenceName", "PrjName", "SymbolForProgramme", "SymbolName", "Memo", "PotenceTypeId", "UpdDate", "UpdUserId", "SymbolNum"};

protected long mlngRelaMid;    //流水号
protected string mstrPotenceTypeName;    //权限类型名
protected string mstrQxPrjId;    //项目Id
protected string mstrPotenceId;    //权限ID
protected string mstrPotenceName;    //权限名称
protected string mstrPrjName;    //工程名
protected string mstrSymbolForProgramme;    //编程标志
protected string mstrSymbolName;    //标志名称
protected string mstrMemo;    //备注
protected string mstrPotenceTypeId;    //权限类型Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected int? mintSymbolNum;    //标志数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxRelaOfPotenceAndSymbolEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RelaMid");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngRelaMid">关键字:流水号</param>
public clsvQxRelaOfPotenceAndSymbolEN(long lngRelaMid)
 {
 if (lngRelaMid  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngRelaMid = lngRelaMid;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RelaMid");
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
if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.RelaMid)
{
return mlngRelaMid;
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.PotenceTypeName)
{
return mstrPotenceTypeName;
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.PotenceId)
{
return mstrPotenceId;
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.PotenceName)
{
return mstrPotenceName;
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.SymbolForProgramme)
{
return mstrSymbolForProgramme;
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.SymbolName)
{
return mstrSymbolName;
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.PotenceTypeId)
{
return mstrPotenceTypeId;
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.SymbolNum)
{
return mintSymbolNum;
}
return null;
}
set
{
if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.RelaMid)
{
mlngRelaMid = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.RelaMid);
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.PotenceTypeName)
{
mstrPotenceTypeName = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.PotenceTypeName);
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.QxPrjId);
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.PotenceId)
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.PotenceId);
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.PotenceName)
{
mstrPotenceName = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.PotenceName);
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.PrjName);
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.SymbolForProgramme)
{
mstrSymbolForProgramme = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.SymbolForProgramme);
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.SymbolName)
{
mstrSymbolName = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.SymbolName);
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.Memo);
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.PotenceTypeId)
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.PotenceTypeId);
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.UpdDate);
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.UpdUserId);
}
else if (strAttributeName  ==  convQxRelaOfPotenceAndSymbol.SymbolNum)
{
mintSymbolNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.SymbolNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxRelaOfPotenceAndSymbol.RelaMid  ==  AttributeName[intIndex])
{
return mlngRelaMid;
}
else if (convQxRelaOfPotenceAndSymbol.PotenceTypeName  ==  AttributeName[intIndex])
{
return mstrPotenceTypeName;
}
else if (convQxRelaOfPotenceAndSymbol.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxRelaOfPotenceAndSymbol.PotenceId  ==  AttributeName[intIndex])
{
return mstrPotenceId;
}
else if (convQxRelaOfPotenceAndSymbol.PotenceName  ==  AttributeName[intIndex])
{
return mstrPotenceName;
}
else if (convQxRelaOfPotenceAndSymbol.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxRelaOfPotenceAndSymbol.SymbolForProgramme  ==  AttributeName[intIndex])
{
return mstrSymbolForProgramme;
}
else if (convQxRelaOfPotenceAndSymbol.SymbolName  ==  AttributeName[intIndex])
{
return mstrSymbolName;
}
else if (convQxRelaOfPotenceAndSymbol.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convQxRelaOfPotenceAndSymbol.PotenceTypeId  ==  AttributeName[intIndex])
{
return mstrPotenceTypeId;
}
else if (convQxRelaOfPotenceAndSymbol.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxRelaOfPotenceAndSymbol.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convQxRelaOfPotenceAndSymbol.SymbolNum  ==  AttributeName[intIndex])
{
return mintSymbolNum;
}
return null;
}
set
{
if (convQxRelaOfPotenceAndSymbol.RelaMid  ==  AttributeName[intIndex])
{
mlngRelaMid = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.RelaMid);
}
else if (convQxRelaOfPotenceAndSymbol.PotenceTypeName  ==  AttributeName[intIndex])
{
mstrPotenceTypeName = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.PotenceTypeName);
}
else if (convQxRelaOfPotenceAndSymbol.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.QxPrjId);
}
else if (convQxRelaOfPotenceAndSymbol.PotenceId  ==  AttributeName[intIndex])
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.PotenceId);
}
else if (convQxRelaOfPotenceAndSymbol.PotenceName  ==  AttributeName[intIndex])
{
mstrPotenceName = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.PotenceName);
}
else if (convQxRelaOfPotenceAndSymbol.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.PrjName);
}
else if (convQxRelaOfPotenceAndSymbol.SymbolForProgramme  ==  AttributeName[intIndex])
{
mstrSymbolForProgramme = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.SymbolForProgramme);
}
else if (convQxRelaOfPotenceAndSymbol.SymbolName  ==  AttributeName[intIndex])
{
mstrSymbolName = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.SymbolName);
}
else if (convQxRelaOfPotenceAndSymbol.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.Memo);
}
else if (convQxRelaOfPotenceAndSymbol.PotenceTypeId  ==  AttributeName[intIndex])
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.PotenceTypeId);
}
else if (convQxRelaOfPotenceAndSymbol.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.UpdDate);
}
else if (convQxRelaOfPotenceAndSymbol.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.UpdUserId);
}
else if (convQxRelaOfPotenceAndSymbol.SymbolNum  ==  AttributeName[intIndex])
{
mintSymbolNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.SymbolNum);
}
}
}

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long RelaMid
{
get
{
return mlngRelaMid;
}
set
{
 mlngRelaMid = value;
//记录修改过的字段
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.RelaMid);
}
}
/// <summary>
/// 权限类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PotenceTypeName
{
get
{
return mstrPotenceTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPotenceTypeName = value;
}
else
{
 mstrPotenceTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.PotenceTypeName);
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
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.QxPrjId);
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
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.PotenceId);
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
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.PotenceName);
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
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.PrjName);
}
}
/// <summary>
/// 编程标志(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SymbolForProgramme
{
get
{
return mstrSymbolForProgramme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSymbolForProgramme = value;
}
else
{
 mstrSymbolForProgramme = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.SymbolForProgramme);
}
}
/// <summary>
/// 标志名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SymbolName
{
get
{
return mstrSymbolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSymbolName = value;
}
else
{
 mstrSymbolName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.SymbolName);
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
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.Memo);
}
}
/// <summary>
/// 权限类型Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PotenceTypeId
{
get
{
return mstrPotenceTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPotenceTypeId = value;
}
else
{
 mstrPotenceTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.PotenceTypeId);
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
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.UpdUserId);
}
}
/// <summary>
/// 标志数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SymbolNum
{
get
{
return mintSymbolNum;
}
set
{
 mintSymbolNum = value;
//记录修改过的字段
 AddUpdatedFld(convQxRelaOfPotenceAndSymbol.SymbolNum);
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
  return mlngRelaMid.ToString();
 }
 }
}
 /// <summary>
 /// v权限编程标志关系(vQxRelaOfPotenceAndSymbol)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxRelaOfPotenceAndSymbol
{
public const string _CurrTabName = "vQxRelaOfPotenceAndSymbol"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RelaMid"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RelaMid", "PotenceTypeName", "QxPrjId", "PotenceId", "PotenceName", "PrjName", "SymbolForProgramme", "SymbolName", "Memo", "PotenceTypeId", "UpdDate", "UpdUserId", "SymbolNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"RelaMid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaMid = "RelaMid";    //流水号

 /// <summary>
 /// 常量:"PotenceTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PotenceTypeName = "PotenceTypeName";    //权限类型名

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
 /// 常量:"SymbolForProgramme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SymbolForProgramme = "SymbolForProgramme";    //编程标志

 /// <summary>
 /// 常量:"SymbolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SymbolName = "SymbolName";    //标志名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"PotenceTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PotenceTypeId = "PotenceTypeId";    //权限类型Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"SymbolNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SymbolNum = "SymbolNum";    //标志数
}

}