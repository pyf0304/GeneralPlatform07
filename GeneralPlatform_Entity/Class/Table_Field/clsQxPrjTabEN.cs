
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjTabEN
 表名:QxPrjTab(00140096)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:44:40
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:字段、表维护(Table_Field)
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
 /// 表QxPrjTab的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabId_QxPrjTab
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabId">表关键字</param>
public K_TabId_QxPrjTab(string strTabId)
{
if (IsValid(strTabId)) Value = strTabId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true) return false;
if (strTabId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabId_QxPrjTab]类型的对象</returns>
public static implicit operator K_TabId_QxPrjTab(string value)
{
return new K_TabId_QxPrjTab(value);
}
}
 /// <summary>
 /// 工程表(QxPrjTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxPrjTabEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxPrjTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"TabId", "TabName", "TabCnName", "QxPrjId", "SQLDSTypeId", "TabStateId", "IsParaTab", "FuncModuleAgcId", "Owner", "Keyword", "TabTypeId", "RelaViewId", "PrimaryTypeId", "PrimaryTypeName", "KeyFldId", "KeyFldName", "UpdUserId", "UpdDate", "Memo", "SynchDate"};

protected string mstrTabId;    //表ID
protected string mstrTabName;    //TabName
protected string mstrTabCnName;    //表中文名
protected string mstrQxPrjId;    //项目Id
protected string mstrSQLDSTypeId;    //数据源类型
protected string mstrTabStateId;    //表状态ID
protected bool mbolIsParaTab;    //是否参数表
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrOwner;    //拥有者
protected string mstrKeyword;    //关键字
protected string mstrTabTypeId;    //表类型Id
protected string mstrRelaViewId;    //RelaViewId
protected string mstrPrimaryTypeId;    //主键类型ID
protected string mstrPrimaryTypeName;    //主键类型名
protected string mstrKeyFldId;    //关键字段Id
protected string mstrKeyFldName;    //关键字段名
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrSynchDate;    //同步日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxPrjTabEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTabId">关键字:表ID</param>
public clsQxPrjTabEN(string strTabId)
 {
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("在表:QxPrjTab中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("在表:QxPrjTab中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabId = strTabId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("TabId");
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
if (strAttributeName  ==  conQxPrjTab.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conQxPrjTab.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  conQxPrjTab.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  conQxPrjTab.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxPrjTab.SQLDSTypeId)
{
return mstrSQLDSTypeId;
}
else if (strAttributeName  ==  conQxPrjTab.TabStateId)
{
return mstrTabStateId;
}
else if (strAttributeName  ==  conQxPrjTab.IsParaTab)
{
return mbolIsParaTab;
}
else if (strAttributeName  ==  conQxPrjTab.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  conQxPrjTab.Owner)
{
return mstrOwner;
}
else if (strAttributeName  ==  conQxPrjTab.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  conQxPrjTab.TabTypeId)
{
return mstrTabTypeId;
}
else if (strAttributeName  ==  conQxPrjTab.RelaViewId)
{
return mstrRelaViewId;
}
else if (strAttributeName  ==  conQxPrjTab.PrimaryTypeId)
{
return mstrPrimaryTypeId;
}
else if (strAttributeName  ==  conQxPrjTab.PrimaryTypeName)
{
return mstrPrimaryTypeName;
}
else if (strAttributeName  ==  conQxPrjTab.KeyFldId)
{
return mstrKeyFldId;
}
else if (strAttributeName  ==  conQxPrjTab.KeyFldName)
{
return mstrKeyFldName;
}
else if (strAttributeName  ==  conQxPrjTab.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conQxPrjTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxPrjTab.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conQxPrjTab.SynchDate)
{
return mstrSynchDate;
}
return null;
}
set
{
if (strAttributeName  ==  conQxPrjTab.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conQxPrjTab.TabId);
}
else if (strAttributeName  ==  conQxPrjTab.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(conQxPrjTab.TabName);
}
else if (strAttributeName  ==  conQxPrjTab.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(conQxPrjTab.TabCnName);
}
else if (strAttributeName  ==  conQxPrjTab.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjTab.QxPrjId);
}
else if (strAttributeName  ==  conQxPrjTab.SQLDSTypeId)
{
mstrSQLDSTypeId = value.ToString();
 AddUpdatedFld(conQxPrjTab.SQLDSTypeId);
}
else if (strAttributeName  ==  conQxPrjTab.TabStateId)
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(conQxPrjTab.TabStateId);
}
else if (strAttributeName  ==  conQxPrjTab.IsParaTab)
{
mbolIsParaTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjTab.IsParaTab);
}
else if (strAttributeName  ==  conQxPrjTab.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conQxPrjTab.FuncModuleAgcId);
}
else if (strAttributeName  ==  conQxPrjTab.Owner)
{
mstrOwner = value.ToString();
 AddUpdatedFld(conQxPrjTab.Owner);
}
else if (strAttributeName  ==  conQxPrjTab.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(conQxPrjTab.Keyword);
}
else if (strAttributeName  ==  conQxPrjTab.TabTypeId)
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(conQxPrjTab.TabTypeId);
}
else if (strAttributeName  ==  conQxPrjTab.RelaViewId)
{
mstrRelaViewId = value.ToString();
 AddUpdatedFld(conQxPrjTab.RelaViewId);
}
else if (strAttributeName  ==  conQxPrjTab.PrimaryTypeId)
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(conQxPrjTab.PrimaryTypeId);
}
else if (strAttributeName  ==  conQxPrjTab.PrimaryTypeName)
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(conQxPrjTab.PrimaryTypeName);
}
else if (strAttributeName  ==  conQxPrjTab.KeyFldId)
{
mstrKeyFldId = value.ToString();
 AddUpdatedFld(conQxPrjTab.KeyFldId);
}
else if (strAttributeName  ==  conQxPrjTab.KeyFldName)
{
mstrKeyFldName = value.ToString();
 AddUpdatedFld(conQxPrjTab.KeyFldName);
}
else if (strAttributeName  ==  conQxPrjTab.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPrjTab.UpdUserId);
}
else if (strAttributeName  ==  conQxPrjTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjTab.UpdDate);
}
else if (strAttributeName  ==  conQxPrjTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjTab.Memo);
}
else if (strAttributeName  ==  conQxPrjTab.SynchDate)
{
mstrSynchDate = value.ToString();
 AddUpdatedFld(conQxPrjTab.SynchDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxPrjTab.TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (conQxPrjTab.TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (conQxPrjTab.TabCnName  ==  AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (conQxPrjTab.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxPrjTab.SQLDSTypeId  ==  AttributeName[intIndex])
{
return mstrSQLDSTypeId;
}
else if (conQxPrjTab.TabStateId  ==  AttributeName[intIndex])
{
return mstrTabStateId;
}
else if (conQxPrjTab.IsParaTab  ==  AttributeName[intIndex])
{
return mbolIsParaTab;
}
else if (conQxPrjTab.FuncModuleAgcId  ==  AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (conQxPrjTab.Owner  ==  AttributeName[intIndex])
{
return mstrOwner;
}
else if (conQxPrjTab.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (conQxPrjTab.TabTypeId  ==  AttributeName[intIndex])
{
return mstrTabTypeId;
}
else if (conQxPrjTab.RelaViewId  ==  AttributeName[intIndex])
{
return mstrRelaViewId;
}
else if (conQxPrjTab.PrimaryTypeId  ==  AttributeName[intIndex])
{
return mstrPrimaryTypeId;
}
else if (conQxPrjTab.PrimaryTypeName  ==  AttributeName[intIndex])
{
return mstrPrimaryTypeName;
}
else if (conQxPrjTab.KeyFldId  ==  AttributeName[intIndex])
{
return mstrKeyFldId;
}
else if (conQxPrjTab.KeyFldName  ==  AttributeName[intIndex])
{
return mstrKeyFldName;
}
else if (conQxPrjTab.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conQxPrjTab.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxPrjTab.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conQxPrjTab.SynchDate  ==  AttributeName[intIndex])
{
return mstrSynchDate;
}
return null;
}
set
{
if (conQxPrjTab.TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conQxPrjTab.TabId);
}
else if (conQxPrjTab.TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(conQxPrjTab.TabName);
}
else if (conQxPrjTab.TabCnName  ==  AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(conQxPrjTab.TabCnName);
}
else if (conQxPrjTab.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjTab.QxPrjId);
}
else if (conQxPrjTab.SQLDSTypeId  ==  AttributeName[intIndex])
{
mstrSQLDSTypeId = value.ToString();
 AddUpdatedFld(conQxPrjTab.SQLDSTypeId);
}
else if (conQxPrjTab.TabStateId  ==  AttributeName[intIndex])
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(conQxPrjTab.TabStateId);
}
else if (conQxPrjTab.IsParaTab  ==  AttributeName[intIndex])
{
mbolIsParaTab = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjTab.IsParaTab);
}
else if (conQxPrjTab.FuncModuleAgcId  ==  AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(conQxPrjTab.FuncModuleAgcId);
}
else if (conQxPrjTab.Owner  ==  AttributeName[intIndex])
{
mstrOwner = value.ToString();
 AddUpdatedFld(conQxPrjTab.Owner);
}
else if (conQxPrjTab.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(conQxPrjTab.Keyword);
}
else if (conQxPrjTab.TabTypeId  ==  AttributeName[intIndex])
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(conQxPrjTab.TabTypeId);
}
else if (conQxPrjTab.RelaViewId  ==  AttributeName[intIndex])
{
mstrRelaViewId = value.ToString();
 AddUpdatedFld(conQxPrjTab.RelaViewId);
}
else if (conQxPrjTab.PrimaryTypeId  ==  AttributeName[intIndex])
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(conQxPrjTab.PrimaryTypeId);
}
else if (conQxPrjTab.PrimaryTypeName  ==  AttributeName[intIndex])
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(conQxPrjTab.PrimaryTypeName);
}
else if (conQxPrjTab.KeyFldId  ==  AttributeName[intIndex])
{
mstrKeyFldId = value.ToString();
 AddUpdatedFld(conQxPrjTab.KeyFldId);
}
else if (conQxPrjTab.KeyFldName  ==  AttributeName[intIndex])
{
mstrKeyFldName = value.ToString();
 AddUpdatedFld(conQxPrjTab.KeyFldName);
}
else if (conQxPrjTab.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPrjTab.UpdUserId);
}
else if (conQxPrjTab.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjTab.UpdDate);
}
else if (conQxPrjTab.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjTab.Memo);
}
else if (conQxPrjTab.SynchDate  ==  AttributeName[intIndex])
{
mstrSynchDate = value.ToString();
 AddUpdatedFld(conQxPrjTab.SynchDate);
}
}
}

