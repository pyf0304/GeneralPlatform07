
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataBaseTypeEN
 表名:DataBaseType(00140038)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 10:00:46
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:工程管理
 模块英文名:PrjManage
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
 /// 表DataBaseType的关键字(DataBaseTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_DataBaseTypeId_DataBaseType
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDataBaseTypeId">表关键字</param>
public K_DataBaseTypeId_DataBaseType(string strDataBaseTypeId)
{
if (IsValid(strDataBaseTypeId)) Value = strDataBaseTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strDataBaseTypeId)
{
if (string.IsNullOrEmpty(strDataBaseTypeId) == true) return false;
if (strDataBaseTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DataBaseTypeId_DataBaseType]类型的对象</returns>
public static implicit operator K_DataBaseTypeId_DataBaseType(string value)
{
return new K_DataBaseTypeId_DataBaseType(value);
}
}
 /// <summary>
 /// 数据库类型(DataBaseType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsDataBaseTypeEN : clsEntityBase2
{
public const string _CurrTabName_S = "DataBaseType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DataBaseTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"DataBaseTypeId", "DataBaseTypeName", "Memo"};
//以下是属性变量

protected string mstrDataBaseTypeId;    //数据库类型ID
protected string mstrDataBaseTypeName;    //数据库类型名
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"DataBaseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DataBaseTypeId = "DataBaseTypeId";    //数据库类型ID

 /// <summary>
 /// 常量:"DataBaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DataBaseTypeName = "DataBaseTypeName";    //数据库类型名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsDataBaseTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "DataBaseType";
 lstKeyFldNames.Add("DataBaseTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strDataBaseTypeId">关键字:数据库类型ID</param>
public clsDataBaseTypeEN(string strDataBaseTypeId)
 {
strDataBaseTypeId = strDataBaseTypeId.Replace("'", "''");
if (strDataBaseTypeId.Length > 2)
{
throw new Exception("在表:DataBaseType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDataBaseTypeId)  ==  true)
{
throw new Exception("在表:DataBaseType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDataBaseTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDataBaseTypeId = strDataBaseTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "DataBaseType";
 lstKeyFldNames.Add("DataBaseTypeId");
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
if (strAttributeName  ==  con_DataBaseTypeId)
{
return mstrDataBaseTypeId;
}
else if (strAttributeName  ==  con_DataBaseTypeName)
{
return mstrDataBaseTypeName;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_DataBaseTypeId)
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(con_DataBaseTypeId);
}
else if (strAttributeName  ==  con_DataBaseTypeName)
{
mstrDataBaseTypeName = value.ToString();
 AddUpdatedFld(con_DataBaseTypeName);
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
if (con_DataBaseTypeId  ==  AttributeName[intIndex])
{
return mstrDataBaseTypeId;
}
else if (con_DataBaseTypeName  ==  AttributeName[intIndex])
{
return mstrDataBaseTypeName;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_DataBaseTypeId  ==  AttributeName[intIndex])
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(con_DataBaseTypeId);
}
else if (con_DataBaseTypeName  ==  AttributeName[intIndex])
{
mstrDataBaseTypeName = value.ToString();
 AddUpdatedFld(con_DataBaseTypeName);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// 数据库类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseTypeId
{
get
{
return mstrDataBaseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseTypeId = value;
}
else
{
 mstrDataBaseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_DataBaseTypeId);
}
}
/// <summary>
/// 数据库类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseTypeName
{
get
{
return mstrDataBaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseTypeName = value;
}
else
{
 mstrDataBaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_DataBaseTypeName);
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
  return mstrDataBaseTypeId;
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
  return mstrDataBaseTypeName;
 }
 }
}
}