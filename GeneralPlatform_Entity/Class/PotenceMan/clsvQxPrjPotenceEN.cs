
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjPotenceEN
 表名:vQxPrjPotence(00140027)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:34:34
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
 /// 表vQxPrjPotence的关键字(PotenceId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PotenceId_vQxPrjPotence
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPotenceId">表关键字</param>
public K_PotenceId_vQxPrjPotence(string strPotenceId)
{
if (IsValid(strPotenceId)) Value = strPotenceId;
else
{
Value = null;
}
}
private static bool IsValid(string strPotenceId)
{
if (string.IsNullOrEmpty(strPotenceId) == true) return false;
if (strPotenceId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PotenceId_vQxPrjPotence]类型的对象</returns>
public static implicit operator K_PotenceId_vQxPrjPotence(string value)
{
return new K_PotenceId_vQxPrjPotence(value);
}
}
 /// <summary>
 /// v工程权限(vQxPrjPotence)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxPrjPotenceEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxPrjPotence"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PotenceId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"PotenceId", "PotenceName", "QxPrjId", "PrjName", "FuncModuleId", "PotenceTypeId", "PotenceTypeName", "FuncModuleName", "FuncModuleNameSim", "InUse", "IsVisible", "MenuId", "MenuName", "UpMenuId", "IsLeafNode", "UpMenuName", "UpdDate", "UpdUserId", "Memo", "SymbolNum"};

