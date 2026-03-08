
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabStateEN
 表名:TabState(00140098)
 生成代码版本:2019.08.02.1
 生成日期:2019/08/05 00:43:11
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
 /// 表TabState的关键字(TabStateId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_TabStateId_TabState
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabStateId">表关键字</param>
public K_TabStateId_TabState(string strTabStateId)
{
if (IsValid(strTabStateId)) Value = strTabStateId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabStateId)
{
if (string.IsNullOrEmpty(strTabStateId) == true) return false;
if (strTabStateId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabStateId_TabState]类型的对象</returns>
public static implicit operator K_TabStateId_TabState(string value)
{
return new K_TabStateId_TabState(value);
}
}
 /// <summary>
 /// 表状态(TabState)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTabStateEN : clsEntityBase2
{
public const string _CurrTabName_S = "TabState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"TabStateId", "TabStateName", "TabStateENName", "Memo"};
//以下是属性变量

protected string mstrTabStateId;    //表状态ID
protected string mstrTabStateName;    //表状态名称
protected string mstrTabStateENName;    //表状态英文名
protected string mstrMemo;    //备注


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
 /// 常量:"TabStateENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabStateENName = "TabStateENName";    //表状态英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTabStateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "TabState";
 lstKeyFldNames.Add("TabStateId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTabStateId">关键字:表状态ID</param>
public clsTabStateEN(string strTabStateId)
 {
strTabStateId = strTabStateId.Replace("'", "''");
if (strTabStateId.Length > 2)
{
throw new Exception("在表:TabState中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabStateId)  ==  true)
{
throw new Exception("在表:TabState中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabStateId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabStateId = strTabStateId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "TabState";
 lstKeyFldNames.Add("TabStateId");
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
if (strAttributeName  ==  con_TabStateId)
{
return mstrTabStateId;
}
else if (strAttributeName  ==  con_TabStateName)
{
return mstrTabStateName;
}
else if (strAttributeName  ==  con_TabStateENName)
{
return mstrTabStateENName;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_TabStateId)
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(con_TabStateId);
}
else if (strAttributeName  ==  con_TabStateName)
{
mstrTabStateName = value.ToString();
 AddUpdatedFld(con_TabStateName);
}
else if (strAttributeName  ==  con_TabStateENName)
{
mstrTabStateENName = value.ToString();
 AddUpdatedFld(con_TabStateENName);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (con_TabStateId  ==  AttributeName[intIndex])
{
return mstrTabStateId;
}
else if (con_TabStateName  ==  AttributeName[intIndex])
{
return mstrTabStateName;
}
else if (con_TabStateENName  ==  AttributeName[intIndex])
{
return mstrTabStateENName;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_TabStateId  ==  AttributeName[intIndex])
{
mstrTabStateId = value.ToString();
 AddUpdatedFld(con_TabStateId);
}
else if (con_TabStateName  ==  AttributeName[intIndex])
{
mstrTabStateName = value.ToString();
 AddUpdatedFld(con_TabStateName);
}
else if (con_TabStateENName  ==  AttributeName[intIndex])
{
mstrTabStateENName = value.ToString();
 AddUpdatedFld(con_TabStateENName);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
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
/// 表状态英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabStateENName
{
get
{
return mstrTabStateENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabStateENName = value;
}
else
{
 mstrTabStateENName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_TabStateENName);
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
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrTabStateId;
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
  return mstrTabStateName;
 }
 }
}
}