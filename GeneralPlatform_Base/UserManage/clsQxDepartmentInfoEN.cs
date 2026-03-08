
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxDepartmentInfoEN
 表名:QxDepartmentInfo(00140030)
 生成代码版本:2019.07.12.1
 生成日期:2019/07/12 11:03:58
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
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
 /// 表QxDepartmentInfo的关键字(DepartmentId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_DepartmentId_QxDepartmentInfo
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
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
public const string _CurrTabName_S = "QxDepartmentInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "DepartmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"DepartmentId", "DepartmentName", "DepartmentAbbrName", "DepartmentTypeId", "UpDepartmentId", "OrderNum", "InUse", "Memo"};
//以下是属性变量

protected string mstrDepartmentId;    //部门Id
protected string mstrDepartmentName;    //部门名
protected string mstrDepartmentAbbrName;    //名称缩写
protected string mstrDepartmentTypeId;    //部门类型ID
protected string mstrUpDepartmentId;    //所属部门号
protected int mintOrderNum;    //排序号
protected bool mbolInUse;    //是否在用
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentId = "DepartmentId";    //部门Id

 /// <summary>
 /// 常量:"DepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentName = "DepartmentName";    //部门名

 /// <summary>
 /// 常量:"DepartmentAbbrName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentAbbrName = "DepartmentAbbrName";    //名称缩写

 /// <summary>
 /// 常量:"DepartmentTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentTypeId = "DepartmentTypeId";    //部门类型ID

 /// <summary>
 /// 常量:"UpDepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpDepartmentId = "UpDepartmentId";    //所属部门号

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxDepartmentInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxDepartmentInfo";
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
 _CurrTabName = "QxDepartmentInfo";
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
if (strAttributeName  ==  con_DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  con_DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  con_DepartmentAbbrName)
{
return mstrDepartmentAbbrName;
}
else if (strAttributeName  ==  con_DepartmentTypeId)
{
return mstrDepartmentTypeId;
}
else if (strAttributeName  ==  con_UpDepartmentId)
{
return mstrUpDepartmentId;
}
else if (strAttributeName  ==  con_OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  con_InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (strAttributeName  ==  con_DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(con_DepartmentName);
}
else if (strAttributeName  ==  con_DepartmentAbbrName)
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(con_DepartmentAbbrName);
}
else if (strAttributeName  ==  con_DepartmentTypeId)
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(con_DepartmentTypeId);
}
else if (strAttributeName  ==  con_UpDepartmentId)
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(con_UpDepartmentId);
}
else if (strAttributeName  ==  con_OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (strAttributeName  ==  con_InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(con_InUse);
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
if (con_DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (con_DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (con_DepartmentAbbrName  ==  AttributeName[intIndex])
{
return mstrDepartmentAbbrName;
}
else if (con_DepartmentTypeId  ==  AttributeName[intIndex])
{
return mstrDepartmentTypeId;
}
else if (con_UpDepartmentId  ==  AttributeName[intIndex])
{
return mstrUpDepartmentId;
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (con_InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (con_DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(con_DepartmentName);
}
else if (con_DepartmentAbbrName  ==  AttributeName[intIndex])
{
mstrDepartmentAbbrName = value.ToString();
 AddUpdatedFld(con_DepartmentAbbrName);
}
else if (con_DepartmentTypeId  ==  AttributeName[intIndex])
{
mstrDepartmentTypeId = value.ToString();
 AddUpdatedFld(con_DepartmentTypeId);
}
else if (con_UpDepartmentId  ==  AttributeName[intIndex])
{
mstrUpDepartmentId = value.ToString();
 AddUpdatedFld(con_UpDepartmentId);
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (con_InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(con_InUse);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
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
 AddUpdatedFld(con_DepartmentId);
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
 AddUpdatedFld(con_DepartmentName);
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
 AddUpdatedFld(con_DepartmentAbbrName);
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
 AddUpdatedFld(con_DepartmentTypeId);
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
 AddUpdatedFld(con_UpDepartmentId);
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
 AddUpdatedFld(con_InUse);
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
}