
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCjStuPointEN
 表名:CjStuPoint
 生成代码版本:2017.11.11.1
 生成日期:2017/11/22 05:20:05
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 模块中文名:成绩管理
 模块英文名:ScoreManage
 框架-层名:实体层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.09.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.11.09.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace GeneralPlatform.Entity
{
 /// <summary>
 /// 成绩学生绩点(CjStuPoint)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsCjStuPointEN : clsEntityBase2
{
public const string CurrTabName_S = "CjStuPoint"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "id_CjStuPoint"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"id_CjStuPoint", "id_Stu", "ScrTermSeq", "SchoolYear", "SchoolTerm", "TotalMark", "AveragePointMark", "AggregatePointMark", "TotalPointMark", "OperateMode", "IsSynchToWeb", "SynchToWebDate", "SynchToWebUser", "UpdDate", "ModifyDate", "ModifyUserID"};
//以下是属性变量

protected long mlngid_CjStuPoint;    //学生绩点流水号
protected string mstrid_Stu;    //学生流水号
protected int mintScrTermSeq;    //成绩学期
protected string mstrSchoolYear;    //学年
protected string mstrSchoolTerm;    //SchoolTerm
protected double mdblTotalMark;    //总分(不详)
protected double mdblAveragePointMark;    //平均绩点学分
protected double mdblAggregatePointMark;    //累积绩点学分
protected double mdblTotalPointMark;    //总绩点学分
protected string mstrOperateMode;    //OperateMode
protected bool mbolIsSynchToWeb;    //是否同步Web
protected string mstrSynchToWebDate;    //同步Web日期
protected string mstrSynchToWebUser;    //同步Web用户
protected DateTime mdteUpdDate;    //UpdDate
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUserID;    //修改人


 /// <summary>
 /// 常量:"id_CjStuPoint"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_CjStuPoint = "id_CjStuPoint";    //学生绩点流水号

 /// <summary>
 /// 常量:"id_Stu"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_Stu = "id_Stu";    //学生流水号

 /// <summary>
 /// 常量:"ScrTermSeq"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ScrTermSeq = "ScrTermSeq";    //成绩学期

 /// <summary>
 /// 常量:"SchoolYear"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SchoolYear = "SchoolYear";    //学年

 /// <summary>
 /// 常量:"SchoolTerm"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SchoolTerm = "SchoolTerm";    //SchoolTerm

 /// <summary>
 /// 常量:"TotalMark"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TotalMark = "TotalMark";    //总分(不详)

 /// <summary>
 /// 常量:"AveragePointMark"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AveragePointMark = "AveragePointMark";    //平均绩点学分

 /// <summary>
 /// 常量:"AggregatePointMark"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AggregatePointMark = "AggregatePointMark";    //累积绩点学分

 /// <summary>
 /// 常量:"TotalPointMark"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TotalPointMark = "TotalPointMark";    //总绩点学分

 /// <summary>
 /// 常量:"OperateMode"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OperateMode = "OperateMode";    //OperateMode

 /// <summary>
 /// 常量:"IsSynchToWeb"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsSynchToWeb = "IsSynchToWeb";    //是否同步Web

 /// <summary>
 /// 常量:"SynchToWebDate"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SynchToWebDate = "SynchToWebDate";    //同步Web日期

 /// <summary>
 /// 常量:"SynchToWebUser"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SynchToWebUser = "SynchToWebUser";    //同步Web用户

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //UpdDate

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUserID"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ModifyUserID = "ModifyUserID";    //修改人

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsCjStuPointEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 CurrTabName = "CjStuPoint";
 lstKeyFldNames.Add("id_CjStuPoint");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngid_CjStuPoint">关键字:学生绩点流水号</param>
public clsCjStuPointEN(long lngid_CjStuPoint)
 {
 if (lngid_CjStuPoint  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngid_CjStuPoint = lngid_CjStuPoint;
 SetInit();
 mbolIsCheckProperty = false;
 CurrTabName = "CjStuPoint";
 lstKeyFldNames.Add("id_CjStuPoint");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_id_CjStuPoint)
{
return mlngid_CjStuPoint;
}
else if (strAttributeName  ==  con_id_Stu)
{
return mstrid_Stu;
}
else if (strAttributeName  ==  con_ScrTermSeq)
{
return mintScrTermSeq;
}
else if (strAttributeName  ==  con_SchoolYear)
{
return mstrSchoolYear;
}
else if (strAttributeName  ==  con_SchoolTerm)
{
return mstrSchoolTerm;
}
else if (strAttributeName  ==  con_TotalMark)
{
return mdblTotalMark;
}
else if (strAttributeName  ==  con_AveragePointMark)
{
return mdblAveragePointMark;
}
else if (strAttributeName  ==  con_AggregatePointMark)
{
return mdblAggregatePointMark;
}
else if (strAttributeName  ==  con_TotalPointMark)
{
return mdblTotalPointMark;
}
else if (strAttributeName  ==  con_OperateMode)
{
return mstrOperateMode;
}
else if (strAttributeName  ==  con_IsSynchToWeb)
{
return mbolIsSynchToWeb;
}
else if (strAttributeName  ==  con_SynchToWebDate)
{
return mstrSynchToWebDate;
}
else if (strAttributeName  ==  con_SynchToWebUser)
{
return mstrSynchToWebUser;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mdteUpdDate;
}
else if (strAttributeName  ==  con_ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  con_ModifyUserID)
{
return mstrModifyUserID;
}
return null;
}
set
{
if (strAttributeName  ==  con_id_CjStuPoint)
{
mlngid_CjStuPoint = TransNullToInt(value.ToString());
 AddUpdatedFld(con_id_CjStuPoint);
}
else if (strAttributeName  ==  con_id_Stu)
{
mstrid_Stu = value.ToString();
 AddUpdatedFld(con_id_Stu);
}
else if (strAttributeName  ==  con_ScrTermSeq)
{
mintScrTermSeq = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ScrTermSeq);
}
else if (strAttributeName  ==  con_SchoolYear)
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(con_SchoolYear);
}
else if (strAttributeName  ==  con_SchoolTerm)
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(con_SchoolTerm);
}
else if (strAttributeName  ==  con_TotalMark)
{
mdblTotalMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(con_TotalMark);
}
else if (strAttributeName  ==  con_AveragePointMark)
{
mdblAveragePointMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(con_AveragePointMark);
}
else if (strAttributeName  ==  con_AggregatePointMark)
{
mdblAggregatePointMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(con_AggregatePointMark);
}
else if (strAttributeName  ==  con_TotalPointMark)
{
mdblTotalPointMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(con_TotalPointMark);
}
else if (strAttributeName  ==  con_OperateMode)
{
mstrOperateMode = value.ToString();
 AddUpdatedFld(con_OperateMode);
}
else if (strAttributeName  ==  con_IsSynchToWeb)
{
mbolIsSynchToWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsSynchToWeb);
}
else if (strAttributeName  ==  con_SynchToWebDate)
{
mstrSynchToWebDate = value.ToString();
 AddUpdatedFld(con_SynchToWebDate);
}
else if (strAttributeName  ==  con_SynchToWebUser)
{
mstrSynchToWebUser = value.ToString();
 AddUpdatedFld(con_SynchToWebUser);
}
else if (strAttributeName  ==  con_UpdDate)
{
mdteUpdDate = TransNullToDate(value.ToString());
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(con_ModifyDate);
}
else if (strAttributeName  ==  con_ModifyUserID)
{
mstrModifyUserID = value.ToString();
 AddUpdatedFld(con_ModifyUserID);
}
}
}
public object this[int intIndex]
{
get
{
if (con_id_CjStuPoint  ==  AttributeName[intIndex])
{
return mlngid_CjStuPoint;
}
else if (con_id_Stu  ==  AttributeName[intIndex])
{
return mstrid_Stu;
}
else if (con_ScrTermSeq  ==  AttributeName[intIndex])
{
return mintScrTermSeq;
}
else if (con_SchoolYear  ==  AttributeName[intIndex])
{
return mstrSchoolYear;
}
else if (con_SchoolTerm  ==  AttributeName[intIndex])
{
return mstrSchoolTerm;
}
else if (con_TotalMark  ==  AttributeName[intIndex])
{
return mdblTotalMark;
}
else if (con_AveragePointMark  ==  AttributeName[intIndex])
{
return mdblAveragePointMark;
}
else if (con_AggregatePointMark  ==  AttributeName[intIndex])
{
return mdblAggregatePointMark;
}
else if (con_TotalPointMark  ==  AttributeName[intIndex])
{
return mdblTotalPointMark;
}
else if (con_OperateMode  ==  AttributeName[intIndex])
{
return mstrOperateMode;
}
else if (con_IsSynchToWeb  ==  AttributeName[intIndex])
{
return mbolIsSynchToWeb;
}
else if (con_SynchToWebDate  ==  AttributeName[intIndex])
{
return mstrSynchToWebDate;
}
else if (con_SynchToWebUser  ==  AttributeName[intIndex])
{
return mstrSynchToWebUser;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mdteUpdDate;
}
else if (con_ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (con_ModifyUserID  ==  AttributeName[intIndex])
{
return mstrModifyUserID;
}
return null;
}
set
{
if (con_id_CjStuPoint  ==  AttributeName[intIndex])
{
mlngid_CjStuPoint = TransNullToInt(value.ToString());
 AddUpdatedFld(con_id_CjStuPoint);
}
else if (con_id_Stu  ==  AttributeName[intIndex])
{
mstrid_Stu = value.ToString();
 AddUpdatedFld(con_id_Stu);
}
else if (con_ScrTermSeq  ==  AttributeName[intIndex])
{
mintScrTermSeq = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ScrTermSeq);
}
else if (con_SchoolYear  ==  AttributeName[intIndex])
{
mstrSchoolYear = value.ToString();
 AddUpdatedFld(con_SchoolYear);
}
else if (con_SchoolTerm  ==  AttributeName[intIndex])
{
mstrSchoolTerm = value.ToString();
 AddUpdatedFld(con_SchoolTerm);
}
else if (con_TotalMark  ==  AttributeName[intIndex])
{
mdblTotalMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(con_TotalMark);
}
else if (con_AveragePointMark  ==  AttributeName[intIndex])
{
mdblAveragePointMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(con_AveragePointMark);
}
else if (con_AggregatePointMark  ==  AttributeName[intIndex])
{
mdblAggregatePointMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(con_AggregatePointMark);
}
else if (con_TotalPointMark  ==  AttributeName[intIndex])
{
mdblTotalPointMark = TransNullToDouble(value.ToString());
 AddUpdatedFld(con_TotalPointMark);
}
else if (con_OperateMode  ==  AttributeName[intIndex])
{
mstrOperateMode = value.ToString();
 AddUpdatedFld(con_OperateMode);
}
else if (con_IsSynchToWeb  ==  AttributeName[intIndex])
{
mbolIsSynchToWeb = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsSynchToWeb);
}
else if (con_SynchToWebDate  ==  AttributeName[intIndex])
{
mstrSynchToWebDate = value.ToString();
 AddUpdatedFld(con_SynchToWebDate);
}
else if (con_SynchToWebUser  ==  AttributeName[intIndex])
{
mstrSynchToWebUser = value.ToString();
 AddUpdatedFld(con_SynchToWebUser);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mdteUpdDate = TransNullToDate(value.ToString());
 AddUpdatedFld(con_UpdDate);
}
else if (con_ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(con_ModifyDate);
}
else if (con_ModifyUserID  ==  AttributeName[intIndex])
{
mstrModifyUserID = value.ToString();
 AddUpdatedFld(con_ModifyUserID);
}
}
}

