
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxDepartmentInfoV2EN
 表名:QxDepartmentInfoV2(00140111)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:27:02
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
 /// 表QxDepartmentInfoV2的关键字(DepartmentIdInt)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DepartmentIdInt_QxDepartmentInfoV2
{
private int _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public int Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="intDepartmentIdInt">表关键字</param>
public K_DepartmentIdInt_QxDepartmentInfoV2(int intDepartmentIdInt)
{
if (IsValid(intDepartmentIdInt)) Value = intDepartmentIdInt;
else
{
Value = 0;
}
}
private static bool IsValid(int intDepartmentIdInt)
{
if (intDepartmentIdInt == 0) return false;
if (intDepartmentIdInt == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DepartmentIdInt_QxDepartmentInfoV2]类型的对象</returns>
public static implicit operator K_DepartmentIdInt_QxDepartmentInfoV2(int value)
{
return new K_DepartmentIdInt_QxDepartmentInfoV2(value);
}
}
 /// <summary>
 /// 部门V2(QxDepartmentInfoV2)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxDepartmentInfoV2EN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxDepartmentInfoV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DepartmentIdInt"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 10;
public static string[] AttributeName = new string[] {"DepartmentIdInt", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "parentDepId", "OrderNum", "InUse", "Memo", "CreateTime", "updateTime"};

protected int mintDepartmentIdInt;    //部门Id
protected string mstrDepartmentName;    //部门名
protected string mstrDepartmentAbbrName;    //名称缩写
protected string mstrDepartmentTypeId;    //部门类型ID
protected int? mintparentDepId;    //所属部门号
protected int? mintOrderNum;    //排序号
protected bool mbolInUse;    //是否在用
protected string mstrMemo;    //备注
protected string mstrCreateTime;    //建立时间
protected string mstrupdateTime;    //修改时间

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxDepartmentInfoV2EN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DepartmentIdInt");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "intDepartmentIdInt">关键字:部门Id</param>
public clsQxDepartmentInfoV2EN(int intDepartmentIdInt)
 {
 if (intDepartmentIdInt  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mintDepartmentIdInt = intDepartmentIdInt;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DepartmentIdInt");
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
if (strAttributeName  ==  conQxDepartmentInfoV2.DepartmentIdInt)
{
return mintDepartmentIdInt;
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.DepartmentAbbrName)
{
return mstrDepartmentAbbrName;
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.DepartmentTypeId)
{
return mstrDepartmentTypeId;
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.parentDepId)
{
return mintparentDepId;
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.CreateTime)
{
return mstrCreateTime;
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.updateTime)
{
return mstrupdateTime;
}
return null;
}
set
{
if (strAttributeName  ==  conQxDepartmentInfoV2.DepartmentIdInt)
{
mintDepartmentIdInt = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxDepartmentInfoV2.DepartmentIdInt);
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(conQxDepartmentInfoV2.DepartmentName);
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.DepartmentAbbrName)
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(conQxDepartmentInfoV2.DepartmentAbbrName);
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.DepartmentTypeId)
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(conQxDepartmentInfoV2.DepartmentTypeId);
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.parentDepId)
{
mintparentDepId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxDepartmentInfoV2.parentDepId);
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxDepartmentInfoV2.OrderNum);
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxDepartmentInfoV2.InUse);
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxDepartmentInfoV2.Memo);
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.CreateTime)
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(conQxDepartmentInfoV2.CreateTime);
}
else if (strAttributeName  ==  conQxDepartmentInfoV2.updateTime)
{
mstrupdateTime = value.ToString();
 AddUpdatedFld(conQxDepartmentInfoV2.updateTime);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxDepartmentInfoV2.DepartmentIdInt  ==  AttributeName[intIndex])
{
return mintDepartmentIdInt;
}
else if (conQxDepartmentInfoV2.DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (conQxDepartmentInfoV2.DepartmentAbbrName  ==  AttributeName[intIndex])
{
return mstrDepartmentAbbrName;
}
else if (conQxDepartmentInfoV2.DepartmentTypeId  ==  AttributeName[intIndex])
{
return mstrDepartmentTypeId;
}
else if (conQxDepartmentInfoV2.parentDepId  ==  AttributeName[intIndex])
{
return mintparentDepId;
}
else if (conQxDepartmentInfoV2.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conQxDepartmentInfoV2.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (conQxDepartmentInfoV2.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conQxDepartmentInfoV2.CreateTime  ==  AttributeName[intIndex])
{
return mstrCreateTime;
}
else if (conQxDepartmentInfoV2.updateTime  ==  AttributeName[intIndex])
{
return mstrupdateTime;
}
return null;
}
set
{
if (conQxDepartmentInfoV2.DepartmentIdInt  ==  AttributeName[intIndex])
{
mintDepartmentIdInt = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxDepartmentInfoV2.DepartmentIdInt);
}
else if (conQxDepartmentInfoV2.DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(conQxDepartmentInfoV2.DepartmentName);
}
else if (conQxDepartmentInfoV2.DepartmentAbbrName  ==  AttributeName[intIndex])
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(conQxDepartmentInfoV2.DepartmentAbbrName);
}
else if (conQxDepartmentInfoV2.DepartmentTypeId  ==  AttributeName[intIndex])
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(conQxDepartmentInfoV2.DepartmentTypeId);
}
else if (conQxDepartmentInfoV2.parentDepId  ==  AttributeName[intIndex])
{
mintparentDepId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxDepartmentInfoV2.parentDepId);
}
else if (conQxDepartmentInfoV2.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxDepartmentInfoV2.OrderNum);
}
else if (conQxDepartmentInfoV2.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxDepartmentInfoV2.InUse);
}
else if (conQxDepartmentInfoV2.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxDepartmentInfoV2.Memo);
}
else if (conQxDepartmentInfoV2.CreateTime  ==  AttributeName[intIndex])
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(conQxDepartmentInfoV2.CreateTime);
}
else if (conQxDepartmentInfoV2.updateTime  ==  AttributeName[intIndex])
{
mstrupdateTime = value.ToString();
 AddUpdatedFld(conQxDepartmentInfoV2.updateTime);
}
}
}

