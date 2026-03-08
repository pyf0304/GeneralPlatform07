
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxFuncModule_AgcEN
 表名:QxFuncModule_Agc(00140101)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:28:02
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
 /// 表QxFuncModule_Agc的关键字(FuncModuleAgcId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncModuleAgcId_QxFuncModule_Agc
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncModuleAgcId">表关键字</param>
public K_FuncModuleAgcId_QxFuncModule_Agc(string strFuncModuleAgcId)
{
if (IsValid(strFuncModuleAgcId)) Value = strFuncModuleAgcId;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncModuleAgcId)
{
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true) return false;
if (strFuncModuleAgcId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncModuleAgcId_QxFuncModule_Agc]类型的对象</returns>
public static implicit operator K_FuncModuleAgcId_QxFuncModule_Agc(string value)
{
return new K_FuncModuleAgcId_QxFuncModule_Agc(value);
}
}
 /// <summary>
 /// 功能模块_Agc(QxFuncModule_Agc)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxFuncModule_AgcEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxFuncModule_Agc"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncModuleAgcId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "FuncModuleNameSim", "QxPrjId", "OrderNum", "UseStateId", "UpdUser", "UpdDate", "Memo", "SynchDate"};

protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //模块名
protected string mstrFuncModuleEnName;    //模块英文名
protected string mstrFuncModuleNameSim;    //模块名_Sim
protected string mstrQxPrjId;    //项目Id
protected int mintOrderNum;    //排序号
protected string mstrUseStateId;    //UseStateId
protected string mstrUpdUser;    //修改用户
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrSynchDate;    //同步日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxFuncModule_AgcEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncModuleAgcId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncModuleAgcId">关键字:功能模块Id</param>
public clsQxFuncModule_AgcEN(string strFuncModuleAgcId)
 {
strFuncModuleAgcId = strFuncModuleAgcId.Replace("'", "''");
if (strFuncModuleAgcId.Length > 8)
{
throw new Exception("在表:QxFuncModule_Agc中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncModuleAgcId)  ==  true)
{
throw new Exception("在表:QxFuncModule_Agc中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncModuleAgcId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncModuleAgcId = strFuncModuleAgcId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncModuleAgcId");
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
if (strAttributeName  ==  conQxFuncModule_Agc.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  conQxFuncModule_Agc.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  conQxFuncModule_Agc.FuncModuleEnName)
{
return mstrFuncModuleEnName;
}
else if (strAttributeName  ==  conQxFuncModule_Agc.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  conQxFuncModule_Agc.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxFuncModule_Agc.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conQxFuncModule_Agc.UseStateId)
{
return mstrUseStateId;
}
else if (strAttributeName  ==  conQxFuncModule_Agc.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQxFuncModule_Agc.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxFuncModule_Agc.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conQxFuncModule_Agc.SynchDate)
{
return mstrSynchDate;
}
return null;
}
set
{
if (strAttributeName  ==  conQxFuncModule_Agc.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.FuncModuleAgcId);
}
else if (strAttributeName  ==  conQxFuncModule_Agc.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.FuncModuleName);
}
else if (strAttributeName  ==  conQxFuncModule_Agc.FuncModuleEnName)
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.FuncModuleEnName);
}
else if (strAttributeName  ==  conQxFuncModule_Agc.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.FuncModuleNameSim);
}
else if (strAttributeName  ==  conQxFuncModule_Agc.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.QxPrjId);
}
else if (strAttributeName  ==  conQxFuncModule_Agc.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxFuncModule_Agc.OrderNum);
}
else if (strAttributeName  ==  conQxFuncModule_Agc.UseStateId)
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.UseStateId);
}
else if (strAttributeName  ==  conQxFuncModule_Agc.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.UpdUser);
}
else if (strAttributeName  ==  conQxFuncModule_Agc.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.UpdDate);
}
else if (strAttributeName  ==  conQxFuncModule_Agc.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.Memo);
}
else if (strAttributeName  ==  conQxFuncModule_Agc.SynchDate)
{
mstrSynchDate = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.SynchDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxFuncModule_Agc.FuncModuleAgcId  ==  AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (conQxFuncModule_Agc.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (conQxFuncModule_Agc.FuncModuleEnName  ==  AttributeName[intIndex])
{
return mstrFuncModuleEnName;
}
else if (conQxFuncModule_Agc.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (conQxFuncModule_Agc.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxFuncModule_Agc.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conQxFuncModule_Agc.UseStateId  ==  AttributeName[intIndex])
{
return mstrUseStateId;
}
else if (conQxFuncModule_Agc.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQxFuncModule_Agc.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxFuncModule_Agc.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conQxFuncModule_Agc.SynchDate  ==  AttributeName[intIndex])
{
return mstrSynchDate;
}
return null;
}
set
{
if (conQxFuncModule_Agc.FuncModuleAgcId  ==  AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.FuncModuleAgcId);
}
else if (conQxFuncModule_Agc.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.FuncModuleName);
}
else if (conQxFuncModule_Agc.FuncModuleEnName  ==  AttributeName[intIndex])
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.FuncModuleEnName);
}
else if (conQxFuncModule_Agc.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.FuncModuleNameSim);
}
else if (conQxFuncModule_Agc.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.QxPrjId);
}
else if (conQxFuncModule_Agc.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxFuncModule_Agc.OrderNum);
}
else if (conQxFuncModule_Agc.UseStateId  ==  AttributeName[intIndex])
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.UseStateId);
}
else if (conQxFuncModule_Agc.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.UpdUser);
}
else if (conQxFuncModule_Agc.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.UpdDate);
}
else if (conQxFuncModule_Agc.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.Memo);
}
else if (conQxFuncModule_Agc.SynchDate  ==  AttributeName[intIndex])
{
mstrSynchDate = value.ToString();
 AddUpdatedFld(conQxFuncModule_Agc.SynchDate);
}
}
}