/// <summary>
/// 学生绩点流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public long id_CjStuPoint
{
get
{
return mlngid_CjStuPoint;
}
set
{
 mlngid_CjStuPoint = value;
//记录修改过的字段
 AddUpdatedFld(con_id_CjStuPoint);
}
}
/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string id_Stu
{
get
{
return mstrid_Stu;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_Stu = value;
}
else
{
 mstrid_Stu = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_Stu);
}
}
/// <summary>
/// 成绩学期(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int ScrTermSeq
{
get
{
return mintScrTermSeq;
}
set
{
 mintScrTermSeq = value;
//记录修改过的字段
 AddUpdatedFld(con_ScrTermSeq);
}
}
/// <summary>
/// 学年(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_SchoolYear);
}
}
/// <summary>
/// SchoolTerm(说明:;字段类型:varchar;字段长度:2;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_SchoolTerm);
}
}
/// <summary>
/// 总分(不详)(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public double TotalMark
{
get
{
return mdblTotalMark;
}
set
{
 mdblTotalMark = value;
//记录修改过的字段
 AddUpdatedFld(con_TotalMark);
}
}
/// <summary>
/// 平均绩点学分(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public double AveragePointMark
{
get
{
return mdblAveragePointMark;
}
set
{
 mdblAveragePointMark = value;
//记录修改过的字段
 AddUpdatedFld(con_AveragePointMark);
}
}
/// <summary>
/// 累积绩点学分(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public double AggregatePointMark
{
get
{
return mdblAggregatePointMark;
}
set
{
 mdblAggregatePointMark = value;
//记录修改过的字段
 AddUpdatedFld(con_AggregatePointMark);
}
}
/// <summary>
/// 总绩点学分(说明:;字段类型:decimal;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public double TotalPointMark
{
get
{
return mdblTotalPointMark;
}
set
{
 mdblTotalPointMark = value;
//记录修改过的字段
 AddUpdatedFld(con_TotalPointMark);
}
}
/// <summary>
/// OperateMode(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string OperateMode
{
get
{
return mstrOperateMode;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOperateMode = value;
}
else
{
 mstrOperateMode = value;
}
//记录修改过的字段
 AddUpdatedFld(con_OperateMode);
}
}
/// <summary>
/// 是否同步Web(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public bool IsSynchToWeb
{
get
{
return mbolIsSynchToWeb;
}
set
{
 mbolIsSynchToWeb = value;
//记录修改过的字段
 AddUpdatedFld(con_IsSynchToWeb);
}
}
/// <summary>
/// 同步Web日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string SynchToWebDate
{
get
{
return mstrSynchToWebDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToWebDate = value;
}
else
{
 mstrSynchToWebDate = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SynchToWebDate);
}
}
/// <summary>
/// 同步Web用户(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string SynchToWebUser
{
get
{
return mstrSynchToWebUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSynchToWebUser = value;
}
else
{
 mstrSynchToWebUser = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SynchToWebUser);
}
}
/// <summary>
/// UpdDate(说明:;字段类型:datetime;字段长度:16;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public DateTime UpdDate
{
get
{
return mdteUpdDate;
}
set
{
 mdteUpdDate = value;
//记录修改过的字段
 AddUpdatedFld(con_UpdDate);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_ModifyDate);
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string ModifyUserID
{
get
{
return mstrModifyUserID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUserID = value;
}
else
{
 mstrModifyUserID = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ModifyUserID);
}
}
}
}