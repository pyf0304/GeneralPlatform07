
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzGradeBaseEN
 表名:XzGradeBase(00140043)
 * 版本:2024.02.03.1(服务器:WIN-SRV103-116)
 日期:2024/02/18 11:39:51
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
 /// 表XzGradeBase的关键字(IdGradeBase)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_IdGradeBase_XzGradeBase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdGradeBase">表关键字</param>
public K_IdGradeBase_XzGradeBase(string strIdGradeBase)
{
if (IsValid(strIdGradeBase)) Value = strIdGradeBase;
else
{
Value = null;
}
}
private static bool IsValid(string strIdGradeBase)
{
if (string.IsNullOrEmpty(strIdGradeBase) == true) return false;
if (strIdGradeBase.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdGradeBase_XzGradeBase]类型的对象</returns>
public static implicit operator K_IdGradeBase_XzGradeBase(string value)
{
return new K_IdGradeBase_XzGradeBase(value);
}
}
 /// <summary>
 /// 年级(XzGradeBase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsXzGradeBaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "XzGradeBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "IdGradeBase"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 22;
public static string[] AttributeName = new string[] {"IdGradeBase", "GradeBaseId", "GradeBaseName", "SchoolYear", "SchoolTerm", "EnterSchoolDate", "CurrentTermSeq", "ExecPlanTermIndex", "SetEPTermIndexDate", "IsOffed", "ModifyDate", "ModifyUserId", "GradeIndex", "BeginYearMonth", "EndYearMonth", "AllowUpBaseInfo", "GradeBaseNameA", "IsVisible", "IdStudyLevel", "PointCalcVersionId", "Prefix", "Memo"};

