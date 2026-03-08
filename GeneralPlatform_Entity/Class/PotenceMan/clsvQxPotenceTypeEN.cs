
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPotenceTypeEN
 表名:vQxPotenceType(00140026)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:32:41
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
 /// 表vQxPotenceType的关键字(PotenceTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PotenceTypeId_vQxPotenceType
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPotenceTypeId">表关键字</param>
public K_PotenceTypeId_vQxPotenceType(string strPotenceTypeId)
{
if (IsValid(strPotenceTypeId)) Value = strPotenceTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strPotenceTypeId)
{
if (string.IsNullOrEmpty(strPotenceTypeId) == true) return false;
if (strPotenceTypeId.Length != 6) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PotenceTypeId_vQxPotenceType]类型的对象</returns>
public static implicit operator K_PotenceTypeId_vQxPotenceType(string value)
{
return new K_PotenceTypeId_vQxPotenceType(value);
}
}
 /// <summary>
 /// v权限类型(vQxPotenceType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxPotenceTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxPotenceType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PotenceTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"PotenceTypeId", "PotenceTypeName", "QxPrjId", "PrjName", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "OrderNum", "InUse", "ViewId", "ViewName", "IsVisible", "UpdDate", "UpdUserId", "Memo"};

protected string mstrPotenceTypeId;    //权限类型Id
protected string mstrPotenceTypeName;    //权限类型名
protected string mstrQxPrjId;    //项目Id
protected string mstrPrjName;    //工程名
protected string mstrFuncModuleId;    //模块Id
protected string mstrFuncModuleName;    //模块名
protected string mstrFuncModuleNameSim;    //模块名_Sim
protected int? mintOrderNum;    //排序号
protected bool mbolInUse;    //是否在用
protected string mstrViewId;    //界面编号
protected string mstrViewName;    //界面名称
protected bool mbolIsVisible;    //是否显示
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxPotenceTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PotenceTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPotenceTypeId">关键字:权限类型Id</param>
public clsvQxPotenceTypeEN(string strPotenceTypeId)
 {
strPotenceTypeId = strPotenceTypeId.Replace("'", "''");
if (strPotenceTypeId.Length > 6)
{
throw new Exception("在表:vQxPotenceType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPotenceTypeId)  ==  true)
{
throw new Exception("在表:vQxPotenceType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPotenceTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPotenceTypeId = strPotenceTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PotenceTypeId");
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
if (strAttributeName  ==  convQxPotenceType.PotenceTypeId)
{
return mstrPotenceTypeId;
}
else if (strAttributeName  ==  convQxPotenceType.PotenceTypeName)
{
return mstrPotenceTypeName;
}
else if (strAttributeName  ==  convQxPotenceType.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxPotenceType.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxPotenceType.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convQxPotenceType.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convQxPotenceType.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convQxPotenceType.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convQxPotenceType.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convQxPotenceType.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  convQxPotenceType.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  convQxPotenceType.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convQxPotenceType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxPotenceType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convQxPotenceType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxPotenceType.PotenceTypeId)
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(convQxPotenceType.PotenceTypeId);
}
else if (strAttributeName  ==  convQxPotenceType.PotenceTypeName)
{
mstrPotenceTypeName = value.ToString();
 AddUpdatedFld(convQxPotenceType.PotenceTypeName);
}
else if (strAttributeName  ==  convQxPotenceType.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPotenceType.QxPrjId);
}
else if (strAttributeName  ==  convQxPotenceType.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPotenceType.PrjName);
}
else if (strAttributeName  ==  convQxPotenceType.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convQxPotenceType.FuncModuleId);
}
else if (strAttributeName  ==  convQxPotenceType.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQxPotenceType.FuncModuleName);
}
else if (strAttributeName  ==  convQxPotenceType.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convQxPotenceType.FuncModuleNameSim);
}
else if (strAttributeName  ==  convQxPotenceType.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPotenceType.OrderNum);
}
else if (strAttributeName  ==  convQxPotenceType.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPotenceType.InUse);
}
else if (strAttributeName  ==  convQxPotenceType.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(convQxPotenceType.ViewId);
}
else if (strAttributeName  ==  convQxPotenceType.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(convQxPotenceType.ViewName);
}
else if (strAttributeName  ==  convQxPotenceType.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPotenceType.IsVisible);
}
else if (strAttributeName  ==  convQxPotenceType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxPotenceType.UpdDate);
}
else if (strAttributeName  ==  convQxPotenceType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxPotenceType.UpdUserId);
}
else if (strAttributeName  ==  convQxPotenceType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPotenceType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxPotenceType.PotenceTypeId  ==  AttributeName[intIndex])
{
return mstrPotenceTypeId;
}
else if (convQxPotenceType.PotenceTypeName  ==  AttributeName[intIndex])
{
return mstrPotenceTypeName;
}
else if (convQxPotenceType.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxPotenceType.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxPotenceType.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convQxPotenceType.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convQxPotenceType.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convQxPotenceType.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convQxPotenceType.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convQxPotenceType.ViewId  ==  AttributeName[intIndex])
{
return mstrViewId;
}
else if (convQxPotenceType.ViewName  ==  AttributeName[intIndex])
{
return mstrViewName;
}
else if (convQxPotenceType.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convQxPotenceType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxPotenceType.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convQxPotenceType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxPotenceType.PotenceTypeId  ==  AttributeName[intIndex])
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(convQxPotenceType.PotenceTypeId);
}
else if (convQxPotenceType.PotenceTypeName  ==  AttributeName[intIndex])
{
mstrPotenceTypeName = value.ToString();
 AddUpdatedFld(convQxPotenceType.PotenceTypeName);
}
else if (convQxPotenceType.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPotenceType.QxPrjId);
}
else if (convQxPotenceType.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPotenceType.PrjName);
}
else if (convQxPotenceType.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convQxPotenceType.FuncModuleId);
}
else if (convQxPotenceType.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQxPotenceType.FuncModuleName);
}
else if (convQxPotenceType.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convQxPotenceType.FuncModuleNameSim);
}
else if (convQxPotenceType.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPotenceType.OrderNum);
}
else if (convQxPotenceType.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPotenceType.InUse);
}
else if (convQxPotenceType.ViewId  ==  AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(convQxPotenceType.ViewId);
}
else if (convQxPotenceType.ViewName  ==  AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(convQxPotenceType.ViewName);
}
else if (convQxPotenceType.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPotenceType.IsVisible);
}
else if (convQxPotenceType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxPotenceType.UpdDate);
}
else if (convQxPotenceType.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxPotenceType.UpdUserId);
}
else if (convQxPotenceType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPotenceType.Memo);
}
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
 AddUpdatedFld(convQxPotenceType.PotenceTypeId);
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
 AddUpdatedFld(convQxPotenceType.PotenceTypeName);
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
 AddUpdatedFld(convQxPotenceType.QxPrjId);
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
 AddUpdatedFld(convQxPotenceType.PrjName);
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
 AddUpdatedFld(convQxPotenceType.FuncModuleId);
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
 AddUpdatedFld(convQxPotenceType.FuncModuleName);
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
 AddUpdatedFld(convQxPotenceType.FuncModuleNameSim);
}
}
/// <summary>
/// 排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convQxPotenceType.OrderNum);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(convQxPotenceType.InUse);
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
 AddUpdatedFld(convQxPotenceType.ViewId);
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
 AddUpdatedFld(convQxPotenceType.ViewName);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsVisible
{
get
{
return mbolIsVisible;
}
set
{
 mbolIsVisible = value;
//记录修改过的字段
 AddUpdatedFld(convQxPotenceType.IsVisible);
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
 AddUpdatedFld(convQxPotenceType.UpdDate);
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
 AddUpdatedFld(convQxPotenceType.UpdUserId);
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
 AddUpdatedFld(convQxPotenceType.Memo);
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
  return mstrPotenceTypeId;
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
  return mstrPotenceTypeName;
 }
 }
}
 /// <summary>
 /// v权限类型(vQxPotenceType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxPotenceType
{
public const string _CurrTabName = "vQxPotenceType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PotenceTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PotenceTypeId", "PotenceTypeName", "QxPrjId", "PrjName", "FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "OrderNum", "InUse", "ViewId", "ViewName", "IsVisible", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PotenceTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PotenceTypeId = "PotenceTypeId";    //权限类型Id

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
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名

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
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

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
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}