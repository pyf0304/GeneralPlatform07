
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSetFieldVisibilityEN
 表名:vSetFieldVisibility(00140070)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:24:41
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:系统设置(SystemSet)
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
 /// 表vSetFieldVisibility的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vSetFieldVisibility
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vSetFieldVisibility(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vSetFieldVisibility]类型的对象</returns>
public static implicit operator K_mId_vSetFieldVisibility(long value)
{
return new K_mId_vSetFieldVisibility(value);
}
}
 /// <summary>
 /// v设置字段可视性(vSetFieldVisibility)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSetFieldVisibilityEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSetFieldVisibility"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "IdSchool", "SchoolId", "SchoolName", "ViewName", "CtrlType", "FieldName", "IsVisible", "Memo"};

protected long mlngmId;    //流水号
protected string mstrIdSchool;    //学校流水号
protected string mstrSchoolId;    //学校Id
protected string mstrSchoolName;    //学校名称
protected string mstrViewName;    //界面名称
protected string mstrCtrlType;    //控件类型
protected string mstrFieldName;    //字段名
protected bool mbolIsVisible;    //是否显示
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSetFieldVisibilityEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:流水号</param>
public clsvSetFieldVisibilityEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convSetFieldVisibility.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convSetFieldVisibility.IdSchool)
{
return mstrIdSchool;
}
else if (strAttributeName  ==  convSetFieldVisibility.SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  convSetFieldVisibility.SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  convSetFieldVisibility.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  convSetFieldVisibility.CtrlType)
{
return mstrCtrlType;
}
else if (strAttributeName  ==  convSetFieldVisibility.FieldName)
{
return mstrFieldName;
}
else if (strAttributeName  ==  convSetFieldVisibility.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  convSetFieldVisibility.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convSetFieldVisibility.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convSetFieldVisibility.mId);
}
else if (strAttributeName  ==  convSetFieldVisibility.IdSchool)
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.IdSchool);
}
else if (strAttributeName  ==  convSetFieldVisibility.SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.SchoolId);
}
else if (strAttributeName  ==  convSetFieldVisibility.SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.SchoolName);
}
else if (strAttributeName  ==  convSetFieldVisibility.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.ViewName);
}
else if (strAttributeName  ==  convSetFieldVisibility.CtrlType)
{
mstrCtrlType = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.CtrlType);
}
else if (strAttributeName  ==  convSetFieldVisibility.FieldName)
{
mstrFieldName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.FieldName);
}
else if (strAttributeName  ==  convSetFieldVisibility.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convSetFieldVisibility.IsVisible);
}
else if (strAttributeName  ==  convSetFieldVisibility.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convSetFieldVisibility.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convSetFieldVisibility.IdSchool  ==  AttributeName[intIndex])
{
return mstrIdSchool;
}
else if (convSetFieldVisibility.SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (convSetFieldVisibility.SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (convSetFieldVisibility.ViewName  ==  AttributeName[intIndex])
{
return mstrViewName;
}
else if (convSetFieldVisibility.CtrlType  ==  AttributeName[intIndex])
{
return mstrCtrlType;
}
else if (convSetFieldVisibility.FieldName  ==  AttributeName[intIndex])
{
return mstrFieldName;
}
else if (convSetFieldVisibility.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (convSetFieldVisibility.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convSetFieldVisibility.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convSetFieldVisibility.mId);
}
else if (convSetFieldVisibility.IdSchool  ==  AttributeName[intIndex])
{
mstrIdSchool = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.IdSchool);
}
else if (convSetFieldVisibility.SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.SchoolId);
}
else if (convSetFieldVisibility.SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.SchoolName);
}
else if (convSetFieldVisibility.ViewName  ==  AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.ViewName);
}
else if (convSetFieldVisibility.CtrlType  ==  AttributeName[intIndex])
{
mstrCtrlType = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.CtrlType);
}
else if (convSetFieldVisibility.FieldName  ==  AttributeName[intIndex])
{
mstrFieldName = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.FieldName);
}
else if (convSetFieldVisibility.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(convSetFieldVisibility.IsVisible);
}
else if (convSetFieldVisibility.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSetFieldVisibility.Memo);
}
}
}

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(convSetFieldVisibility.mId);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdSchool
{
get
{
return mstrIdSchool;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdSchool = value;
}
else
{
 mstrIdSchool = value;
}
//记录修改过的字段
 AddUpdatedFld(convSetFieldVisibility.IdSchool);
}
}
/// <summary>
/// 学校Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolId
{
get
{
return mstrSchoolId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolId = value;
}
else
{
 mstrSchoolId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSetFieldVisibility.SchoolId);
}
}
/// <summary>
/// 学校名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolName
{
get
{
return mstrSchoolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolName = value;
}
else
{
 mstrSchoolName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSetFieldVisibility.SchoolName);
}
}
/// <summary>
/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewName
{
get
{
return mstrViewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewName = value;
}
else
{
 mstrViewName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSetFieldVisibility.ViewName);
}
}
/// <summary>
/// 控件类型(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CtrlType
{
get
{
return mstrCtrlType;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCtrlType = value;
}
else
{
 mstrCtrlType = value;
}
//记录修改过的字段
 AddUpdatedFld(convSetFieldVisibility.CtrlType);
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FieldName
{
get
{
return mstrFieldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldName = value;
}
else
{
 mstrFieldName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSetFieldVisibility.FieldName);
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
 AddUpdatedFld(convSetFieldVisibility.IsVisible);
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
 AddUpdatedFld(convSetFieldVisibility.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// v设置字段可视性(vSetFieldVisibility)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSetFieldVisibility
{
public const string _CurrTabName = "vSetFieldVisibility"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "IdSchool", "SchoolId", "SchoolName", "ViewName", "CtrlType", "FieldName", "IsVisible", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //流水号

 /// <summary>
 /// 常量:"IdSchool"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdSchool = "IdSchool";    //学校流水号

 /// <summary>
 /// 常量:"SchoolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolId = "SchoolId";    //学校Id

 /// <summary>
 /// 常量:"SchoolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolName = "SchoolName";    //学校名称

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"CtrlType"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CtrlType = "CtrlType";    //控件类型

 /// <summary>
 /// 常量:"FieldName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FieldName = "FieldName";    //字段名

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}