protected string mstrPotenceId;    //权限ID
protected string mstrPotenceName;    //权限名称
protected string mstrQxPrjId;    //项目Id
protected string mstrPrjName;    //工程名
protected string mstrFuncModuleId;    //模块Id
protected string mstrPotenceTypeId;    //权限类型Id
protected string mstrPotenceTypeName;    //权限类型名
protected string mstrFuncModuleName;    //模块名
protected string mstrFuncModuleNameSim;    //模块名_Sim
protected bool mbolInUse;    //是否在用
protected bool mbolIsVisible;    //是否显示
protected string mstrMenuId;    //菜单Id
protected string mstrMenuName;    //菜单名
protected string mstrUpMenuId;    //上级菜单Id
protected bool mbolIsLeafNode;    //是否叶子
protected string mstrUpMenuName;    //上级菜单名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected int? mintSymbolNum;    //标志数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxPrjPotenceEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PotenceId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPotenceId">关键字:权限ID</param>
public clsvQxPrjPotenceEN(string strPotenceId)
 {
strPotenceId = strPotenceId.Replace("'", "''");
if (strPotenceId.Length > 8)
{
throw new Exception("在表:vQxPrjPotence中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPotenceId)  ==  true)
{
throw new Exception("在表:vQxPrjPotence中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPotenceId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPotenceId = strPotenceId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PotenceId");
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
if (strAttributeName  ==  convQxPrjPotence.PotenceId)
{
return mstrPotenceId;
}
else if (strAttributeName  ==  convQxPrjPotence.PotenceName)
{
return mstrPotenceName;
}
else if (strAttributeName  ==  convQxPrjPotence.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxPrjPotence.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxPrjPotence.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  convQxPrjPotence.PotenceTypeId)
{
return mstrPotenceTypeId;
}
else if (strAttributeName  ==  convQxPrjPotence.PotenceTypeName)
{
return mstrPotenceTypeName;
}
else if (strAttributeName  ==  convQxPrjPotence.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convQxPrjPotence.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  convQxPrjPotence.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convQxPrjPotence.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convQxPrjPotence.MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  convQxPrjPotence.MenuName)
{
return mstrMenuName;
}
else if (strAttributeName  ==  convQxPrjPotence.UpMenuId)
{
return mstrUpMenuId;
}
else if (strAttributeName  ==  convQxPrjPotence.IsLeafNode)
{
return mbolIsLeafNode;
}
else if (strAttributeName  ==  convQxPrjPotence.UpMenuName)
{
return mstrUpMenuName;
}
else if (strAttributeName  ==  convQxPrjPotence.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxPrjPotence.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convQxPrjPotence.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convQxPrjPotence.SymbolNum)
{
return mintSymbolNum;
}
return null;
}
set
{
if (strAttributeName  ==  convQxPrjPotence.PotenceId)
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(convQxPrjPotence.PotenceId);
}
else if (strAttributeName  ==  convQxPrjPotence.PotenceName)
{
mstrPotenceName = value.ToString();
 AddUpdatedFld(convQxPrjPotence.PotenceName);
}
else if (strAttributeName  ==  convQxPrjPotence.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPrjPotence.QxPrjId);
}
else if (strAttributeName  ==  convQxPrjPotence.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPrjPotence.PrjName);
}
else if (strAttributeName  ==  convQxPrjPotence.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convQxPrjPotence.FuncModuleId);
}
else if (strAttributeName  ==  convQxPrjPotence.PotenceTypeId)
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(convQxPrjPotence.PotenceTypeId);
}
else if (strAttributeName  ==  convQxPrjPotence.PotenceTypeName)
{
mstrPotenceTypeName = value.ToString();
 AddUpdatedFld(convQxPrjPotence.PotenceTypeName);
}
else if (strAttributeName  ==  convQxPrjPotence.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQxPrjPotence.FuncModuleName);
}
else if (strAttributeName  ==  convQxPrjPotence.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convQxPrjPotence.FuncModuleNameSim);
}
else if (strAttributeName  ==  convQxPrjPotence.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjPotence.InUse);
}
else if (strAttributeName  ==  convQxPrjPotence.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjPotence.IsVisible);
}
else if (strAttributeName  ==  convQxPrjPotence.MenuId)
{
mstrMenuId = value.ToString();
 AddUpdatedFld(convQxPrjPotence.MenuId);
}
else if (strAttributeName  ==  convQxPrjPotence.MenuName)
{
mstrMenuName = value.ToString();
 AddUpdatedFld(convQxPrjPotence.MenuName);
}
else if (strAttributeName  ==  convQxPrjPotence.UpMenuId)
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(convQxPrjPotence.UpMenuId);
}
else if (strAttributeName  ==  convQxPrjPotence.IsLeafNode)
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjPotence.IsLeafNode);
}
else if (strAttributeName  ==  convQxPrjPotence.UpMenuName)
{
mstrUpMenuName = value.ToString();
 AddUpdatedFld(convQxPrjPotence.UpMenuName);
}
else if (strAttributeName  ==  convQxPrjPotence.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxPrjPotence.UpdDate);
}
else if (strAttributeName  ==  convQxPrjPotence.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxPrjPotence.UpdUserId);
}
else if (strAttributeName  ==  convQxPrjPotence.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPrjPotence.Memo);
}
else if (strAttributeName  ==  convQxPrjPotence.SymbolNum)
{
mintSymbolNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjPotence.SymbolNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxPrjPotence.PotenceId  ==  AttributeName[intIndex])
{
return mstrPotenceId;
}
else if (convQxPrjPotence.PotenceName  ==  AttributeName[intIndex])
{
return mstrPotenceName;
}
else if (convQxPrjPotence.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxPrjPotence.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxPrjPotence.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (convQxPrjPotence.PotenceTypeId  ==  AttributeName[intIndex])
{
return mstrPotenceTypeId;
}
else if (convQxPrjPotence.PotenceTypeName  ==  AttributeName[intIndex])
{
return mstrPotenceTypeName;
}
else if (convQxPrjPotence.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convQxPrjPotence.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (convQxPrjPotence.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convQxPrjPotence.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convQxPrjPotence.MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (convQxPrjPotence.MenuName  ==  AttributeName[intIndex])
{
return mstrMenuName;
}
else if (convQxPrjPotence.UpMenuId  ==  AttributeName[intIndex])
{
return mstrUpMenuId;
}
else if (convQxPrjPotence.IsLeafNode  ==  AttributeName[intIndex])
{
return mbolIsLeafNode;
}
else if (convQxPrjPotence.UpMenuName  ==  AttributeName[intIndex])
{
return mstrUpMenuName;
}
else if (convQxPrjPotence.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxPrjPotence.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convQxPrjPotence.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convQxPrjPotence.SymbolNum  ==  AttributeName[intIndex])
{
return mintSymbolNum;
}
return null;
}
set
{
if (convQxPrjPotence.PotenceId  ==  AttributeName[intIndex])
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(convQxPrjPotence.PotenceId);
}
else if (convQxPrjPotence.PotenceName  ==  AttributeName[intIndex])
{
mstrPotenceName = value.ToString();
 AddUpdatedFld(convQxPrjPotence.PotenceName);
}
else if (convQxPrjPotence.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPrjPotence.QxPrjId);
}
else if (convQxPrjPotence.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPrjPotence.PrjName);
}
else if (convQxPrjPotence.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(convQxPrjPotence.FuncModuleId);
}
else if (convQxPrjPotence.PotenceTypeId  ==  AttributeName[intIndex])
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(convQxPrjPotence.PotenceTypeId);
}
else if (convQxPrjPotence.PotenceTypeName  ==  AttributeName[intIndex])
{
mstrPotenceTypeName = value.ToString();
 AddUpdatedFld(convQxPrjPotence.PotenceTypeName);
}
else if (convQxPrjPotence.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQxPrjPotence.FuncModuleName);
}
else if (convQxPrjPotence.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(convQxPrjPotence.FuncModuleNameSim);
}
else if (convQxPrjPotence.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjPotence.InUse);
}
else if (convQxPrjPotence.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjPotence.IsVisible);
}
else if (convQxPrjPotence.MenuId  ==  AttributeName[intIndex])
{
mstrMenuId = value.ToString();
 AddUpdatedFld(convQxPrjPotence.MenuId);
}
else if (convQxPrjPotence.MenuName  ==  AttributeName[intIndex])
{
mstrMenuName = value.ToString();
 AddUpdatedFld(convQxPrjPotence.MenuName);
}
else if (convQxPrjPotence.UpMenuId  ==  AttributeName[intIndex])
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(convQxPrjPotence.UpMenuId);
}
else if (convQxPrjPotence.IsLeafNode  ==  AttributeName[intIndex])
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjPotence.IsLeafNode);
}
else if (convQxPrjPotence.UpMenuName  ==  AttributeName[intIndex])
{
mstrUpMenuName = value.ToString();
 AddUpdatedFld(convQxPrjPotence.UpMenuName);
}
else if (convQxPrjPotence.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxPrjPotence.UpdDate);
}
else if (convQxPrjPotence.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxPrjPotence.UpdUserId);
}
else if (convQxPrjPotence.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPrjPotence.Memo);
}
else if (convQxPrjPotence.SymbolNum  ==  AttributeName[intIndex])
{
mintSymbolNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjPotence.SymbolNum);
}
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
 AddUpdatedFld(convQxPrjPotence.PotenceId);
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
 AddUpdatedFld(convQxPrjPotence.PotenceName);
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
 AddUpdatedFld(convQxPrjPotence.QxPrjId);
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
 AddUpdatedFld(convQxPrjPotence.PrjName);
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
 AddUpdatedFld(convQxPrjPotence.FuncModuleId);
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
 AddUpdatedFld(convQxPrjPotence.PotenceTypeId);
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
 AddUpdatedFld(convQxPrjPotence.PotenceTypeName);
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
 AddUpdatedFld(convQxPrjPotence.FuncModuleName);
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
 AddUpdatedFld(convQxPrjPotence.FuncModuleNameSim);
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
 AddUpdatedFld(convQxPrjPotence.InUse);
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
 AddUpdatedFld(convQxPrjPotence.IsVisible);
}
}
/// <summary>
/// 菜单Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuId
{
get
{
return mstrMenuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuId = value;
}
else
{
 mstrMenuId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjPotence.MenuId);
}
}
/// <summary>
/// 菜单名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuName
{
get
{
return mstrMenuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuName = value;
}
else
{
 mstrMenuName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjPotence.MenuName);
}
}
/// <summary>
/// 上级菜单Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpMenuId
{
get
{
return mstrUpMenuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpMenuId = value;
}
else
{
 mstrUpMenuId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjPotence.UpMenuId);
}
}
/// <summary>
/// 是否叶子(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsLeafNode
{
get
{
return mbolIsLeafNode;
}
set
{
 mbolIsLeafNode = value;
//记录修改过的字段
 AddUpdatedFld(convQxPrjPotence.IsLeafNode);
}
}
/// <summary>
/// 上级菜单名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpMenuName
{
get
{
return mstrUpMenuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpMenuName = value;
}
else
{
 mstrUpMenuName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjPotence.UpMenuName);
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
 AddUpdatedFld(convQxPrjPotence.UpdDate);
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
 AddUpdatedFld(convQxPrjPotence.UpdUserId);
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
 AddUpdatedFld(convQxPrjPotence.Memo);
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
 AddUpdatedFld(convQxPrjPotence.SymbolNum);
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
  return mstrPotenceId;
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
  return mstrPotenceName;
 }
 }
}
 /// <summary>
 /// v工程权限(vQxPrjPotence)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxPrjPotence
{
public const string _CurrTabName = "vQxPrjPotence"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PotenceId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PotenceId", "PotenceName", "QxPrjId", "PrjName", "FuncModuleId", "PotenceTypeId", "PotenceTypeName", "FuncModuleName", "FuncModuleNameSim", "InUse", "IsVisible", "MenuId", "MenuName", "UpMenuId", "IsLeafNode", "UpMenuName", "UpdDate", "UpdUserId", "Memo", "SymbolNum"};
//以下是属性变量


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
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"MenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuId = "MenuId";    //菜单Id

 /// <summary>
 /// 常量:"MenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuName = "MenuName";    //菜单名

 /// <summary>
 /// 常量:"UpMenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpMenuId = "UpMenuId";    //上级菜单Id

 /// <summary>
 /// 常量:"IsLeafNode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsLeafNode = "IsLeafNode";    //是否叶子

 /// <summary>
 /// 常量:"UpMenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpMenuName = "UpMenuName";    //上级菜单名

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

 /// <summary>
 /// 常量:"SymbolNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SymbolNum = "SymbolNum";    //标志数
}

}