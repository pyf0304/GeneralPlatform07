
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCjStuPointEN
 表名:vCjStuPoint
 生成代码版本:2017.11.11.1
 生成日期:2017/11/22 05:20:02
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
 /// vCjStuPoint(vCjStuPoint)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsvCjStuPointEN : clsEntityBase2
{
public const string CurrTabName_S = "vCjStuPoint"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "id_CjStuPoint"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 23;
public static string[] AttributeName = new string[] {"StuID", "StuName", "SexID", "id_AdminClass", "AdminClassID", "AdminClassName", "id_GradeBase", "GradeBaseID", "GradeBaseName", "EntryDay", "GradeName", "SelCrsGroup", "id_CjStuPoint", "id_Stu", "ScrTermSeq", "SchoolYear", "SchoolTerm", "TotalMark", "AveragePointMark", "AggregatePointMark", "TotalPointMark", "OperateMode", "UpdDate"};
//以下是属性变量

protected string mstrStuID;    //学号
protected string mstrStuName;    //姓名
protected string mstrSexID;    //性别编号
protected string mstrid_AdminClass;    //行政班流水号
protected string mstrAdminClassID;    //行政班代号
protected string mstrAdminClassName;    //行政班名称
protected string mstrid_GradeBase;    //年级流水号
protected string mstrGradeBaseID;    //年级代号
protected string mstrGradeBaseName;    //年级名称
protected string mstrEntryDay;    //EntryDay
protected string mstrGradeName;    //GradeName
protected string mstrSelCrsGroup;    //SelCrsGroup
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
protected DateTime mdteUpdDate;    //UpdDate


 /// <summary>
 /// 常量:"StuID"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_StuID = "StuID";    //学号

 /// <summary>
 /// 常量:"StuName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_StuName = "StuName";    //姓名

 /// <summary>
 /// 常量:"SexID"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SexID = "SexID";    //性别编号

 /// <summary>
 /// 常量:"id_AdminClass"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_AdminClass = "id_AdminClass";    //行政班流水号

 /// <summary>
 /// 常量:"AdminClassID"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AdminClassID = "AdminClassID";    //行政班代号

 /// <summary>
 /// 常量:"AdminClassName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_AdminClassName = "AdminClassName";    //行政班名称

 /// <summary>
 /// 常量:"id_GradeBase"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_GradeBase = "id_GradeBase";    //年级流水号

 /// <summary>
 /// 常量:"GradeBaseID"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GradeBaseID = "GradeBaseID";    //年级代号

 /// <summary>
 /// 常量:"GradeBaseName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GradeBaseName = "GradeBaseName";    //年级名称

 /// <summary>
 /// 常量:"EntryDay"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_EntryDay = "EntryDay";    //EntryDay

 /// <summary>
 /// 常量:"GradeName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_GradeName = "GradeName";    //GradeName

 /// <summary>
 /// 常量:"SelCrsGroup"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SelCrsGroup = "SelCrsGroup";    //SelCrsGroup

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
 /// 常量:"UpdDate"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //UpdDate

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsvCjStuPointEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 CurrTabName = "vCjStuPoint";
 lstKeyFldNames.Add("id_CjStuPoint");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngid_CjStuPoint">关键字:学生绩点流水号</param>
public clsvCjStuPointEN(long lngid_CjStuPoint)
 {
 if (lngid_CjStuPoint  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngid_CjStuPoint = lngid_CjStuPoint;
 SetInit();
 mbolIsCheckProperty = false;
 CurrTabName = "vCjStuPoint";
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
if (strAttributeName  ==  con_StuID)
{
return mstrStuID;
}
else if (strAttributeName  ==  con_StuName)
{
return mstrStuName;
}
else if (strAttributeName  ==  con_SexID)
{
return mstrSexID;
}
else if (strAttributeName  ==  con_id_AdminClass)
{
return mstrid_AdminClass;
}
else if (strAttributeName  ==  con_AdminClassID)
{
return mstrAdminClassID;
}
else if (strAttributeName  ==  con_AdminClassName)
{
return mstrAdminClassName;
}
else if (strAttributeName  ==  con_id_GradeBase)
{
return mstrid_GradeBase;
}
else if (strAttributeName  ==  con_GradeBaseID)
{
return mstrGradeBaseID;
}
else if (strAttributeName  ==  con_GradeBaseName)
{
return mstrGradeBaseName;
}
else if (strAttributeName  ==  con_EntryDay)
{
return mstrEntryDay;
}
else if (strAttributeName  ==  con_GradeName)
{
return mstrGradeName;
}
else if (strAttributeName  ==  con_SelCrsGroup)
{
return mstrSelCrsGroup;
}
else if (strAttributeName  ==  con_id_CjStuPoint)
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
else if (strAttributeName  ==  con_UpdDate)
{
return mdteUpdDate;
}
return null;
}
set
{
if (strAttributeName  ==  con_StuID)
{
mstrStuID = value.ToString();
 AddUpdatedFld(con_StuID);
}
else if (strAttributeName  ==  con_StuName)
{
mstrStuName = value.ToString();
 AddUpdatedFld(con_StuName);
}
else if (strAttributeName  ==  con_SexID)
{
mstrSexID = value.ToString();
 AddUpdatedFld(con_SexID);
}
else if (strAttributeName  ==  con_id_AdminClass)
{
mstrid_AdminClass = value.ToString();
 AddUpdatedFld(con_id_AdminClass);
}
else if (strAttributeName  ==  con_AdminClassID)
{
mstrAdminClassID = value.ToString();
 AddUpdatedFld(con_AdminClassID);
}
else if (strAttributeName  ==  con_AdminClassName)
{
mstrAdminClassName = value.ToString();
 AddUpdatedFld(con_AdminClassName);
}
else if (strAttributeName  ==  con_id_GradeBase)
{
mstrid_GradeBase = value.ToString();
 AddUpdatedFld(con_id_GradeBase);
}
else if (strAttributeName  ==  con_GradeBaseID)
{
mstrGradeBaseID = value.ToString();
 AddUpdatedFld(con_GradeBaseID);
}
else if (strAttributeName  ==  con_GradeBaseName)
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(con_GradeBaseName);
}
else if (strAttributeName  ==  con_EntryDay)
{
mstrEntryDay = value.ToString();
 AddUpdatedFld(con_EntryDay);
}
else if (strAttributeName  ==  con_GradeName)
{
mstrGradeName = value.ToString();
 AddUpdatedFld(con_GradeName);
}
else if (strAttributeName  ==  con_SelCrsGroup)
{
mstrSelCrsGroup = value.ToString();
 AddUpdatedFld(con_SelCrsGroup);
}
else if (strAttributeName  ==  con_id_CjStuPoint)
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
else if (strAttributeName  ==  con_UpdDate)
{
mdteUpdDate = TransNullToDate(value.ToString());
 AddUpdatedFld(con_UpdDate);
}
}
}
public object this[int intIndex]
{
get
{
if (con_StuID  ==  AttributeName[intIndex])
{
return mstrStuID;
}
else if (con_StuName  ==  AttributeName[intIndex])
{
return mstrStuName;
}
else if (con_SexID  ==  AttributeName[intIndex])
{
return mstrSexID;
}
else if (con_id_AdminClass  ==  AttributeName[intIndex])
{
return mstrid_AdminClass;
}
else if (con_AdminClassID  ==  AttributeName[intIndex])
{
return mstrAdminClassID;
}
else if (con_AdminClassName  ==  AttributeName[intIndex])
{
return mstrAdminClassName;
}
else if (con_id_GradeBase  ==  AttributeName[intIndex])
{
return mstrid_GradeBase;
}
else if (con_GradeBaseID  ==  AttributeName[intIndex])
{
return mstrGradeBaseID;
}
else if (con_GradeBaseName  ==  AttributeName[intIndex])
{
return mstrGradeBaseName;
}
else if (con_EntryDay  ==  AttributeName[intIndex])
{
return mstrEntryDay;
}
else if (con_GradeName  ==  AttributeName[intIndex])
{
return mstrGradeName;
}
else if (con_SelCrsGroup  ==  AttributeName[intIndex])
{
return mstrSelCrsGroup;
}
else if (con_id_CjStuPoint  ==  AttributeName[intIndex])
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
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mdteUpdDate;
}
return null;
}
set
{
if (con_StuID  ==  AttributeName[intIndex])
{
mstrStuID = value.ToString();
 AddUpdatedFld(con_StuID);
}
else if (con_StuName  ==  AttributeName[intIndex])
{
mstrStuName = value.ToString();
 AddUpdatedFld(con_StuName);
}
else if (con_SexID  ==  AttributeName[intIndex])
{
mstrSexID = value.ToString();
 AddUpdatedFld(con_SexID);
}
else if (con_id_AdminClass  ==  AttributeName[intIndex])
{
mstrid_AdminClass = value.ToString();
 AddUpdatedFld(con_id_AdminClass);
}
else if (con_AdminClassID  ==  AttributeName[intIndex])
{
mstrAdminClassID = value.ToString();
 AddUpdatedFld(con_AdminClassID);
}
else if (con_AdminClassName  ==  AttributeName[intIndex])
{
mstrAdminClassName = value.ToString();
 AddUpdatedFld(con_AdminClassName);
}
else if (con_id_GradeBase  ==  AttributeName[intIndex])
{
mstrid_GradeBase = value.ToString();
 AddUpdatedFld(con_id_GradeBase);
}
else if (con_GradeBaseID  ==  AttributeName[intIndex])
{
mstrGradeBaseID = value.ToString();
 AddUpdatedFld(con_GradeBaseID);
}
else if (con_GradeBaseName  ==  AttributeName[intIndex])
{
mstrGradeBaseName = value.ToString();
 AddUpdatedFld(con_GradeBaseName);
}
else if (con_EntryDay  ==  AttributeName[intIndex])
{
mstrEntryDay = value.ToString();
 AddUpdatedFld(con_EntryDay);
}
else if (con_GradeName  ==  AttributeName[intIndex])
{
mstrGradeName = value.ToString();
 AddUpdatedFld(con_GradeName);
}
else if (con_SelCrsGroup  ==  AttributeName[intIndex])
{
mstrSelCrsGroup = value.ToString();
 AddUpdatedFld(con_SelCrsGroup);
}
else if (con_id_CjStuPoint  ==  AttributeName[intIndex])
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
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mdteUpdDate = TransNullToDate(value.ToString());
 AddUpdatedFld(con_UpdDate);
}
}
}

