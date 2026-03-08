
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzSchoolEN
 表名:XzSchool(00140071)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 10:01:28
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置
 模块英文名:SystemSet
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
 /// 表XzSchool的关键字(id_School)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_id_School_XzSchool
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strid_School">表关键字</param>
public K_id_School_XzSchool(string strid_School)
{
if (IsValid(strid_School)) Value = strid_School;
else
{
Value = null;
}
}
private static bool IsValid(string strid_School)
{
if (string.IsNullOrEmpty(strid_School) == true) return false;
if (strid_School.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_id_School_XzSchool]类型的对象</returns>
public static implicit operator K_id_School_XzSchool(string value)
{
return new K_id_School_XzSchool(value);
}
}
 /// <summary>
 /// 学校(XzSchool)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzSchoolEN : clsEntityBase2
{
public const string _CurrTabName_S = "XzSchool"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "id_School"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"id_School", "SchoolId", "SchoolName", "IsCurrentUse", "Memo", "SchoolNameA", "UpdDate", "UpdUserId"};
//以下是属性变量

protected string mstrid_School;    //学校流水号
protected string mstrSchoolId;    //学校Id
protected string mstrSchoolName;    //学校名称
protected bool mbolIsCurrentUse;    //是否当前使用
protected string mstrMemo;    //备注
protected string mstrSchoolNameA;    //SchoolNameA
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id


 /// <summary>
 /// 常量:"id_School"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_School = "id_School";    //学校流水号

 /// <summary>
 /// 常量:"SchoolId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SchoolId = "SchoolId";    //学校Id

 /// <summary>
 /// 常量:"SchoolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SchoolName = "SchoolName";    //学校名称

 /// <summary>
 /// 常量:"IsCurrentUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsCurrentUse = "IsCurrentUse";    //是否当前使用

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"SchoolNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SchoolNameA = "SchoolNameA";    //SchoolNameA

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUserId = "UpdUserId";    //修改用户Id

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzSchoolEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "XzSchool";
 lstKeyFldNames.Add("id_School");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strid_School">关键字:学校流水号</param>
public clsXzSchoolEN(string strid_School)
 {
strid_School = strid_School.Replace("'", "''");
if (strid_School.Length > 4)
{
throw new Exception("在表:XzSchool中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strid_School)  ==  true)
{
throw new Exception("在表:XzSchool中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strid_School);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrid_School = strid_School;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "XzSchool";
 lstKeyFldNames.Add("id_School");
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
if (strAttributeName  ==  con_id_School)
{
return mstrid_School;
}
else if (strAttributeName  ==  con_SchoolId)
{
return mstrSchoolId;
}
else if (strAttributeName  ==  con_SchoolName)
{
return mstrSchoolName;
}
else if (strAttributeName  ==  con_IsCurrentUse)
{
return mbolIsCurrentUse;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  con_SchoolNameA)
{
return mstrSchoolNameA;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_UpdUserId)
{
return mstrUpdUserId;
}
return null;
}
set
{
if (strAttributeName  ==  con_id_School)
{
mstrid_School = value.ToString();
 AddUpdatedFld(con_id_School);
}
else if (strAttributeName  ==  con_SchoolId)
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(con_SchoolId);
}
else if (strAttributeName  ==  con_SchoolName)
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(con_SchoolName);
}
else if (strAttributeName  ==  con_IsCurrentUse)
{
mbolIsCurrentUse = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsCurrentUse);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName  ==  con_SchoolNameA)
{
mstrSchoolNameA = value.ToString();
 AddUpdatedFld(con_SchoolNameA);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
}
}
public object this[int intIndex]
{
get
{
if (con_id_School  ==  AttributeName[intIndex])
{
return mstrid_School;
}
else if (con_SchoolId  ==  AttributeName[intIndex])
{
return mstrSchoolId;
}
else if (con_SchoolName  ==  AttributeName[intIndex])
{
return mstrSchoolName;
}
else if (con_IsCurrentUse  ==  AttributeName[intIndex])
{
return mbolIsCurrentUse;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (con_SchoolNameA  ==  AttributeName[intIndex])
{
return mstrSchoolNameA;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
return null;
}
set
{
if (con_id_School  ==  AttributeName[intIndex])
{
mstrid_School = value.ToString();
 AddUpdatedFld(con_id_School);
}
else if (con_SchoolId  ==  AttributeName[intIndex])
{
mstrSchoolId = value.ToString();
 AddUpdatedFld(con_SchoolId);
}
else if (con_SchoolName  ==  AttributeName[intIndex])
{
mstrSchoolName = value.ToString();
 AddUpdatedFld(con_SchoolName);
}
else if (con_IsCurrentUse  ==  AttributeName[intIndex])
{
mbolIsCurrentUse = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsCurrentUse);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_SchoolNameA  ==  AttributeName[intIndex])
{
mstrSchoolNameA = value.ToString();
 AddUpdatedFld(con_SchoolNameA);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
}
}

/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_School
{
get
{
return mstrid_School;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_School = value;
}
else
{
 mstrid_School = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_School);
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
 AddUpdatedFld(con_SchoolId);
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
 AddUpdatedFld(con_SchoolName);
}
}
/// <summary>
/// 是否当前使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCurrentUse
{
get
{
return mbolIsCurrentUse;
}
set
{
 mbolIsCurrentUse = value;
//记录修改过的字段
 AddUpdatedFld(con_IsCurrentUse);
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
/// SchoolNameA(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolNameA
{
get
{
return mstrSchoolNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolNameA = value;
}
else
{
 mstrSchoolNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SchoolNameA);
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
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrid_School;
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
  return mstrSchoolName;
 }
 }
}
}