/// <summary>
/// 部门Id(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int DepartmentIdInt
{
get
{
return mintDepartmentIdInt;
}
set
{
 mintDepartmentIdInt = value;
//记录修改过的字段
 AddUpdatedFld(conQxDepartmentInfoV2.DepartmentIdInt);
}
}
/// <summary>
/// 部门名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentName
{
get
{
return mstrDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentName = value;
}
else
{
 mstrDepartmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxDepartmentInfoV2.DepartmentName);
}
}
/// <summary>
/// 名称缩写(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentAbbrName
{
get
{
return mstrDepartmentAbbrName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentAbbrName = value;
}
else
{
 mstrDepartmentAbbrName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxDepartmentInfoV2.DepartmentAbbrName);
}
}
/// <summary>
/// 部门类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentTypeId
{
get
{
return mstrDepartmentTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentTypeId = value;
}
else
{
 mstrDepartmentTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxDepartmentInfoV2.DepartmentTypeId);
}
}
/// <summary>
/// 所属部门号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? parentDepId
{
get
{
return mintparentDepId;
}
set
{
 mintparentDepId = value;
//记录修改过的字段
 AddUpdatedFld(conQxDepartmentInfoV2.parentDepId);
}
}
/// <summary>
/// 排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conQxDepartmentInfoV2.OrderNum);
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
 AddUpdatedFld(conQxDepartmentInfoV2.InUse);
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
 AddUpdatedFld(conQxDepartmentInfoV2.Memo);
}
}
/// <summary>
/// 建立时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateTime
{
get
{
return mstrCreateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateTime = value;
}
else
{
 mstrCreateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxDepartmentInfoV2.CreateTime);
}
}
/// <summary>
/// 修改时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string updateTime
{
get
{
return mstrupdateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrupdateTime = value;
}
else
{
 mstrupdateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxDepartmentInfoV2.updateTime);
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
  return mintDepartmentIdInt.ToString();
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
  return mstrDepartmentName;
 }
 }
}
 /// <summary>
 /// 部门V2(QxDepartmentInfoV2)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxDepartmentInfoV2
{
public const string _CurrTabName = "QxDepartmentInfoV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DepartmentIdInt"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"DepartmentIdInt", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "parentDepId", "OrderNum", "InUse", "Memo", "CreateTime", "updateTime"};
//以下是属性变量


 /// <summary>
 /// 常量:"DepartmentIdInt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentIdInt = "DepartmentIdInt";    //部门Id

 /// <summary>
 /// 常量:"DepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentName = "DepartmentName";    //部门名

 /// <summary>
 /// 常量:"DepartmentAbbrName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentAbbrName = "DepartmentAbbrName";    //名称缩写

 /// <summary>
 /// 常量:"DepartmentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentTypeId = "DepartmentTypeId";    //部门类型ID

 /// <summary>
 /// 常量:"parentDepId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string parentDepId = "parentDepId";    //所属部门号

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"CreateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateTime = "CreateTime";    //建立时间

 /// <summary>
 /// 常量:"updateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string updateTime = "updateTime";    //修改时间
}

}