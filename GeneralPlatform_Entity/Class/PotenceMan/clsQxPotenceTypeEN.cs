
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPotenceTypeEN
 表名:QxPotenceType(00140003)
 * 版本:2024.03.19.1(服务器:WIN-SRV103-116)
 日期:2024/03/20 11:15:04
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
 /// 表QxPotenceType的关键字(PotenceTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PotenceTypeId_QxPotenceType
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
public K_PotenceTypeId_QxPotenceType(string strPotenceTypeId)
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
 /// <returns>返回:[K_PotenceTypeId_QxPotenceType]类型的对象</returns>
public static implicit operator K_PotenceTypeId_QxPotenceType(string value)
{
return new K_PotenceTypeId_QxPotenceType(value);
}
}
 /// <summary>
 /// 权限类型(QxPotenceType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxPotenceTypeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxPotenceType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PotenceTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"PotenceTypeId", "PotenceTypeName", "QxPrjId", "FuncModuleId", "MenuId", "ViewId", "IsVisible", "UpdDate", "UpdUserId", "Memo"};

protected string mstrPotenceTypeId;    //权限类型Id
protected string mstrPotenceTypeName;    //权限类型名
protected string mstrQxPrjId;    //项目Id
protected string mstrFuncModuleId;    //模块Id
protected string mstrMenuId;    //菜单Id
protected string mstrViewId;    //界面编号
protected bool mbolIsVisible;    //是否显示
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxPotenceTypeEN()
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
public clsQxPotenceTypeEN(string strPotenceTypeId)
 {
strPotenceTypeId = strPotenceTypeId.Replace("'", "''");
if (strPotenceTypeId.Length > 6)
{
throw new Exception("在表:QxPotenceType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPotenceTypeId)  ==  true)
{
throw new Exception("在表:QxPotenceType中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conQxPotenceType.PotenceTypeId)
{
return mstrPotenceTypeId;
}
else if (strAttributeName  ==  conQxPotenceType.PotenceTypeName)
{
return mstrPotenceTypeName;
}
else if (strAttributeName  ==  conQxPotenceType.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxPotenceType.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conQxPotenceType.MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  conQxPotenceType.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  conQxPotenceType.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conQxPotenceType.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxPotenceType.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conQxPotenceType.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxPotenceType.PotenceTypeId)
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(conQxPotenceType.PotenceTypeId);
}
else if (strAttributeName  ==  conQxPotenceType.PotenceTypeName)
{
mstrPotenceTypeName = value.ToString();
 AddUpdatedFld(conQxPotenceType.PotenceTypeName);
}
else if (strAttributeName  ==  conQxPotenceType.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPotenceType.QxPrjId);
}
else if (strAttributeName  ==  conQxPotenceType.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conQxPotenceType.FuncModuleId);
}
else if (strAttributeName  ==  conQxPotenceType.MenuId)
{
mstrMenuId = value.ToString();
 AddUpdatedFld(conQxPotenceType.MenuId);
}
else if (strAttributeName  ==  conQxPotenceType.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(conQxPotenceType.ViewId);
}
else if (strAttributeName  ==  conQxPotenceType.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPotenceType.IsVisible);
}
else if (strAttributeName  ==  conQxPotenceType.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPotenceType.UpdDate);
}
else if (strAttributeName  ==  conQxPotenceType.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPotenceType.UpdUserId);
}
else if (strAttributeName  ==  conQxPotenceType.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPotenceType.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxPotenceType.PotenceTypeId  ==  AttributeName[intIndex])
{
return mstrPotenceTypeId;
}
else if (conQxPotenceType.PotenceTypeName  ==  AttributeName[intIndex])
{
return mstrPotenceTypeName;
}
else if (conQxPotenceType.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxPotenceType.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conQxPotenceType.MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (conQxPotenceType.ViewId  ==  AttributeName[intIndex])
{
return mstrViewId;
}
else if (conQxPotenceType.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conQxPotenceType.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxPotenceType.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conQxPotenceType.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxPotenceType.PotenceTypeId  ==  AttributeName[intIndex])
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(conQxPotenceType.PotenceTypeId);
}
else if (conQxPotenceType.PotenceTypeName  ==  AttributeName[intIndex])
{
mstrPotenceTypeName = value.ToString();
 AddUpdatedFld(conQxPotenceType.PotenceTypeName);
}
else if (conQxPotenceType.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPotenceType.QxPrjId);
}
else if (conQxPotenceType.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conQxPotenceType.FuncModuleId);
}
else if (conQxPotenceType.MenuId  ==  AttributeName[intIndex])
{
mstrMenuId = value.ToString();
 AddUpdatedFld(conQxPotenceType.MenuId);
}
else if (conQxPotenceType.ViewId  ==  AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(conQxPotenceType.ViewId);
}
else if (conQxPotenceType.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPotenceType.IsVisible);
}
else if (conQxPotenceType.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPotenceType.UpdDate);
}
else if (conQxPotenceType.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPotenceType.UpdUserId);
}
else if (conQxPotenceType.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPotenceType.Memo);
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
 AddUpdatedFld(conQxPotenceType.PotenceTypeId);
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
 AddUpdatedFld(conQxPotenceType.PotenceTypeName);
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
 AddUpdatedFld(conQxPotenceType.QxPrjId);
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
 AddUpdatedFld(conQxPotenceType.FuncModuleId);
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
 AddUpdatedFld(conQxPotenceType.MenuId);
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
 AddUpdatedFld(conQxPotenceType.ViewId);
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
 AddUpdatedFld(conQxPotenceType.IsVisible);
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
 AddUpdatedFld(conQxPotenceType.UpdDate);
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
 AddUpdatedFld(conQxPotenceType.UpdUserId);
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
 AddUpdatedFld(conQxPotenceType.Memo);
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
 /// 权限类型(QxPotenceType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxPotenceType
{
public const string _CurrTabName = "QxPotenceType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PotenceTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PotenceTypeId", "PotenceTypeName", "QxPrjId", "FuncModuleId", "MenuId", "ViewId", "IsVisible", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //模块Id

 /// <summary>
 /// 常量:"MenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuId = "MenuId";    //菜单Id

 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面编号

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