protected string mstrIdGradeBase;    //年级流水号
protected string mstrGradeBaseId;    //年级代号
protected string mstrGradeBaseName;    //年级名称
protected string mstrSchoolYear;    //学年
protected string mstrSchoolTerm;    //学期
protected string mstrEnterSchoolDate;    //进校日期
protected int? mintCurrentTermSeq;    //当前学期
protected int? mintExecPlanTermIndex;    //生成执行计划学期
protected string mstrSetEPTermIndexDate;    //设定执行计划学期日期
protected bool mbolIsOffed;    //是否毕业
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserId;    //修改人
protected int? mintGradeIndex;    //年级序号
protected string mstrBeginYearMonth;    //开始年月
protected string mstrEndYearMonth;    //结束年月
protected bool mbolAllowUpBaseInfo;    //允许修改基本信息
protected string mstrGradeBaseNameA;    //GradeBaseNameA
protected bool mbolIsVisible;    //是否显示
protected string mstrIdStudyLevel;    //IdStudyLevel
protected string mstrPointCalcVersionId;    //PointCalcVersionId
protected string mstrPrefix;    //Prefix
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsXzGradeBaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdGradeBase");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdGradeBase">关键字:年级流水号</param>
public clsXzGradeBaseEN(string strIdGradeBase)
 {
strIdGradeBase = strIdGradeBase.Replace("'", "''");
if (strIdGradeBase.Length > 4)
{
throw new Exception("在表:XzGradeBase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdGradeBase)  ==  true)
{
throw new Exception("在表:XzGradeBase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdGradeBase);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdGradeBase = strIdGradeBase;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("IdGradeBase");
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
if (strAttributeName  ==  conXzGradeBase.IdGradeBase)
{
return mstrIdGradeBase;
}
else if (strAttributeName  ==  conXzGradeBase.GradeBaseId)
{
return mstrGradeBaseId;
}
else if (strAttributeName  ==  conXzGradeBase.GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  conXzGradeBase.SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  conXzGradeBase.SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  conXzGradeBase.EnterSchoolDate)
{
return mstrEnterSchoolDate;
}
else if (strAttributeName  ==  conXzGradeBase.CurrentTermSeq)
{
return mintCurrentTermSeq;
}
else if (strAttributeName  ==  conXzGradeBase.ExecPlanTermIndex)
{
return mintExecPlanTermIndex;
}
else if (strAttributeName  ==  conXzGradeBase.SetEPTermIndexDate)
{
return mstrSetEPTermIndexDate;
}
else if (strAttributeName  ==  conXzGradeBase.IsOffed)
{
return mbolIsOffed;
}
else if (strAttributeName  ==  conXzGradeBase.ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  conXzGradeBase.ModifyUserId)
{
return mstrModifyUserId;
}
else if (strAttributeName  ==  conXzGradeBase.GradeIndex)
{
return mintGradeIndex;
}
else if (strAttributeName  ==  conXzGradeBase.BeginYearMonth)
{
return mstrBeginYearMonth;
}
else if (strAttributeName  ==  conXzGradeBase.EndYearMonth)
{
return mstrEndYearMonth;
}
else if (strAttributeName  ==  conXzGradeBase.AllowUpBaseInfo)
{
return mbolAllowUpBaseInfo;
}
else if (strAttributeName  ==  conXzGradeBase.GradeBaseNameA)
{
return mstrGradeBaseNameA;
}
else if (strAttributeName  ==  conXzGradeBase.IsVisible)
{
return mbolIsVisible;
}
else if (strAttributeName  ==  conXzGradeBase.IdStudyLevel)
{
return mstrIdStudyLevel;
}
else if (strAttributeName  ==  conXzGradeBase.PointCalcVersionId)
{
return mstrPointCalcVersionId;
}
else if (strAttributeName  ==  conXzGradeBase.Prefix)
{
return mstrPrefix;
}
else if (strAttributeName  ==  conXzGradeBase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conXzGradeBase.IdGradeBase)
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conXzGradeBase.IdGradeBase);
}
else if (strAttributeName  ==  conXzGradeBase.GradeBaseId)
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(conXzGradeBase.GradeBaseId);
}
else if (strAttributeName  ==  conXzGradeBase.GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(conXzGradeBase.GradeBaseName);
}
else if (strAttributeName  ==  conXzGradeBase.SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conXzGradeBase.SchoolYear);
}
else if (strAttributeName  ==  conXzGradeBase.SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conXzGradeBase.SchoolTerm);
}
else if (strAttributeName  ==  conXzGradeBase.EnterSchoolDate)
{
mstrEnterSchoolDate = value.ToString();
 AddUpdatedFld(conXzGradeBase.EnterSchoolDate);
}
else if (strAttributeName  ==  conXzGradeBase.CurrentTermSeq)
{
mintCurrentTermSeq = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzGradeBase.CurrentTermSeq);
}
else if (strAttributeName  ==  conXzGradeBase.ExecPlanTermIndex)
{
mintExecPlanTermIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzGradeBase.ExecPlanTermIndex);
}
else if (strAttributeName  ==  conXzGradeBase.SetEPTermIndexDate)
{
mstrSetEPTermIndexDate = value.ToString();
 AddUpdatedFld(conXzGradeBase.SetEPTermIndexDate);
}
else if (strAttributeName  ==  conXzGradeBase.IsOffed)
{
mbolIsOffed = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzGradeBase.IsOffed);
}
else if (strAttributeName  ==  conXzGradeBase.ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conXzGradeBase.ModifyDate);
}
else if (strAttributeName  ==  conXzGradeBase.ModifyUserId)
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conXzGradeBase.ModifyUserId);
}
else if (strAttributeName  ==  conXzGradeBase.GradeIndex)
{
mintGradeIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzGradeBase.GradeIndex);
}
else if (strAttributeName  ==  conXzGradeBase.BeginYearMonth)
{
mstrBeginYearMonth = value.ToString();
 AddUpdatedFld(conXzGradeBase.BeginYearMonth);
}
else if (strAttributeName  ==  conXzGradeBase.EndYearMonth)
{
mstrEndYearMonth = value.ToString();
 AddUpdatedFld(conXzGradeBase.EndYearMonth);
}
else if (strAttributeName  ==  conXzGradeBase.AllowUpBaseInfo)
{
mbolAllowUpBaseInfo = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzGradeBase.AllowUpBaseInfo);
}
else if (strAttributeName  ==  conXzGradeBase.GradeBaseNameA)
{
mstrGradeBaseNameA = value.ToString();
 AddUpdatedFld(conXzGradeBase.GradeBaseNameA);
}
else if (strAttributeName  ==  conXzGradeBase.IsVisible)
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzGradeBase.IsVisible);
}
else if (strAttributeName  ==  conXzGradeBase.IdStudyLevel)
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conXzGradeBase.IdStudyLevel);
}
else if (strAttributeName  ==  conXzGradeBase.PointCalcVersionId)
{
mstrPointCalcVersionId = value.ToString();
 AddUpdatedFld(conXzGradeBase.PointCalcVersionId);
}
else if (strAttributeName  ==  conXzGradeBase.Prefix)
{
mstrPrefix = value.ToString();
 AddUpdatedFld(conXzGradeBase.Prefix);
}
else if (strAttributeName  ==  conXzGradeBase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzGradeBase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conXzGradeBase.IdGradeBase  ==  AttributeName[intIndex])
{
return mstrIdGradeBase;
}
else if (conXzGradeBase.GradeBaseId  ==  AttributeName[intIndex])
{
return mstrGradeBaseId;
}
else if (conXzGradeBase.GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (conXzGradeBase.SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (conXzGradeBase.SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (conXzGradeBase.EnterSchoolDate  ==  AttributeName[intIndex])
{
return mstrEnterSchoolDate;
}
else if (conXzGradeBase.CurrentTermSeq  ==  AttributeName[intIndex])
{
return mintCurrentTermSeq;
}
else if (conXzGradeBase.ExecPlanTermIndex  ==  AttributeName[intIndex])
{
return mintExecPlanTermIndex;
}
else if (conXzGradeBase.SetEPTermIndexDate  ==  AttributeName[intIndex])
{
return mstrSetEPTermIndexDate;
}
else if (conXzGradeBase.IsOffed  ==  AttributeName[intIndex])
{
return mbolIsOffed;
}
else if (conXzGradeBase.ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (conXzGradeBase.ModifyUserId  ==  AttributeName[intIndex])
{
return mstrModifyUserId;
}
else if (conXzGradeBase.GradeIndex  ==  AttributeName[intIndex])
{
return mintGradeIndex;
}
else if (conXzGradeBase.BeginYearMonth  ==  AttributeName[intIndex])
{
return mstrBeginYearMonth;
}
else if (conXzGradeBase.EndYearMonth  ==  AttributeName[intIndex])
{
return mstrEndYearMonth;
}
else if (conXzGradeBase.AllowUpBaseInfo  ==  AttributeName[intIndex])
{
return mbolAllowUpBaseInfo;
}
else if (conXzGradeBase.GradeBaseNameA  ==  AttributeName[intIndex])
{
return mstrGradeBaseNameA;
}
else if (conXzGradeBase.IsVisible  ==  AttributeName[intIndex])
{
return mbolIsVisible;
}
else if (conXzGradeBase.IdStudyLevel  ==  AttributeName[intIndex])
{
return mstrIdStudyLevel;
}
else if (conXzGradeBase.PointCalcVersionId  ==  AttributeName[intIndex])
{
return mstrPointCalcVersionId;
}
else if (conXzGradeBase.Prefix  ==  AttributeName[intIndex])
{
return mstrPrefix;
}
else if (conXzGradeBase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conXzGradeBase.IdGradeBase  ==  AttributeName[intIndex])
{
mstrIdGradeBase = value.ToString();
 AddUpdatedFld(conXzGradeBase.IdGradeBase);
}
else if (conXzGradeBase.GradeBaseId  ==  AttributeName[intIndex])
{
mstrGradeBaseId = value.ToString();
 AddUpdatedFld(conXzGradeBase.GradeBaseId);
}
else if (conXzGradeBase.GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(conXzGradeBase.GradeBaseName);
}
else if (conXzGradeBase.SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(conXzGradeBase.SchoolYear);
}
else if (conXzGradeBase.SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(conXzGradeBase.SchoolTerm);
}
else if (conXzGradeBase.EnterSchoolDate  ==  AttributeName[intIndex])
{
mstrEnterSchoolDate = value.ToString();
 AddUpdatedFld(conXzGradeBase.EnterSchoolDate);
}
else if (conXzGradeBase.CurrentTermSeq  ==  AttributeName[intIndex])
{
mintCurrentTermSeq = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzGradeBase.CurrentTermSeq);
}
else if (conXzGradeBase.ExecPlanTermIndex  ==  AttributeName[intIndex])
{
mintExecPlanTermIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzGradeBase.ExecPlanTermIndex);
}
else if (conXzGradeBase.SetEPTermIndexDate  ==  AttributeName[intIndex])
{
mstrSetEPTermIndexDate = value.ToString();
 AddUpdatedFld(conXzGradeBase.SetEPTermIndexDate);
}
else if (conXzGradeBase.IsOffed  ==  AttributeName[intIndex])
{
mbolIsOffed = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzGradeBase.IsOffed);
}
else if (conXzGradeBase.ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(conXzGradeBase.ModifyDate);
}
else if (conXzGradeBase.ModifyUserId  ==  AttributeName[intIndex])
{
mstrModifyUserId = value.ToString();
 AddUpdatedFld(conXzGradeBase.ModifyUserId);
}
else if (conXzGradeBase.GradeIndex  ==  AttributeName[intIndex])
{
mintGradeIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(conXzGradeBase.GradeIndex);
}
else if (conXzGradeBase.BeginYearMonth  ==  AttributeName[intIndex])
{
mstrBeginYearMonth = value.ToString();
 AddUpdatedFld(conXzGradeBase.BeginYearMonth);
}
else if (conXzGradeBase.EndYearMonth  ==  AttributeName[intIndex])
{
mstrEndYearMonth = value.ToString();
 AddUpdatedFld(conXzGradeBase.EndYearMonth);
}
else if (conXzGradeBase.AllowUpBaseInfo  ==  AttributeName[intIndex])
{
mbolAllowUpBaseInfo = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzGradeBase.AllowUpBaseInfo);
}
else if (conXzGradeBase.GradeBaseNameA  ==  AttributeName[intIndex])
{
mstrGradeBaseNameA = value.ToString();
 AddUpdatedFld(conXzGradeBase.GradeBaseNameA);
}
else if (conXzGradeBase.IsVisible  ==  AttributeName[intIndex])
{
mbolIsVisible = TransNullToBool(value.ToString());
 AddUpdatedFld(conXzGradeBase.IsVisible);
}
else if (conXzGradeBase.IdStudyLevel  ==  AttributeName[intIndex])
{
mstrIdStudyLevel = value.ToString();
 AddUpdatedFld(conXzGradeBase.IdStudyLevel);
}
else if (conXzGradeBase.PointCalcVersionId  ==  AttributeName[intIndex])
{
mstrPointCalcVersionId = value.ToString();
 AddUpdatedFld(conXzGradeBase.PointCalcVersionId);
}
else if (conXzGradeBase.Prefix  ==  AttributeName[intIndex])
{
mstrPrefix = value.ToString();
 AddUpdatedFld(conXzGradeBase.Prefix);
}
else if (conXzGradeBase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conXzGradeBase.Memo);
}
}
}