/// <summary>
/// 学号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string StuID
{
get
{
return mstrStuID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuID = value;
}
else
{
 mstrStuID = value;
}
//记录修改过的字段
 AddUpdatedFld(con_StuID);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string StuName
{
get
{
return mstrStuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuName = value;
}
else
{
 mstrStuName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_StuName);
}
}
/// <summary>
/// 性别编号(说明:;字段类型:varchar;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string SexID
{
get
{
return mstrSexID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSexID = value;
}
else
{
 mstrSexID = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SexID);
}
}
/// <summary>
/// 行政班流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string id_AdminClass
{
get
{
return mstrid_AdminClass;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_AdminClass = value;
}
else
{
 mstrid_AdminClass = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_AdminClass);
}
}
/// <summary>
/// 行政班代号(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string AdminClassID
{
get
{
return mstrAdminClassID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClassID = value;
}
else
{
 mstrAdminClassID = value;
}
//记录修改过的字段
 AddUpdatedFld(con_AdminClassID);
}
}
/// <summary>
/// 行政班名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string AdminClassName
{
get
{
return mstrAdminClassName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrAdminClassName = value;
}
else
{
 mstrAdminClassName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_AdminClassName);
}
}
/// <summary>
/// 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string id_GradeBase
{
get
{
return mstrid_GradeBase;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_GradeBase = value;
}
else
{
 mstrid_GradeBase = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_GradeBase);
}
}
/// <summary>
/// 年级代号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string GradeBaseID
{
get
{
return mstrGradeBaseID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeBaseID = value;
}
else
{
 mstrGradeBaseID = value;
}
//记录修改过的字段
 AddUpdatedFld(con_GradeBaseID);
}
}
/// <summary>
/// 年级名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
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
 AddUpdatedFld(con_GradeBaseName);
}
}
/// <summary>
/// EntryDay(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string EntryDay
{
get
{
return mstrEntryDay;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEntryDay = value;
}
else
{
 mstrEntryDay = value;
}
//记录修改过的字段
 AddUpdatedFld(con_EntryDay);
}
}
/// <summary>
/// GradeName(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string GradeName
{
get
{
return mstrGradeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGradeName = value;
}
else
{
 mstrGradeName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_GradeName);
}
}
/// <summary>
/// SelCrsGroup(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string SelCrsGroup
{
get
{
return mstrSelCrsGroup;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSelCrsGroup = value;
}
else
{
 mstrSelCrsGroup = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SelCrsGroup);
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
}
}