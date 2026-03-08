
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxApplicationTypeEN
 表名:QxApplicationType(00140088)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 09:59:27
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数
 模块英文名:SysPara
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
 /// 表QxApplicationType的关键字(ApplicationTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_ApplicationTypeId_QxApplicationType
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public int Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="intApplicationTypeId">表关键字</param>
public K_ApplicationTypeId_QxApplicationType(int intApplicationTypeId)
{
if (IsValid(intApplicationTypeId)) Value = intApplicationTypeId;
else
{
Value = 0;
}
}
private static bool IsValid(int intApplicationTypeId)
{
if (intApplicationTypeId == 0) return false;
if (intApplicationTypeId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ApplicationTypeId_QxApplicationType]类型的对象</returns>
public static implicit operator K_ApplicationTypeId_QxApplicationType(int value)
{
return new K_ApplicationTypeId_QxApplicationType(value);
}
}
 /// <summary>
 /// 应用程序类型(QxApplicationType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxApplicationTypeEN : clsEntityBase2
{
public const string _CurrTabName_S = "QxApplicationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ApplicationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeENName", "ProgLangTypeId", "ProgLangTypeId2", "ProgLangTypeId3", "ProgLangTypeId4", "ProgLangTypeId5", "IsVisible", "OrderNum", "Memo"};
//以下是属性变量

protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrApplicationTypeENName;    //应用类型英文名
protected string mstrProgLangTypeId;    //编程语言类型Id
protected string mstrProgLangTypeId2;    //编程语言类型Id2
protected string mstrProgLangTypeId3;    //编程语言类型Id3
protected string mstrProgLangTypeId4;    //编程语言类型Id4
protected string mstrProgLangTypeId5;    //编程语言类型Id5
protected bool mbolIsVisible;    //是否显示
protected int mintOrderNum;    //排序号
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"ApplicationTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ApplicationTypeENName = "ApplicationTypeENName";    //应用类型英文名

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"ProgLangTypeId2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ProgLangTypeId2 = "ProgLangTypeId2";    //编程语言类型Id2

 /// <summary>
 /// 常量:"ProgLangTypeId3"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ProgLangTypeId3 = "ProgLangTypeId3";    //编程语言类型Id3

 /// <summary>
 /// 常量:"ProgLangTypeId4"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ProgLangTypeId4 = "ProgLangTypeId4";    //编程语言类型Id4

 /// <summary>
 /// 常量:"ProgLangTypeId5"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ProgLangTypeId5 = "ProgLangTypeId5";    //编程语言类型Id5

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxApplicationTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxApplicationType";
 lstKeyFldNames.Add("ApplicationTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "intApplicationTypeId">关键字:应用程序类型ID</param>
public clsQxApplicationTypeEN(int intApplicationTypeId)
 {
 if (intApplicationTypeId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mintApplicationTypeId = intApplicationTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxApplicationType";
 lstKeyFldNames.Add("ApplicationTypeId");
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
if (strAttributeName  ==  con_ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  con_ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  con_ApplicationTypeENName)
{
return mstrApplicationTypeENName;
}
else if (strAttributeName  ==  con_ProgLangTypeId)
{
return mstrProgLangTypeId;
}
else if (strAttributeName  ==  con_ProgLangTypeId2)
{
return mstrProgLangTypeId2;
}
else if (strAttributeName  ==  con_ProgLangTypeId3)
{
return mstrProgLangTypeId3;
}
else if (strAttributeName  ==  con_ProgLangTypeId4)
{
return mstrProgLangTypeId4;
}
else if (strAttributeName  ==  con_ProgLangTypeId5)
{
return mstrProgLangTypeId5;
}
else if (strAttributeName  ==  con_IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  con_OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ApplicationTypeId);
}
else if (strAttributeName  ==  con_ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(con_ApplicationTypeName);
}
else if (strAttributeName  ==  con_ApplicationTypeENName)
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(con_ApplicationTypeENName);
}
else if (strAttributeName  ==  con_ProgLangTypeId)
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(con_ProgLangTypeId);
}
else if (strAttributeName  ==  con_ProgLangTypeId2)
{
mstrProgLangTypeId2 = value.ToString();
 AddUpdatedFld(con_ProgLangTypeId2);
}
else if (strAttributeName  ==  con_ProgLangTypeId3)
{
mstrProgLangTypeId3 = value.ToString();
 AddUpdatedFld(con_ProgLangTypeId3);
}
else if (strAttributeName  ==  con_ProgLangTypeId4)
{
mstrProgLangTypeId4 = value.ToString();
 AddUpdatedFld(con_ProgLangTypeId4);
}
else if (strAttributeName  ==  con_ProgLangTypeId5)
{
mstrProgLangTypeId5 = value.ToString();
 AddUpdatedFld(con_ProgLangTypeId5);
}
else if (strAttributeName  ==  con_IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsVisible);
}
else if (strAttributeName  ==  con_OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
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
if (con_ApplicationTypeId  ==  AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (con_ApplicationTypeName  ==  AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (con_ApplicationTypeENName  ==  AttributeName[intIndex])
{
return mstrApplicationTypeENName;
}
else if (con_ProgLangTypeId  ==  AttributeName[intIndex])
{
return mstrProgLangTypeId;
}
else if (con_ProgLangTypeId2  ==  AttributeName[intIndex])
{
return mstrProgLangTypeId2;
}
else if (con_ProgLangTypeId3  ==  AttributeName[intIndex])
{
return mstrProgLangTypeId3;
}
else if (con_ProgLangTypeId4  ==  AttributeName[intIndex])
{
return mstrProgLangTypeId4;
}
else if (con_ProgLangTypeId5  ==  AttributeName[intIndex])
{
return mstrProgLangTypeId5;
}
else if (con_IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_ApplicationTypeId  ==  AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ApplicationTypeId);
}
else if (con_ApplicationTypeName  ==  AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(con_ApplicationTypeName);
}
else if (con_ApplicationTypeENName  ==  AttributeName[intIndex])
{
mstrApplicationTypeENName = value.ToString();
 AddUpdatedFld(con_ApplicationTypeENName);
}
else if (con_ProgLangTypeId  ==  AttributeName[intIndex])
{
mstrProgLangTypeId = value.ToString();
 AddUpdatedFld(con_ProgLangTypeId);
}
else if (con_ProgLangTypeId2  ==  AttributeName[intIndex])
{
mstrProgLangTypeId2 = value.ToString();
 AddUpdatedFld(con_ProgLangTypeId2);
}
else if (con_ProgLangTypeId3  ==  AttributeName[intIndex])
{
mstrProgLangTypeId3 = value.ToString();
 AddUpdatedFld(con_ProgLangTypeId3);
}
else if (con_ProgLangTypeId4  ==  AttributeName[intIndex])
{
mstrProgLangTypeId4 = value.ToString();
 AddUpdatedFld(con_ProgLangTypeId4);
}
else if (con_ProgLangTypeId5  ==  AttributeName[intIndex])
{
mstrProgLangTypeId5 = value.ToString();
 AddUpdatedFld(con_ProgLangTypeId5);
}
else if (con_IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsVisible);
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(con_ApplicationTypeId);
}
}
/// <summary>
/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeName
{
get
{
return mstrApplicationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeName = value;
}
else
{
 mstrApplicationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ApplicationTypeName);
}
}
/// <summary>
/// 应用类型英文名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeENName
{
get
{
return mstrApplicationTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeENName = value;
}
else
{
 mstrApplicationTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ApplicationTypeENName);
}
}
/// <summary>
/// 编程语言类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId
{
get
{
return mstrProgLangTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId = value;
}
else
{
 mstrProgLangTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ProgLangTypeId);
}
}
/// <summary>
/// 编程语言类型Id2(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId2
{
get
{
return mstrProgLangTypeId2;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId2 = value;
}
else
{
 mstrProgLangTypeId2 = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ProgLangTypeId2);
}
}
/// <summary>
/// 编程语言类型Id3(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId3
{
get
{
return mstrProgLangTypeId3;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId3 = value;
}
else
{
 mstrProgLangTypeId3 = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ProgLangTypeId3);
}
}
/// <summary>
/// 编程语言类型Id4(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId4
{
get
{
return mstrProgLangTypeId4;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId4 = value;
}
else
{
 mstrProgLangTypeId4 = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ProgLangTypeId4);
}
}
/// <summary>
/// 编程语言类型Id5(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ProgLangTypeId5
{
get
{
return mstrProgLangTypeId5;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrProgLangTypeId5 = value;
}
else
{
 mstrProgLangTypeId5 = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ProgLangTypeId5);
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
 AddUpdatedFld(con_IsVisible);
}
}
/// <summary>
/// 排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(con_OrderNum);
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
  return mintApplicationTypeId.ToString();
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
  return mstrApplicationTypeName;
 }
 }
}
}