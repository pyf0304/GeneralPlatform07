
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRelaOfPotenceAndSymbolEN
 表名:QxRelaOfPotenceAndSymbol(00140020)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 10:00:02
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理
 模块英文名:PotenceMan
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace GeneralPlatform.Entity
{
 /// <summary>
 /// 表QxRelaOfPotenceAndSymbol的关键字(RelaMid)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_RelaMid_QxRelaOfPotenceAndSymbol
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngRelaMid">表关键字</param>
public K_RelaMid_QxRelaOfPotenceAndSymbol(long lngRelaMid)
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RelaMid_QxRelaOfPotenceAndSymbol]类型的对象</returns>
public static implicit operator K_RelaMid_QxRelaOfPotenceAndSymbol(long value)
{
return new K_RelaMid_QxRelaOfPotenceAndSymbol(value);
}
}
 /// <summary>
 /// 权限编程标志关系表(QxRelaOfPotenceAndSymbol)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxRelaOfPotenceAndSymbolEN : clsEntityBase2
{
public const string _CurrTabName_S = "QxRelaOfPotenceAndSymbol"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RelaMid"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"RelaMid", "PotenceId", "SymbolForProgramme", "SymbolName", "Memo", "QxPrjId", "UpdDate", "UpdUserId"};
//以下是属性变量

protected long mlngRelaMid;    //流水号
protected string mstrPotenceId;    //权限ID
protected string mstrSymbolForProgramme;    //编程标志
protected string mstrSymbolName;    //标志名称
protected string mstrMemo;    //备注
protected string mstrQxPrjId;    //项目Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id


 /// <summary>
 /// 常量:"RelaMid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RelaMid = "RelaMid";    //流水号

 /// <summary>
 /// 常量:"PotenceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PotenceId = "PotenceId";    //权限ID

 /// <summary>
 /// 常量:"SymbolForProgramme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SymbolForProgramme = "SymbolForProgramme";    //编程标志

 /// <summary>
 /// 常量:"SymbolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SymbolName = "SymbolName";    //标志名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUserId = "UpdUserId";    //修改用户Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxRelaOfPotenceAndSymbolEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxRelaOfPotenceAndSymbol";
 lstKeyFldNames.Add("RelaMid");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngRelaMid">关键字:流水号</param>
public clsQxRelaOfPotenceAndSymbolEN(long lngRelaMid)
 {
 if (lngRelaMid  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngRelaMid = lngRelaMid;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxRelaOfPotenceAndSymbol";
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
if (strAttributeName  ==  con_RelaMid)
{
return mlngRelaMid;
}
else if (strAttributeName  ==  con_PotenceId)
{
return mstrPotenceId;
}
else if (strAttributeName  ==  con_SymbolForProgramme)
{
return mstrSymbolForProgramme;
}
else if (strAttributeName  ==  con_SymbolName)
{
return mstrSymbolName;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  con_QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_UpdUserId)
{
return mstrUpdUserId;
}
return null;
}
set
{
if (strAttributeName  ==  con_RelaMid)
{
mlngRelaMid = TransNullToInt(value.ToString());
 AddUpdatedFld(con_RelaMid);
}
else if (strAttributeName  ==  con_PotenceId)
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(con_PotenceId);
}
else if (strAttributeName  ==  con_SymbolForProgramme)
{
mstrSymbolForProgramme = value.ToString();
 AddUpdatedFld(con_SymbolForProgramme);
}
else if (strAttributeName  ==  con_SymbolName)
{
mstrSymbolName = value.ToString();
 AddUpdatedFld(con_SymbolName);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName  ==  con_QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(con_QxPrjId);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (con_RelaMid  ==  AttributeName[intIndex])
{
return mlngRelaMid;
}
else if (con_PotenceId  ==  AttributeName[intIndex])
{
return mstrPotenceId;
}
else if (con_SymbolForProgramme  ==  AttributeName[intIndex])
{
return mstrSymbolForProgramme;
}
else if (con_SymbolName  ==  AttributeName[intIndex])
{
return mstrSymbolName;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (con_QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
return null;
}
set
{
if (con_RelaMid  ==  AttributeName[intIndex])
{
mlngRelaMid = TransNullToInt(value.ToString());
 AddUpdatedFld(con_RelaMid);
}
else if (con_PotenceId  ==  AttributeName[intIndex])
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(con_PotenceId);
}
else if (con_SymbolForProgramme  ==  AttributeName[intIndex])
{
mstrSymbolForProgramme = value.ToString();
 AddUpdatedFld(con_SymbolForProgramme);
}
else if (con_SymbolName  ==  AttributeName[intIndex])
{
mstrSymbolName = value.ToString();
 AddUpdatedFld(con_SymbolName);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(con_QxPrjId);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
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
 AddUpdatedFld(con_RelaMid);
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
 AddUpdatedFld(con_PotenceId);
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
 AddUpdatedFld(con_SymbolForProgramme);
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
 AddUpdatedFld(con_SymbolName);
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
 AddUpdatedFld(con_Memo);
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
 AddUpdatedFld(con_QxPrjId);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
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
 AddUpdatedFld(con_UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
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
 AddUpdatedFld(con_UpdUserId);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
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
}