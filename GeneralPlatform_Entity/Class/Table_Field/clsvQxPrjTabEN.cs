
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjTabEN
 表名:vQxPrjTab(00140097)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:46:48
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
 /// 表vQxPrjTab的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_TabId_vQxPrjTab
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
public K_TabId_vQxPrjTab(string strTabId)
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
 /// <returns>返回:[K_TabId_vQxPrjTab]类型的对象</returns>
public static implicit operator K_TabId_vQxPrjTab(string value)
{
return new K_TabId_vQxPrjTab(value);
}
}
 /// <summary>
 /// v工程表(vQxPrjTab)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxPrjTabEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxPrjTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 26;
public static string[] AttributeName = new string[] {"TabId", "TabName", "TabCnName", "QxPrjId", "PrjName", "SQLDSTypeId", "SqlDsTypeName", "TabStateId", "TabStateName", "IsParaTab", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "Owner", "Keyword", "TabTypeId", "TabTypeName", "PrimaryTypeId", "PrimaryTypeName", "KeyFldId", "KeyFldName", "UpdUserId", "UpdDate", "Memo", "UpdDate2", "RelaViewId"};

protected string mstrTabId;    //表ID
protected string mstrTabName;    //TabName
protected string mstrTabCnName;    //表中文名
protected string mstrQxPrjId;    //项目Id
protected string mstrPrjName;    //工程名
protected string mstrSQLDSTypeId;    //数据源类型
protected string mstrSqlDsTypeName;    //Sql数据源名
protected string mstrTabStateId;    //表状态ID
protected string mstrTabStateName;    //表状态名称
protected bool mbolIsParaTab;    //是否参数表
protected string mstrFuncModuleAgcId;    //功能模块Id
protected string mstrFuncModuleName;    //模块名
protected string mstrFuncModuleEnName;    //模块英文名
protected string mstrOwner;    //拥有者
protected string mstrKeyword;    //关键字
protected string mstrTabTypeId;    //表类型Id
protected string mstrTabTypeName;    //表类型名
protected string mstrPrimaryTypeId;    //主键类型ID
protected string mstrPrimaryTypeName;    //主键类型名
protected string mstrKeyFldId;    //关键字段Id
protected string mstrKeyFldName;    //关键字段名
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注
protected string mstrUpdDate2;    //UpdDate2
protected string mstrRelaViewId;    //RelaViewId

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxPrjTabEN()
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
public clsvQxPrjTabEN(string strTabId)
 {
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("在表:vQxPrjTab中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("在表:vQxPrjTab中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convQxPrjTab.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convQxPrjTab.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convQxPrjTab.TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  convQxPrjTab.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxPrjTab.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxPrjTab.SQLDSTypeId)
{
return mstrSQLDSTypeId;
}
else if (strAttributeName  ==  convQxPrjTab.SqlDsTypeName)
{
return mstrSqlDsTypeName;
}
else if (strAttributeName  ==  convQxPrjTab.TabStateId)
{
return mstrTabStateId;
}
else if (strAttributeName  ==  convQxPrjTab.TabStateName)
{
return mstrTabStateName;
}
else if (strAttributeName  ==  convQxPrjTab.IsParaTab)
{
return mbolIsParaTab;
}
else if (strAttributeName  ==  convQxPrjTab.FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  convQxPrjTab.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  convQxPrjTab.FuncModuleEnName)
{
return mstrFuncModuleEnName;
}
else if (strAttributeName  ==  convQxPrjTab.Owner)
{
return mstrOwner;
}
else if (strAttributeName  ==  convQxPrjTab.Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  convQxPrjTab.TabTypeId)
{
return mstrTabTypeId;
}
else if (strAttributeName  ==  convQxPrjTab.TabTypeName)
{
return mstrTabTypeName;
}
else if (strAttributeName  ==  convQxPrjTab.PrimaryTypeId)
{
return mstrPrimaryTypeId;
}
else if (strAttributeName  ==  convQxPrjTab.PrimaryTypeName)
{
return mstrPrimaryTypeName;
}
else if (strAttributeName  ==  convQxPrjTab.KeyFldId)
{
return mstrKeyFldId;
}
else if (strAttributeName  ==  convQxPrjTab.KeyFldName)
{
return mstrKeyFldName;
}
else if (strAttributeName  ==  convQxPrjTab.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convQxPrjTab.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxPrjTab.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convQxPrjTab.UpdDate2)
{
return mstrUpdDate2;
}
else if (strAttributeName  ==  convQxPrjTab.RelaViewId)
{
return mstrRelaViewId;
}
return null;
}
set
{
if (strAttributeName  ==  convQxPrjTab.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convQxPrjTab.TabId);
}
else if (strAttributeName  ==  convQxPrjTab.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convQxPrjTab.TabName);
}
else if (strAttributeName  ==  convQxPrjTab.TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convQxPrjTab.TabCnName);
}
else if (strAttributeName  ==  convQxPrjTab.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPrjTab.QxPrjId);
}
else if (strAttributeName  ==  convQxPrjTab.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPrjTab.PrjName);
}
else if (strAttributeName  ==  convQxPrjTab.SQLDSTypeId)
{
mstrSQLDSTypeId = value.ToString();
 AddUpdatedFld(convQxPrjTab.SQLDSTypeId);
}
else if (strAttributeName  ==  convQxPrjTab.SqlDsTypeName)
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convQxPrjTab.SqlDsTypeName);
}
else if (strAttributeName  ==  convQxPrjTab.TabStateId)
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convQxPrjTab.TabStateId);
}
else if (strAttributeName  ==  convQxPrjTab.TabStateName)
{
mstrTabStateName = value.ToString();
 AddUpdatedFld(convQxPrjTab.TabStateName);
}
else if (strAttributeName  ==  convQxPrjTab.IsParaTab)
{
mbolIsParaTab = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjTab.IsParaTab);
}
else if (strAttributeName  ==  convQxPrjTab.FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convQxPrjTab.FuncModuleAgcId);
}
else if (strAttributeName  ==  convQxPrjTab.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQxPrjTab.FuncModuleName);
}
else if (strAttributeName  ==  convQxPrjTab.FuncModuleEnName)
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convQxPrjTab.FuncModuleEnName);
}
else if (strAttributeName  ==  convQxPrjTab.Owner)
{
mstrOwner = value.ToString();
 AddUpdatedFld(convQxPrjTab.Owner);
}
else if (strAttributeName  ==  convQxPrjTab.Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convQxPrjTab.Keyword);
}
else if (strAttributeName  ==  convQxPrjTab.TabTypeId)
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(convQxPrjTab.TabTypeId);
}
else if (strAttributeName  ==  convQxPrjTab.TabTypeName)
{
mstrTabTypeName = value.ToString();
 AddUpdatedFld(convQxPrjTab.TabTypeName);
}
else if (strAttributeName  ==  convQxPrjTab.PrimaryTypeId)
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(convQxPrjTab.PrimaryTypeId);
}
else if (strAttributeName  ==  convQxPrjTab.PrimaryTypeName)
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(convQxPrjTab.PrimaryTypeName);
}
else if (strAttributeName  ==  convQxPrjTab.KeyFldId)
{
mstrKeyFldId = value.ToString();
 AddUpdatedFld(convQxPrjTab.KeyFldId);
}
else if (strAttributeName  ==  convQxPrjTab.KeyFldName)
{
mstrKeyFldName = value.ToString();
 AddUpdatedFld(convQxPrjTab.KeyFldName);
}
else if (strAttributeName  ==  convQxPrjTab.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxPrjTab.UpdUserId);
}
else if (strAttributeName  ==  convQxPrjTab.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxPrjTab.UpdDate);
}
else if (strAttributeName  ==  convQxPrjTab.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPrjTab.Memo);
}
else if (strAttributeName  ==  convQxPrjTab.UpdDate2)
{
mstrUpdDate2 = value.ToString();
 AddUpdatedFld(convQxPrjTab.UpdDate2);
}
else if (strAttributeName  ==  convQxPrjTab.RelaViewId)
{
mstrRelaViewId = value.ToString();
 AddUpdatedFld(convQxPrjTab.RelaViewId);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxPrjTab.TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (convQxPrjTab.TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (convQxPrjTab.TabCnName  ==  AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (convQxPrjTab.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxPrjTab.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxPrjTab.SQLDSTypeId  ==  AttributeName[intIndex])
{
return mstrSQLDSTypeId;
}
else if (convQxPrjTab.SqlDsTypeName  ==  AttributeName[intIndex])
{
return mstrSqlDsTypeName;
}
else if (convQxPrjTab.TabStateId  ==  AttributeName[intIndex])
{
return mstrTabStateId;
}
else if (convQxPrjTab.TabStateName  ==  AttributeName[intIndex])
{
return mstrTabStateName;
}
else if (convQxPrjTab.IsParaTab  ==  AttributeName[intIndex])
{
return mbolIsParaTab;
}
else if (convQxPrjTab.FuncModuleAgcId  ==  AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (convQxPrjTab.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (convQxPrjTab.FuncModuleEnName  ==  AttributeName[intIndex])
{
return mstrFuncModuleEnName;
}
else if (convQxPrjTab.Owner  ==  AttributeName[intIndex])
{
return mstrOwner;
}
else if (convQxPrjTab.Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (convQxPrjTab.TabTypeId  ==  AttributeName[intIndex])
{
return mstrTabTypeId;
}
else if (convQxPrjTab.TabTypeName  ==  AttributeName[intIndex])
{
return mstrTabTypeName;
}
else if (convQxPrjTab.PrimaryTypeId  ==  AttributeName[intIndex])
{
return mstrPrimaryTypeId;
}
else if (convQxPrjTab.PrimaryTypeName  ==  AttributeName[intIndex])
{
return mstrPrimaryTypeName;
}
else if (convQxPrjTab.KeyFldId  ==  AttributeName[intIndex])
{
return mstrKeyFldId;
}
else if (convQxPrjTab.KeyFldName  ==  AttributeName[intIndex])
{
return mstrKeyFldName;
}
else if (convQxPrjTab.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convQxPrjTab.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxPrjTab.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convQxPrjTab.UpdDate2  ==  AttributeName[intIndex])
{
return mstrUpdDate2;
}
else if (convQxPrjTab.RelaViewId  ==  AttributeName[intIndex])
{
return mstrRelaViewId;
}
return null;
}
set
{
if (convQxPrjTab.TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convQxPrjTab.TabId);
}
else if (convQxPrjTab.TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convQxPrjTab.TabName);
}
else if (convQxPrjTab.TabCnName  ==  AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(convQxPrjTab.TabCnName);
}
else if (convQxPrjTab.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPrjTab.QxPrjId);
}
else if (convQxPrjTab.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPrjTab.PrjName);
}
else if (convQxPrjTab.SQLDSTypeId  ==  AttributeName[intIndex])
{
mstrSQLDSTypeId = value.ToString();
 AddUpdatedFld(convQxPrjTab.SQLDSTypeId);
}
else if (convQxPrjTab.SqlDsTypeName  ==  AttributeName[intIndex])
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(convQxPrjTab.SqlDsTypeName);
}
else if (convQxPrjTab.TabStateId  ==  AttributeName[intIndex])
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(convQxPrjTab.TabStateId);
}
else if (convQxPrjTab.TabStateName  ==  AttributeName[intIndex])
{
mstrTabStateName = value.ToString();
 AddUpdatedFld(convQxPrjTab.TabStateName);
}
else if (convQxPrjTab.IsParaTab  ==  AttributeName[intIndex])
{
mbolIsParaTab = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjTab.IsParaTab);
}
else if (convQxPrjTab.FuncModuleAgcId  ==  AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(convQxPrjTab.FuncModuleAgcId);
}
else if (convQxPrjTab.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(convQxPrjTab.FuncModuleName);
}
else if (convQxPrjTab.FuncModuleEnName  ==  AttributeName[intIndex])
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(convQxPrjTab.FuncModuleEnName);
}
else if (convQxPrjTab.Owner  ==  AttributeName[intIndex])
{
mstrOwner = value.ToString();
 AddUpdatedFld(convQxPrjTab.Owner);
}
else if (convQxPrjTab.Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(convQxPrjTab.Keyword);
}
else if (convQxPrjTab.TabTypeId  ==  AttributeName[intIndex])
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(convQxPrjTab.TabTypeId);
}
else if (convQxPrjTab.TabTypeName  ==  AttributeName[intIndex])
{
mstrTabTypeName = value.ToString();
 AddUpdatedFld(convQxPrjTab.TabTypeName);
}
else if (convQxPrjTab.PrimaryTypeId  ==  AttributeName[intIndex])
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(convQxPrjTab.PrimaryTypeId);
}
else if (convQxPrjTab.PrimaryTypeName  ==  AttributeName[intIndex])
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(convQxPrjTab.PrimaryTypeName);
}
else if (convQxPrjTab.KeyFldId  ==  AttributeName[intIndex])
{
mstrKeyFldId = value.ToString();
 AddUpdatedFld(convQxPrjTab.KeyFldId);
}
else if (convQxPrjTab.KeyFldName  ==  AttributeName[intIndex])
{
mstrKeyFldName = value.ToString();
 AddUpdatedFld(convQxPrjTab.KeyFldName);
}
else if (convQxPrjTab.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxPrjTab.UpdUserId);
}
else if (convQxPrjTab.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxPrjTab.UpdDate);
}
else if (convQxPrjTab.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPrjTab.Memo);
}
else if (convQxPrjTab.UpdDate2  ==  AttributeName[intIndex])
{
mstrUpdDate2 = value.ToString();
 AddUpdatedFld(convQxPrjTab.UpdDate2);
}
else if (convQxPrjTab.RelaViewId  ==  AttributeName[intIndex])
{
mstrRelaViewId = value.ToString();
 AddUpdatedFld(convQxPrjTab.RelaViewId);
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
 AddUpdatedFld(convQxPrjTab.TabId);
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
 AddUpdatedFld(convQxPrjTab.TabName);
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
 AddUpdatedFld(convQxPrjTab.TabCnName);
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
 AddUpdatedFld(convQxPrjTab.QxPrjId);
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
 AddUpdatedFld(convQxPrjTab.PrjName);
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
 AddUpdatedFld(convQxPrjTab.SQLDSTypeId);
}
}
/// <summary>
/// Sql数据源名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeName
{
get
{
return mstrSqlDsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeName = value;
}
else
{
 mstrSqlDsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjTab.SqlDsTypeName);
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
 AddUpdatedFld(convQxPrjTab.TabStateId);
}
}
/// <summary>
/// 表状态名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabStateName
{
get
{
return mstrTabStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabStateName = value;
}
else
{
 mstrTabStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjTab.TabStateName);
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
 AddUpdatedFld(convQxPrjTab.IsParaTab);
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
 AddUpdatedFld(convQxPrjTab.FuncModuleAgcId);
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
 AddUpdatedFld(convQxPrjTab.FuncModuleName);
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
 AddUpdatedFld(convQxPrjTab.FuncModuleEnName);
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
 AddUpdatedFld(convQxPrjTab.Owner);
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
 AddUpdatedFld(convQxPrjTab.Keyword);
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
 AddUpdatedFld(convQxPrjTab.TabTypeId);
}
}
/// <summary>
/// 表类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabTypeName
{
get
{
return mstrTabTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabTypeName = value;
}
else
{
 mstrTabTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjTab.TabTypeName);
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
 AddUpdatedFld(convQxPrjTab.PrimaryTypeId);
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
 AddUpdatedFld(convQxPrjTab.PrimaryTypeName);
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
 AddUpdatedFld(convQxPrjTab.KeyFldId);
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
 AddUpdatedFld(convQxPrjTab.KeyFldName);
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
 AddUpdatedFld(convQxPrjTab.UpdUserId);
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
 AddUpdatedFld(convQxPrjTab.UpdDate);
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
 AddUpdatedFld(convQxPrjTab.Memo);
}
}
/// <summary>
/// UpdDate2(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate2
{
get
{
return mstrUpdDate2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate2 = value;
}
else
{
 mstrUpdDate2 = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjTab.UpdDate2);
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
 AddUpdatedFld(convQxPrjTab.RelaViewId);
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
}
 /// <summary>
 /// v工程表(vQxPrjTab)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxPrjTab
{
public const string _CurrTabName = "vQxPrjTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"TabId", "TabName", "TabCnName", "QxPrjId", "PrjName", "SQLDSTypeId", "SqlDsTypeName", "TabStateId", "TabStateName", "IsParaTab", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "Owner", "Keyword", "TabTypeId", "TabTypeName", "PrimaryTypeId", "PrimaryTypeName", "KeyFldId", "KeyFldName", "UpdUserId", "UpdDate", "Memo", "UpdDate2", "RelaViewId"};
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
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名

 /// <summary>
 /// 常量:"SQLDSTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SQLDSTypeId = "SQLDSTypeId";    //数据源类型

 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SqlDsTypeName = "SqlDsTypeName";    //Sql数据源名

 /// <summary>
 /// 常量:"TabStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateId = "TabStateId";    //表状态ID

 /// <summary>
 /// 常量:"TabStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabStateName = "TabStateName";    //表状态名称

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
 /// 常量:"TabTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabTypeName = "TabTypeName";    //表类型名

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
 /// 常量:"UpdDate2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate2 = "UpdDate2";    //UpdDate2

 /// <summary>
 /// 常量:"RelaViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RelaViewId = "RelaViewId";    //RelaViewId
}

}