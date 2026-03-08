
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabTypeEN
 表名:TabType(00140099)
 生成代码版本:2019.08.02.1
 生成日期:2019/08/05 00:43:09
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
 /// 表TabType的关键字(TabTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_TabTypeId_TabType
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strTabTypeId">表关键字</param>
public K_TabTypeId_TabType(string strTabTypeId)
{
if (IsValid(strTabTypeId)) Value = strTabTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strTabTypeId)
{
if (string.IsNullOrEmpty(strTabTypeId) == true) return false;
if (strTabTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_TabTypeId_TabType]类型的对象</returns>
public static implicit operator K_TabTypeId_TabType(string value)
{
return new K_TabTypeId_TabType(value);
}
}
 /// <summary>
 /// 表类型(TabType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTabTypeEN : clsEntityBase2
{
public const string _CurrTabName_S = "TabType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "TabTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"TabTypeId", "TabTypeName", "Memo"};
//以下是属性变量

protected string mstrTabTypeId;    //表类型Id
protected string mstrTabTypeName;    //表类型名
protected string mstrMemo;    //备注


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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTabTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "TabType";
 lstKeyFldNames.Add("TabTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strTabTypeId">关键字:表类型Id</param>
public clsTabTypeEN(string strTabTypeId)
 {
strTabTypeId = strTabTypeId.Replace("'", "''");
if (strTabTypeId.Length > 4)
{
throw new Exception("在表:TabType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strTabTypeId)  ==  true)
{
throw new Exception("在表:TabType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrTabTypeId = strTabTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "TabType";
 lstKeyFldNames.Add("TabTypeId");
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
if (strAttributeName  ==  con_TabTypeId)
{
return mstrTabTypeId;
}
else if (strAttributeName  ==  con_TabTypeName)
{
return mstrTabTypeName;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_TabTypeId)
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(con_TabTypeId);
}
else if (strAttributeName  ==  con_TabTypeName)
{
mstrTabTypeName = value.ToString();
 AddUpdatedFld(con_TabTypeName);
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
if (con_TabTypeId  ==  AttributeName[intIndex])
{
return mstrTabTypeId;
}
else if (con_TabTypeName  ==  AttributeName[intIndex])
{
return mstrTabTypeName;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_TabTypeId  ==  AttributeName[intIndex])
{
mstrTabTypeId = value.ToString();
 AddUpdatedFld(con_TabTypeId);
}
else if (con_TabTypeName  ==  AttributeName[intIndex])
{
mstrTabTypeName = value.ToString();
 AddUpdatedFld(con_TabTypeName);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
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
  return mstrTabTypeId;
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
  return mstrTabTypeName;
 }
 }
}
}