/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdGradeBase
{
get
{
return mstrIdGradeBase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdGradeBase = value;
}
else
{
 mstrIdGradeBase = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.IdGradeBase);
}
}
/// <summary>
/// 年级代号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseId
{
get
{
return mstrGradeBaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseId = value;
}
else
{
 mstrGradeBaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.GradeBaseId);
}
}
/// <summary>
/// 年级名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseName
{
get
{
return mstrGradeBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseName = value;
}
else
{
 mstrGradeBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.GradeBaseName);
}
}
/// <summary>
/// 学年(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolYear
{
get
{
return mstrSchoolYear;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolYear = value;
}
else
{
 mstrSchoolYear = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.SchoolYear);
}
}
/// <summary>
/// 学期(说明:;字段类型:char;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SchoolTerm
{
get
{
return mstrSchoolTerm;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSchoolTerm = value;
}
else
{
 mstrSchoolTerm = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.SchoolTerm);
}
}
/// <summary>
/// 进校日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EnterSchoolDate
{
get
{
return mstrEnterSchoolDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEnterSchoolDate = value;
}
else
{
 mstrEnterSchoolDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.EnterSchoolDate);
}
}
/// <summary>
/// 当前学期(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? CurrentTermSeq
{
get
{
return mintCurrentTermSeq;
}
set
{
 mintCurrentTermSeq = value;
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.CurrentTermSeq);
}
}
/// <summary>
/// 生成执行计划学期(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ExecPlanTermIndex
{
get
{
return mintExecPlanTermIndex;
}
set
{
 mintExecPlanTermIndex = value;
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.ExecPlanTermIndex);
}
}
/// <summary>
/// 设定执行计划学期日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SetEPTermIndexDate
{
get
{
return mstrSetEPTermIndexDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSetEPTermIndexDate = value;
}
else
{
 mstrSetEPTermIndexDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.SetEPTermIndexDate);
}
}
/// <summary>
/// 是否毕业(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsOffed
{
get
{
return mbolIsOffed;
}
set
{
 mbolIsOffed = value;
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.IsOffed);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.ModifyDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUserId
{
get
{
return mstrModifyUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserId = value;
}
else
{
 mstrModifyUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.ModifyUserId);
}
}
/// <summary>
/// 年级序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? GradeIndex
{
get
{
return mintGradeIndex;
}
set
{
 mintGradeIndex = value;
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.GradeIndex);
}
}
/// <summary>
/// 开始年月(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string BeginYearMonth
{
get
{
return mstrBeginYearMonth;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrBeginYearMonth = value;
}
else
{
 mstrBeginYearMonth = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.BeginYearMonth);
}
}
/// <summary>
/// 结束年月(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EndYearMonth
{
get
{
return mstrEndYearMonth;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEndYearMonth = value;
}
else
{
 mstrEndYearMonth = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.EndYearMonth);
}
}
/// <summary>
/// 允许修改基本信息(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool AllowUpBaseInfo
{
get
{
return mbolAllowUpBaseInfo;
}
set
{
 mbolAllowUpBaseInfo = value;
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.AllowUpBaseInfo);
}
}
/// <summary>
/// GradeBaseNameA(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GradeBaseNameA
{
get
{
return mstrGradeBaseNameA;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseNameA = value;
}
else
{
 mstrGradeBaseNameA = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.GradeBaseNameA);
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
 AddUpdatedFld(conXzGradeBase.IsVisible);
}
}
/// <summary>
/// IdStudyLevel(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdStudyLevel
{
get
{
return mstrIdStudyLevel;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdStudyLevel = value;
}
else
{
 mstrIdStudyLevel = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.IdStudyLevel);
}
}
/// <summary>
/// PointCalcVersionId(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PointCalcVersionId
{
get
{
return mstrPointCalcVersionId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPointCalcVersionId = value;
}
else
{
 mstrPointCalcVersionId = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.PointCalcVersionId);
}
}
/// <summary>
/// Prefix(说明:;字段类型:char;字段长度:3;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Prefix
{
get
{
return mstrPrefix;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrefix = value;
}
else
{
 mstrPrefix = value;
}
//记录修改过的字段
 AddUpdatedFld(conXzGradeBase.Prefix);
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
 AddUpdatedFld(conXzGradeBase.Memo);
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
  return mstrIdGradeBase;
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
  return mstrGradeBaseName;
 }
 }
}
 /// <summary>
 /// 年级(XzGradeBase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conXzGradeBase
{
public const string _CurrTabName = "XzGradeBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdGradeBase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"IdGradeBase", "GradeBaseId", "GradeBaseName", "SchoolYear", "SchoolTerm", "EnterSchoolDate", "CurrentTermSeq", "ExecPlanTermIndex", "SetEPTermIndexDate", "IsOffed", "ModifyDate", "ModifyUserId", "GradeIndex", "BeginYearMonth", "EndYearMonth", "AllowUpBaseInfo", "GradeBaseNameA", "IsVisible", "IdStudyLevel", "PointCalcVersionId", "Prefix", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"IdGradeBase"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdGradeBase = "IdGradeBase";    //年级流水号

 /// <summary>
 /// 常量:"GradeBaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseId = "GradeBaseId";    //年级代号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"SchoolYear"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolYear = "SchoolYear";    //学年

 /// <summary>
 /// 常量:"SchoolTerm"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SchoolTerm = "SchoolTerm";    //学期

 /// <summary>
 /// 常量:"EnterSchoolDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EnterSchoolDate = "EnterSchoolDate";    //进校日期

 /// <summary>
 /// 常量:"CurrentTermSeq"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CurrentTermSeq = "CurrentTermSeq";    //当前学期

 /// <summary>
 /// 常量:"ExecPlanTermIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ExecPlanTermIndex = "ExecPlanTermIndex";    //生成执行计划学期

 /// <summary>
 /// 常量:"SetEPTermIndexDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SetEPTermIndexDate = "SetEPTermIndexDate";    //设定执行计划学期日期

 /// <summary>
 /// 常量:"IsOffed"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsOffed = "IsOffed";    //是否毕业

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModifyUserId = "ModifyUserId";    //修改人

 /// <summary>
 /// 常量:"GradeIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeIndex = "GradeIndex";    //年级序号

 /// <summary>
 /// 常量:"BeginYearMonth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string BeginYearMonth = "BeginYearMonth";    //开始年月

 /// <summary>
 /// 常量:"EndYearMonth"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EndYearMonth = "EndYearMonth";    //结束年月

 /// <summary>
 /// 常量:"AllowUpBaseInfo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string AllowUpBaseInfo = "AllowUpBaseInfo";    //允许修改基本信息

 /// <summary>
 /// 常量:"GradeBaseNameA"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GradeBaseNameA = "GradeBaseNameA";    //GradeBaseNameA

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"IdStudyLevel"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdStudyLevel = "IdStudyLevel";    //IdStudyLevel

 /// <summary>
 /// 常量:"PointCalcVersionId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PointCalcVersionId = "PointCalcVersionId";    //PointCalcVersionId

 /// <summary>
 /// 常量:"Prefix"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Prefix = "Prefix";    //Prefix

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}