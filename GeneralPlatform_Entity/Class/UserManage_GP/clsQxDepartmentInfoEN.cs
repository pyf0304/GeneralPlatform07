
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxDepartmentInfoEN
 表名:QxDepartmentInfo(00140030)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:26:50
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
 /// 表QxDepartmentInfo的关键字(DepartmentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_DepartmentId_QxDepartmentInfo
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strDepartmentId">表关键字</param>
public K_DepartmentId_QxDepartmentInfo(string strDepartmentId)
{
if (IsValid(strDepartmentId)) Value = strDepartmentId;
else
{
Value = null;
}
}
private static bool IsValid(string strDepartmentId)
{
if (string.IsNullOrEmpty(strDepartmentId) == true) return false;
if (strDepartmentId.Length > 8) return false;
if (strDepartmentId.IndexOf(' ') >= 0) return false;
if (strDepartmentId.IndexOf(')') >= 0) return false;
if (strDepartmentId.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_DepartmentId_QxDepartmentInfo]类型的对象</returns>
public static implicit operator K_DepartmentId_QxDepartmentInfo(string value)
{
return new K_DepartmentId_QxDepartmentInfo(value);
}
}
 /// <summary>
 /// 部门(QxDepartmentInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxDepartmentInfoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxDepartmentInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "DepartmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"DepartmentId", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "UpDepartmentId", "OrderNum", "InUse", "Memo"};

protected string mstrDepartmentId;    //部门Id
protected string mstrDepartmentName;    //部门名
protected string mstrDepartmentAbbrName;    //名称缩写
protected string mstrDepartmentTypeId;    //部门类型ID
protected string mstrUpDepartmentId;    //所属部门号
protected int? mintOrderNum;    //排序号
protected bool mbolInUse;    //是否在用
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxDepartmentInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DepartmentId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strDepartmentId">关键字:部门Id</param>
public clsQxDepartmentInfoEN(string strDepartmentId)
 {
strDepartmentId = strDepartmentId.Replace("'", "''");
if (strDepartmentId.Length > 8)
{
throw new Exception("在表:QxDepartmentInfo中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strDepartmentId)  ==  true)
{
throw new Exception("在表:QxDepartmentInfo中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDepartmentId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrDepartmentId = strDepartmentId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("DepartmentId");
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
if (strAttributeName  ==  conQxDepartmentInfo.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  conQxDepartmentInfo.DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  conQxDepartmentInfo.DepartmentAbbrName)
{
return mstrDepartmentAbbrName;
}
else if (strAttributeName  ==  conQxDepartmentInfo.DepartmentTypeId)
{
return mstrDepartmentTypeId;
}
else if (strAttributeName  ==  conQxDepartmentInfo.UpDepartmentId)
{
return mstrUpDepartmentId;
}
else if (strAttributeName  ==  conQxDepartmentInfo.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conQxDepartmentInfo.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conQxDepartmentInfo.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxDepartmentInfo.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(conQxDepartmentInfo.DepartmentId);
}
else if (strAttributeName  ==  conQxDepartmentInfo.DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(conQxDepartmentInfo.DepartmentName);
}
else if (strAttributeName  ==  conQxDepartmentInfo.DepartmentAbbrName)
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(conQxDepartmentInfo.DepartmentAbbrName);
}
else if (strAttributeName  ==  conQxDepartmentInfo.DepartmentTypeId)
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(conQxDepartmentInfo.DepartmentTypeId);
}
else if (strAttributeName  ==  conQxDepartmentInfo.UpDepartmentId)
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(conQxDepartmentInfo.UpDepartmentId);
}
else if (strAttributeName  ==  conQxDepartmentInfo.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxDepartmentInfo.OrderNum);
}
else if (strAttributeName  ==  conQxDepartmentInfo.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxDepartmentInfo.InUse);
}
else if (strAttributeName  ==  conQxDepartmentInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxDepartmentInfo.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxDepartmentInfo.DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (conQxDepartmentInfo.DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (conQxDepartmentInfo.DepartmentAbbrName  ==  AttributeName[intIndex])
{
return mstrDepartmentAbbrName;
}
else if (conQxDepartmentInfo.DepartmentTypeId  ==  AttributeName[intIndex])
{
return mstrDepartmentTypeId;
}
else if (conQxDepartmentInfo.UpDepartmentId  ==  AttributeName[intIndex])
{
return mstrUpDepartmentId;
}
else if (conQxDepartmentInfo.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conQxDepartmentInfo.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (conQxDepartmentInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxDepartmentInfo.DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(conQxDepartmentInfo.DepartmentId);
}
else if (conQxDepartmentInfo.DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(conQxDepartmentInfo.DepartmentName);
}
else if (conQxDepartmentInfo.DepartmentAbbrName  ==  AttributeName[intIndex])
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(conQxDepartmentInfo.DepartmentAbbrName);
}
else if (conQxDepartmentInfo.DepartmentTypeId  ==  AttributeName[intIndex])
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(conQxDepartmentInfo.DepartmentTypeId);
}
else if (conQxDepartmentInfo.UpDepartmentId  ==  AttributeName[intIndex])
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(conQxDepartmentInfo.UpDepartmentId);
}
else if (conQxDepartmentInfo.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxDepartmentInfo.OrderNum);
}
else if (conQxDepartmentInfo.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxDepartmentInfo.InUse);
}
else if (conQxDepartmentInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxDepartmentInfo.Memo);
}
}
}

/// <summary>
/// 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentId
{
get
{
return mstrDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentId = value;
}
else
{
 mstrDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxDepartmentInfo.DepartmentId);
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
 AddUpdatedFld(conQxDepartmentInfo.DepartmentName);
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
 AddUpdatedFld(conQxDepartmentInfo.DepartmentAbbrName);
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
 AddUpdatedFld(conQxDepartmentInfo.DepartmentTypeId);
}
}
/// <summary>
/// 所属部门号(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpDepartmentId
{
get
{
return mstrUpDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpDepartmentId = value;
}
else
{
 mstrUpDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxDepartmentInfo.UpDepartmentId);
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
 AddUpdatedFld(conQxDepartmentInfo.OrderNum);
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
 AddUpdatedFld(conQxDepartmentInfo.InUse);
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
 AddUpdatedFld(conQxDepartmentInfo.Memo);
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
  return mstrDepartmentId;
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
 /// 部门(QxDepartmentInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxDepartmentInfo
{
public const string _CurrTabName = "QxDepartmentInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DepartmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"DepartmentId", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "UpDepartmentId", "OrderNum", "InUse", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentId = "DepartmentId";    //部门Id

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
 /// 常量:"UpDepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpDepartmentId = "UpDepartmentId";    //所属部门号

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
}

}