
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjTabEN
 表名:vQxPrjTab(00140097)
 生成代码版本:2019.08.02.1
 生成日期:2019/08/05 00:06:28
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433GeneralPlatformTz
 PrjDataBaseId:0184
 模块中文名:字段、表维护
 模块英文名:Table_Field
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
 /// 表vQxPrjTab的关键字(TabId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_TabId_vQxPrjTab
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
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
public const string _CurrTabName_S = "vQxPrjTab"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 26;
public static string[] AttributeName = new string[] {"TabId", "TabName", "TabCnName", "QxPrjId", "PrjName", "SQLDSTypeId", "SqlDsTypeName", "TabStateId", "TabStateName", "IsParaTab", "FuncModuleAgcId", "FuncModuleName", "FuncModuleEnName", "Owner", "Keyword", "TabTypeId", "TabTypeName", "PrimaryTypeId", "PrimaryTypeName", "KeyFldId", "KeyFldName", "UpdUserId", "UpdDate", "Memo", "UpdDate2", "RelaViewId"};
//以下是属性变量

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
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabName = "TabName";    //TabName

 /// <summary>
 /// 常量:"TabCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabCnName = "TabCnName";    //表中文名

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjName = "PrjName";    //工程名

 /// <summary>
 /// 常量:"SQLDSTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SQLDSTypeId = "SQLDSTypeId";    //数据源类型

 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SqlDsTypeName = "SqlDsTypeName";    //Sql数据源名

 /// <summary>
 /// 常量:"TabStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabStateId = "TabStateId";    //表状态ID

 /// <summary>
 /// 常量:"TabStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabStateName = "TabStateName";    //表状态名称

 /// <summary>
 /// 常量:"IsParaTab"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsParaTab = "IsParaTab";    //是否参数表

 /// <summary>
 /// 常量:"FuncModuleAgcId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FuncModuleAgcId = "FuncModuleAgcId";    //功能模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FuncModuleName = "FuncModuleName";    //模块名

 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FuncModuleEnName = "FuncModuleEnName";    //模块英文名

 /// <summary>
 /// 常量:"Owner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Owner = "Owner";    //拥有者

 /// <summary>
 /// 常量:"Keyword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Keyword = "Keyword";    //关键字

 /// <summary>
 /// 常量:"TabTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabTypeId = "TabTypeId";    //表类型Id

 /// <summary>
 /// 常量:"TabTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabTypeName = "TabTypeName";    //表类型名

 /// <summary>
 /// 常量:"PrimaryTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrimaryTypeId = "PrimaryTypeId";    //主键类型ID

 /// <summary>
 /// 常量:"PrimaryTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrimaryTypeName = "PrimaryTypeName";    //主键类型名

 /// <summary>
 /// 常量:"KeyFldId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_KeyFldId = "KeyFldId";    //关键字段Id

 /// <summary>
 /// 常量:"KeyFldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_KeyFldName = "KeyFldName";    //关键字段名

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"UpdDate2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate2 = "UpdDate2";    //UpdDate2

 /// <summary>
 /// 常量:"RelaViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RelaViewId = "RelaViewId";    //RelaViewId

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxPrjTabEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vQxPrjTab";
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
 _CurrTabName = "vQxPrjTab";
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
if (strAttributeName  ==  con_TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  con_TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  con_TabCnName)
{
return mstrTabCnName;
}
else if (strAttributeName  ==  con_QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  con_PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  con_SQLDSTypeId)
{
return mstrSQLDSTypeId;
}
else if (strAttributeName  ==  con_SqlDsTypeName)
{
return mstrSqlDsTypeName;
}
else if (strAttributeName  ==  con_TabStateId)
{
return mstrTabStateId;
}
else if (strAttributeName  ==  con_TabStateName)
{
return mstrTabStateName;
}
else if (strAttributeName  ==  con_IsParaTab)
{
return mbolIsParaTab;
}
else if (strAttributeName  ==  con_FuncModuleAgcId)
{
return mstrFuncModuleAgcId;
}
else if (strAttributeName  ==  con_FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  con_FuncModuleEnName)
{
return mstrFuncModuleEnName;
}
else if (strAttributeName  ==  con_Owner)
{
return mstrOwner;
}
else if (strAttributeName  ==  con_Keyword)
{
return mstrKeyword;
}
else if (strAttributeName  ==  con_TabTypeId)
{
return mstrTabTypeId;
}
else if (strAttributeName  ==  con_TabTypeName)
{
return mstrTabTypeName;
}
else if (strAttributeName  ==  con_PrimaryTypeId)
{
return mstrPrimaryTypeId;
}
else if (strAttributeName  ==  con_PrimaryTypeName)
{
return mstrPrimaryTypeName;
}
else if (strAttributeName  ==  con_KeyFldId)
{
return mstrKeyFldId;
}
else if (strAttributeName  ==  con_KeyFldName)
{
return mstrKeyFldName;
}
else if (strAttributeName  ==  con_UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  con_UpdDate2)
{
return mstrUpdDate2;
}
else if (strAttributeName  ==  con_RelaViewId)
{
return mstrRelaViewId;
}
return null;
}
set
{
if (strAttributeName  ==  con_TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(con_TabId);
}
else if (strAttributeName  ==  con_TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(con_TabName);
}
else if (strAttributeName  ==  con_TabCnName)
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(con_TabCnName);
}
else if (strAttributeName  ==  con_QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(con_QxPrjId);
}
else if (strAttributeName  ==  con_PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(con_PrjName);
}
else if (strAttributeName  ==  con_SQLDSTypeId)
{
mstrSQLDSTypeId = value.ToString();
 AddUpdatedFld(con_SQLDSTypeId);
}
else if (strAttributeName  ==  con_SqlDsTypeName)
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(con_SqlDsTypeName);
}
else if (strAttributeName  ==  con_TabStateId)
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(con_TabStateId);
}
else if (strAttributeName  ==  con_TabStateName)
{
mstrTabStateName = value.ToString();
 AddUpdatedFld(con_TabStateName);
}
else if (strAttributeName  ==  con_IsParaTab)
{
mbolIsParaTab = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsParaTab);
}
else if (strAttributeName  ==  con_FuncModuleAgcId)
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(con_FuncModuleAgcId);
}
else if (strAttributeName  ==  con_FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(con_FuncModuleName);
}
else if (strAttributeName  ==  con_FuncModuleEnName)
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(con_FuncModuleEnName);
}
else if (strAttributeName  ==  con_Owner)
{
mstrOwner = value.ToString();
 AddUpdatedFld(con_Owner);
}
else if (strAttributeName  ==  con_Keyword)
{
mstrKeyword = value.ToString();
 AddUpdatedFld(con_Keyword);
}
else if (strAttributeName  ==  con_TabTypeId)
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(con_TabTypeId);
}
else if (strAttributeName  ==  con_TabTypeName)
{
mstrTabTypeName = value.ToString();
 AddUpdatedFld(con_TabTypeName);
}
else if (strAttributeName  ==  con_PrimaryTypeId)
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(con_PrimaryTypeId);
}
else if (strAttributeName  ==  con_PrimaryTypeName)
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(con_PrimaryTypeName);
}
else if (strAttributeName  ==  con_KeyFldId)
{
mstrKeyFldId = value.ToString();
 AddUpdatedFld(con_KeyFldId);
}
else if (strAttributeName  ==  con_KeyFldName)
{
mstrKeyFldName = value.ToString();
 AddUpdatedFld(con_KeyFldName);
}
else if (strAttributeName  ==  con_UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName  ==  con_UpdDate2)
{
mstrUpdDate2 = value.ToString();
 AddUpdatedFld(con_UpdDate2);
}
else if (strAttributeName  ==  con_RelaViewId)
{
mstrRelaViewId = value.ToString();
 AddUpdatedFld(con_RelaViewId);
}
}
}
public object this[int intIndex]
{
get
{
if (con_TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (con_TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (con_TabCnName  ==  AttributeName[intIndex])
{
return mstrTabCnName;
}
else if (con_QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (con_PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (con_SQLDSTypeId  ==  AttributeName[intIndex])
{
return mstrSQLDSTypeId;
}
else if (con_SqlDsTypeName  ==  AttributeName[intIndex])
{
return mstrSqlDsTypeName;
}
else if (con_TabStateId  ==  AttributeName[intIndex])
{
return mstrTabStateId;
}
else if (con_TabStateName  ==  AttributeName[intIndex])
{
return mstrTabStateName;
}
else if (con_IsParaTab  ==  AttributeName[intIndex])
{
return mbolIsParaTab;
}
else if (con_FuncModuleAgcId  ==  AttributeName[intIndex])
{
return mstrFuncModuleAgcId;
}
else if (con_FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (con_FuncModuleEnName  ==  AttributeName[intIndex])
{
return mstrFuncModuleEnName;
}
else if (con_Owner  ==  AttributeName[intIndex])
{
return mstrOwner;
}
else if (con_Keyword  ==  AttributeName[intIndex])
{
return mstrKeyword;
}
else if (con_TabTypeId  ==  AttributeName[intIndex])
{
return mstrTabTypeId;
}
else if (con_TabTypeName  ==  AttributeName[intIndex])
{
return mstrTabTypeName;
}
else if (con_PrimaryTypeId  ==  AttributeName[intIndex])
{
return mstrPrimaryTypeId;
}
else if (con_PrimaryTypeName  ==  AttributeName[intIndex])
{
return mstrPrimaryTypeName;
}
else if (con_KeyFldId  ==  AttributeName[intIndex])
{
return mstrKeyFldId;
}
else if (con_KeyFldName  ==  AttributeName[intIndex])
{
return mstrKeyFldName;
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (con_UpdDate2  ==  AttributeName[intIndex])
{
return mstrUpdDate2;
}
else if (con_RelaViewId  ==  AttributeName[intIndex])
{
return mstrRelaViewId;
}
return null;
}
set
{
if (con_TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(con_TabId);
}
else if (con_TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(con_TabName);
}
else if (con_TabCnName  ==  AttributeName[intIndex])
{
mstrTabCnName = value.ToString();
 AddUpdatedFld(con_TabCnName);
}
else if (con_QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(con_QxPrjId);
}
else if (con_PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(con_PrjName);
}
else if (con_SQLDSTypeId  ==  AttributeName[intIndex])
{
mstrSQLDSTypeId = value.ToString();
 AddUpdatedFld(con_SQLDSTypeId);
}
else if (con_SqlDsTypeName  ==  AttributeName[intIndex])
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(con_SqlDsTypeName);
}
else if (con_TabStateId  ==  AttributeName[intIndex])
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(con_TabStateId);
}
else if (con_TabStateName  ==  AttributeName[intIndex])
{
mstrTabStateName = value.ToString();
 AddUpdatedFld(con_TabStateName);
}
else if (con_IsParaTab  ==  AttributeName[intIndex])
{
mbolIsParaTab = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsParaTab);
}
else if (con_FuncModuleAgcId  ==  AttributeName[intIndex])
{
mstrFuncModuleAgcId = value.ToString();
 AddUpdatedFld(con_FuncModuleAgcId);
}
else if (con_FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(con_FuncModuleName);
}
else if (con_FuncModuleEnName  ==  AttributeName[intIndex])
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(con_FuncModuleEnName);
}
else if (con_Owner  ==  AttributeName[intIndex])
{
mstrOwner = value.ToString();
 AddUpdatedFld(con_Owner);
}
else if (con_Keyword  ==  AttributeName[intIndex])
{
mstrKeyword = value.ToString();
 AddUpdatedFld(con_Keyword);
}
else if (con_TabTypeId  ==  AttributeName[intIndex])
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(con_TabTypeId);
}
else if (con_TabTypeName  ==  AttributeName[intIndex])
{
mstrTabTypeName = value.ToString();
 AddUpdatedFld(con_TabTypeName);
}
else if (con_PrimaryTypeId  ==  AttributeName[intIndex])
{
mstrPrimaryTypeId = value.ToString();
 AddUpdatedFld(con_PrimaryTypeId);
}
else if (con_PrimaryTypeName  ==  AttributeName[intIndex])
{
mstrPrimaryTypeName = value.ToString();
 AddUpdatedFld(con_PrimaryTypeName);
}
else if (con_KeyFldId  ==  AttributeName[intIndex])
{
mstrKeyFldId = value.ToString();
 AddUpdatedFld(con_KeyFldId);
}
else if (con_KeyFldName  ==  AttributeName[intIndex])
{
mstrKeyFldName = value.ToString();
 AddUpdatedFld(con_KeyFldName);
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_UpdDate2  ==  AttributeName[intIndex])
{
mstrUpdDate2 = value.ToString();
 AddUpdatedFld(con_UpdDate2);
}
else if (con_RelaViewId  ==  AttributeName[intIndex])
{
mstrRelaViewId = value.ToString();
 AddUpdatedFld(con_RelaViewId);
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
 AddUpdatedFld(con_TabId);
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
 AddUpdatedFld(con_TabName);
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
 AddUpdatedFld(con_TabCnName);
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
 AddUpdatedFld(con_PrjName);
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
 AddUpdatedFld(con_SQLDSTypeId);
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
 AddUpdatedFld(con_SqlDsTypeName);
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
 AddUpdatedFld(con_TabStateId);
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
 AddUpdatedFld(con_TabStateName);
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
 AddUpdatedFld(con_IsParaTab);
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
 AddUpdatedFld(con_FuncModuleAgcId);
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
 AddUpdatedFld(con_FuncModuleName);
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
 AddUpdatedFld(con_FuncModuleEnName);
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
 AddUpdatedFld(con_Owner);
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
 AddUpdatedFld(con_Keyword);
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
 AddUpdatedFld(con_TabTypeId);
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
 AddUpdatedFld(con_TabTypeName);
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
 AddUpdatedFld(con_PrimaryTypeId);
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
 AddUpdatedFld(con_PrimaryTypeName);
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
 AddUpdatedFld(con_KeyFldId);
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
 AddUpdatedFld(con_KeyFldName);
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
 AddUpdatedFld(con_UpdDate2);
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
 AddUpdatedFld(con_RelaViewId);
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
  return mstrTabId;
 }
 }
}
}