/// <summary>
/// 功能模块Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleAgcId
{
get
{
return mstrFuncModuleAgcId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleAgcId = value;
}
else
{
 mstrFuncModuleAgcId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxFuncModule_Agc.FuncModuleAgcId);
}
}
/// <summary>
/// 模块名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxFuncModule_Agc.FuncModuleName);
}
}
/// <summary>
/// 模块英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleEnName
{
get
{
return mstrFuncModuleEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleEnName = value;
}
else
{
 mstrFuncModuleEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxFuncModule_Agc.FuncModuleEnName);
}
}
/// <summary>
/// 模块名_Sim(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleNameSim
{
get
{
return mstrFuncModuleNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleNameSim = value;
}
else
{
 mstrFuncModuleNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxFuncModule_Agc.FuncModuleNameSim);
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
 AddUpdatedFld(conQxFuncModule_Agc.QxPrjId);
}
}
/// <summary>
/// 排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conQxFuncModule_Agc.OrderNum);
}
}
/// <summary>
/// UseStateId(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UseStateId
{
get
{
return mstrUseStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUseStateId = value;
}
else
{
 mstrUseStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxFuncModule_Agc.UseStateId);
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
 AddUpdatedFld(conQxFuncModule_Agc.UpdUser);
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
 AddUpdatedFld(conQxFuncModule_Agc.UpdDate);
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
 AddUpdatedFld(conQxFuncModule_Agc.Memo);
}
}
/// <summary>
/// 同步日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SynchDate
{
get
{
return mstrSynchDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchDate = value;
}
else
{
 mstrSynchDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxFuncModule_Agc.SynchDate);
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
  return mstrFuncModuleAgcId;
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
  return mstrFuncModuleName;
 }
 }
}
 /// <summary>
 /// 功能模块_Agc(QxFuncModule_Agc)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxFuncModule_Agc
{
public const string _CurrTabName = "QxFuncModule_Agc"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncModuleAgcId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "FuncModuleNameSim", "QxPrjId", "OrderNum", "UseStateId", "UpdUser", "UpdDate", "Memo", "SynchDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //模块名

 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleEnName = "FuncModuleEnName";    //模块英文名

 /// <summary>
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //模块名_Sim

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"UseStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseStateId = "UseStateId";    //UseStateId

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改用户

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"SynchDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SynchDate = "SynchDate";    //同步日期
}

}