/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjTab.TabId);
}
}
/// <summary>
/// TabName(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjTab.TabName);
}
}
/// <summary>
/// 表中文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabCnName
{
get
{
return mstrTabCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabCnName = value;
}
else
{
 mstrTabCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjTab.TabCnName);
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
 AddUpdatedFld(conQxPrjTab.QxPrjId);
}
}
/// <summary>
/// 数据源类型(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SQLDSTypeId
{
get
{
return mstrSQLDSTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSQLDSTypeId = value;
}
else
{
 mstrSQLDSTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjTab.SQLDSTypeId);
}
}
/// <summary>
/// 表状态ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabStateId
{
get
{
return mstrTabStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabStateId = value;
}
else
{
 mstrTabStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjTab.TabStateId);
}
}
/// <summary>
/// 是否参数表(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsParaTab
{
get
{
return mbolIsParaTab;
}
set
{
 mbolIsParaTab = value;
//记录修改过的字段
 AddUpdatedFld(conQxPrjTab.IsParaTab);
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
 AddUpdatedFld(conQxPrjTab.FuncModuleAgcId);
}
}
/// <summary>
/// 拥有者(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Owner
{
get
{
return mstrOwner;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOwner = value;
}
else
{
 mstrOwner = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjTab.Owner);
}
}
/// <summary>
/// 关键字(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Keyword
{
get
{
return mstrKeyword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyword = value;
}
else
{
 mstrKeyword = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjTab.Keyword);
}
}
/// <summary>
/// 表类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabTypeId
{
get
{
return mstrTabTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabTypeId = value;
}
else
{
 mstrTabTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjTab.TabTypeId);
}
}
/// <summary>
/// RelaViewId(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RelaViewId
{
get
{
return mstrRelaViewId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRelaViewId = value;
}
else
{
 mstrRelaViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjTab.RelaViewId);
}
}
/// <summary>
/// 主键类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryTypeId
{
get
{
return mstrPrimaryTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryTypeId = value;
}
else
{
 mstrPrimaryTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjTab.PrimaryTypeId);
}
}
/// <summary>
/// 主键类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrimaryTypeName
{
get
{
return mstrPrimaryTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrimaryTypeName = value;
}
else
{
 mstrPrimaryTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjTab.PrimaryTypeName);
}
}
/// <summary>
/// 关键字段Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyFldId
{
get
{
return mstrKeyFldId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyFldId = value;
}
else
{
 mstrKeyFldId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjTab.KeyFldId);
}
}
/// <summary>
/// 关键字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string KeyFldName
{
get
{
return mstrKeyFldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrKeyFldName = value;
}
else
{
 mstrKeyFldName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjTab.KeyFldName);
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
 AddUpdatedFld(conQxPrjTab.UpdUserId);
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
 AddUpdatedFld(conQxPrjTab.UpdDate);
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
 AddUpdatedFld(conQxPrjTab.Memo);
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
 AddUpdatedFld(conQxPrjTab.SynchDate);
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
  return mstrTabId;
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
  return mstrTabName;
 }
 }
}
 /// <summary>
 /// 工程表(QxPrjTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxPrjTab
{
public const string _CurrTabName = "QxPrjTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TabId", "TabName", "TabCnName", "QxPrjId", "SQLDSTypeId", "TabStateId", "IsParaTab", "FuncModuleAgcId", "Owner", "Keyword", "TabTypeId", "RelaViewId", "PrimaryTypeId", "PrimaryTypeName", "KeyFldId", "KeyFldName", "UpdUserId", "UpdDate", "Memo", "SynchDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //TabName

 /// <summary>
 /// 常量:"TabCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabCnName = "TabCnName";    //表中文名

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"SQLDSTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SQLDSTypeId = "SQLDSTypeId";    //数据源类型

 /// <summary>
 /// 常量:"TabStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateId = "TabStateId";    //表状态ID

 /// <summary>
 /// 常量:"IsParaTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsParaTab = "IsParaTab";    //是否参数表

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"Owner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Owner = "Owner";    //拥有者

 /// <summary>
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Keyword = "Keyword";    //关键字

 /// <summary>
 /// 常量:"TabTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabTypeId = "TabTypeId";    //表类型Id

 /// <summary>
 /// 常量:"RelaViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaViewId = "RelaViewId";    //RelaViewId

 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryTypeId = "PrimaryTypeId";    //主键类型ID

 /// <summary>
 /// 常量:"PrimaryTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrimaryTypeName = "PrimaryTypeName";    //主键类型名

 /// <summary>
 /// 常量:"KeyFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyFldId = "KeyFldId";    //关键字段Id

 /// <summary>
 /// 常量:"KeyFldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string KeyFldName = "KeyFldName";    //关键字段名

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

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