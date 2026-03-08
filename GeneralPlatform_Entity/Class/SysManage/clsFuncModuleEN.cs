
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncModuleEN
 表名:FuncModule(00140104)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:26:03
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:系统管理(SysManage)
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
 /// 表FuncModule的关键字(FuncModuleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncModuleId_FuncModule
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncModuleId">表关键字</param>
public K_FuncModuleId_FuncModule(string strFuncModuleId)
{
if (IsValid(strFuncModuleId)) Value = strFuncModuleId;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncModuleId)
{
if (string.IsNullOrEmpty(strFuncModuleId) == true) return false;
if (strFuncModuleId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncModuleId_FuncModule]类型的对象</returns>
public static implicit operator K_FuncModuleId_FuncModule(string value)
{
return new K_FuncModuleId_FuncModule(value);
}
}
 /// <summary>
 /// 功能模块(FuncModule)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsFuncModuleEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "FuncModule"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncModuleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "FuncModuleEnName", "OrderNum", "PrjId", "UseStateId", "UpdDate", "UpdUser", "Memo"};

protected string mstrFuncModuleId;    //模块Id
protected string mstrFuncModuleName;    //模块名
protected string mstrFuncModuleNameSim;    //模块名_Sim
protected string mstrFuncModuleEnName;    //模块英文名
protected int mintOrderNum;    //排序号
protected string mstrPrjId;    //工程ID
protected string mstrUseStateId;    //UseStateId
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsFuncModuleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncModuleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncModuleId">关键字:模块Id</param>
public clsFuncModuleEN(string strFuncModuleId)
 {
strFuncModuleId = strFuncModuleId.Replace("'", "''");
if (strFuncModuleId.Length > 4)
{
throw new Exception("在表:FuncModule中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncModuleId)  ==  true)
{
throw new Exception("在表:FuncModule中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncModuleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncModuleId = strFuncModuleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncModuleId");
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
if (strAttributeName  ==  conFuncModule.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conFuncModule.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  conFuncModule.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  conFuncModule.FuncModuleEnName)
{
return mstrFuncModuleEnName;
}
else if (strAttributeName  ==  conFuncModule.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conFuncModule.PrjId)
{
return mstrPrjId;
}
else if (strAttributeName  ==  conFuncModule.UseStateId)
{
return mstrUseStateId;
}
else if (strAttributeName  ==  conFuncModule.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conFuncModule.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conFuncModule.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conFuncModule.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conFuncModule.FuncModuleId);
}
else if (strAttributeName  ==  conFuncModule.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(conFuncModule.FuncModuleName);
}
else if (strAttributeName  ==  conFuncModule.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(conFuncModule.FuncModuleNameSim);
}
else if (strAttributeName  ==  conFuncModule.FuncModuleEnName)
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(conFuncModule.FuncModuleEnName);
}
else if (strAttributeName  ==  conFuncModule.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFuncModule.OrderNum);
}
else if (strAttributeName  ==  conFuncModule.PrjId)
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFuncModule.PrjId);
}
else if (strAttributeName  ==  conFuncModule.UseStateId)
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(conFuncModule.UseStateId);
}
else if (strAttributeName  ==  conFuncModule.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFuncModule.UpdDate);
}
else if (strAttributeName  ==  conFuncModule.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFuncModule.UpdUser);
}
else if (strAttributeName  ==  conFuncModule.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFuncModule.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conFuncModule.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conFuncModule.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (conFuncModule.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (conFuncModule.FuncModuleEnName  ==  AttributeName[intIndex])
{
return mstrFuncModuleEnName;
}
else if (conFuncModule.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conFuncModule.PrjId  ==  AttributeName[intIndex])
{
return mstrPrjId;
}
else if (conFuncModule.UseStateId  ==  AttributeName[intIndex])
{
return mstrUseStateId;
}
else if (conFuncModule.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conFuncModule.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conFuncModule.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conFuncModule.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conFuncModule.FuncModuleId);
}
else if (conFuncModule.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(conFuncModule.FuncModuleName);
}
else if (conFuncModule.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(conFuncModule.FuncModuleNameSim);
}
else if (conFuncModule.FuncModuleEnName  ==  AttributeName[intIndex])
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(conFuncModule.FuncModuleEnName);
}
else if (conFuncModule.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conFuncModule.OrderNum);
}
else if (conFuncModule.PrjId  ==  AttributeName[intIndex])
{
mstrPrjId = value.ToString();
 AddUpdatedFld(conFuncModule.PrjId);
}
else if (conFuncModule.UseStateId  ==  AttributeName[intIndex])
{
mstrUseStateId = value.ToString();
 AddUpdatedFld(conFuncModule.UseStateId);
}
else if (conFuncModule.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conFuncModule.UpdDate);
}
else if (conFuncModule.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conFuncModule.UpdUser);
}
else if (conFuncModule.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conFuncModule.Memo);
}
}
}

/// <summary>
/// 模块Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncModule.FuncModuleId);
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
 AddUpdatedFld(conFuncModule.FuncModuleName);
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
 AddUpdatedFld(conFuncModule.FuncModuleNameSim);
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
 AddUpdatedFld(conFuncModule.FuncModuleEnName);
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
 AddUpdatedFld(conFuncModule.OrderNum);
}
}
/// <summary>
/// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjId
{
get
{
return mstrPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjId = value;
}
else
{
 mstrPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(conFuncModule.PrjId);
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
 AddUpdatedFld(conFuncModule.UseStateId);
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
 AddUpdatedFld(conFuncModule.UpdDate);
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
 AddUpdatedFld(conFuncModule.UpdUser);
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
 AddUpdatedFld(conFuncModule.Memo);
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
  return mstrFuncModuleId;
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
 /// 功能模块(FuncModule)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conFuncModule
{
public const string _CurrTabName = "FuncModule"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncModuleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "FuncModuleEnName", "OrderNum", "PrjId", "UseStateId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //模块名

 /// <summary>
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //模块名_Sim

 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleEnName = "FuncModuleEnName";    //模块英文名

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"PrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjId = "PrjId";    //工程ID

 /// <summary>
 /// 常量:"UseStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UseStateId = "UseStateId";    //UseStateId

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