
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxCodeTypeEN
 表名:QxCodeType(00140057)
 生成代码版本:2019.07.12.1
 生成日期:2019/07/12 10:48:27
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:工程文件下载
 模块英文名:PrjFileDownLoad
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
 /// 表QxCodeType的关键字(QxCodeTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_QxCodeTypeId_QxCodeType
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strQxCodeTypeId">表关键字</param>
public K_QxCodeTypeId_QxCodeType(string strQxCodeTypeId)
{
if (IsValid(strQxCodeTypeId)) Value = strQxCodeTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strQxCodeTypeId)
{
if (string.IsNullOrEmpty(strQxCodeTypeId) == true) return false;
if (strQxCodeTypeId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QxCodeTypeId_QxCodeType]类型的对象</returns>
public static implicit operator K_QxCodeTypeId_QxCodeType(string value)
{
return new K_QxCodeTypeId_QxCodeType(value);
}
}
 /// <summary>
 /// 代码类型(QxCodeType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxCodeTypeEN : clsEntityBase2
{
public const string _CurrTabName_S = "QxCodeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QxCodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"QxCodeTypeId", "CodeTypeName", "Memo"};
//以下是属性变量

protected string mstrQxCodeTypeId;    //代码类型Id
protected string mstrCodeTypeName;    //代码类型名
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"QxCodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QxCodeTypeId = "QxCodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"CodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CodeTypeName = "CodeTypeName";    //代码类型名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxCodeTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxCodeType";
 lstKeyFldNames.Add("QxCodeTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strQxCodeTypeId">关键字:代码类型Id</param>
public clsQxCodeTypeEN(string strQxCodeTypeId)
 {
strQxCodeTypeId = strQxCodeTypeId.Replace("'", "''");
if (strQxCodeTypeId.Length > 4)
{
throw new Exception("在表:QxCodeType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQxCodeTypeId)  ==  true)
{
throw new Exception("在表:QxCodeType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQxCodeTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrQxCodeTypeId = strQxCodeTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxCodeType";
 lstKeyFldNames.Add("QxCodeTypeId");
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
if (strAttributeName  ==  con_QxCodeTypeId)
{
return mstrQxCodeTypeId;
}
else if (strAttributeName  ==  con_CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_QxCodeTypeId)
{
mstrQxCodeTypeId = value.ToString();
 AddUpdatedFld(con_QxCodeTypeId);
}
else if (strAttributeName  ==  con_CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(con_CodeTypeName);
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
if (con_QxCodeTypeId  ==  AttributeName[intIndex])
{
return mstrQxCodeTypeId;
}
else if (con_CodeTypeName  ==  AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_QxCodeTypeId  ==  AttributeName[intIndex])
{
mstrQxCodeTypeId = value.ToString();
 AddUpdatedFld(con_QxCodeTypeId);
}
else if (con_CodeTypeName  ==  AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(con_CodeTypeName);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// 代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QxCodeTypeId
{
get
{
return mstrQxCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQxCodeTypeId = value;
}
else
{
 mstrQxCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_QxCodeTypeId);
}
}
/// <summary>
/// 代码类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeName
{
get
{
return mstrCodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeName = value;
}
else
{
 mstrCodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_CodeTypeName);
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
  return mstrQxCodeTypeId;
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
  return mstrCodeTypeName;
 }
 }
}
}