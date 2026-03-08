
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCjStuPointEN_Sim
 表名:CjStuPoint
 生成代码版本:2017.11.11.1
 生成日期:2017/11/22 05:20:08
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 模块中文名:成绩管理
 模块英文名:ScoreManage
 框架-层名:实体层-简化
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.09.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.11.09.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace GeneralPlatform.Entity
{
 /// <summary>
 /// 成绩学生绩点(CjStuPoint)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode_Sim)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsCjStuPointEN_Sim 
{
//以下是属性变量

private long mlngid_CjStuPoint;    //学生绩点流水号
private string mstrid_Stu;    //学生流水号
private int mintScrTermSeq;    //成绩学期
private string mstrSchoolYear;    //学年
private string mstrSchoolTerm;    //SchoolTerm
private double mdblTotalMark;    //总分(不详)
private double mdblAveragePointMark;    //平均绩点学分
private double mdblAggregatePointMark;    //累积绩点学分
private double mdblTotalPointMark;    //总绩点学分
private string mstrOperateMode;    //OperateMode
private bool mbolIsSynchToWeb;    //是否同步Web
private string mstrSynchToWebDate;    //同步Web日期
private string mstrSynchToWebUser;    //同步Web用户
private DateTime mdteUpdDate;    //UpdDate
private string mstrModifyDate;    //修改日期
private string mstrModifyUserID;    //修改人
private string mstrsf_UpdFldSetStr;    //系统字段_修改字段集合串

/// <summary>
/// 学生绩点流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public long id_CjStuPoint
{
get
{
return mlngid_CjStuPoint;
}
set
{
 mlngid_CjStuPoint = value;
}
}
/// <summary>
/// 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
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
 mstrid_Stu = value;
}
else
{
 mstrid_Stu = value;
}
}
}
/// <summary>
/// 成绩学期(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public int ScrTermSeq
{
get
{
return mintScrTermSeq;
}
set
{
 mintScrTermSeq = value;
}
}
/// <summary>
/// 学年(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrSchoolYear = value;
}
else
{
 mstrSchoolYear = value;
}
}
}
/// <summary>
/// SchoolTerm(说明:;字段类型:varchar;字段长度:2;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrSchoolTerm = value;
}
else
{
 mstrSchoolTerm = value;
}
}
}
/// <summary>
/// 总分(不详)(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public double TotalMark
{
get
{
return mdblTotalMark;
}
set
{
 mdblTotalMark = value;
}
}
/// <summary>
/// 平均绩点学分(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public double AveragePointMark
{
get
{
return mdblAveragePointMark;
}
set
{
 mdblAveragePointMark = value;
}
}
/// <summary>
/// 累积绩点学分(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public double AggregatePointMark
{
get
{
return mdblAggregatePointMark;
}
set
{
 mdblAggregatePointMark = value;
}
}
/// <summary>
/// 总绩点学分(说明:;字段类型:decimal;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public double TotalPointMark
{
get
{
return mdblTotalPointMark;
}
set
{
 mdblTotalPointMark = value;
}
}
/// <summary>
/// OperateMode(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
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
 mstrOperateMode = value;
}
else
{
 mstrOperateMode = value;
}
}
}
/// <summary>
/// 是否同步Web(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSynchToWeb
{
get
{
return mbolIsSynchToWeb;
}
set
{
 mbolIsSynchToWeb = value;
}
}
/// <summary>
/// 同步Web日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
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
 mstrSynchToWebDate = value;
}
else
{
 mstrSynchToWebDate = value;
}
}
}
/// <summary>
/// 同步Web用户(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
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
 mstrSynchToWebUser = value;
}
else
{
 mstrSynchToWebUser = value;
}
}
}
/// <summary>
/// UpdDate(说明:;字段类型:datetime;字段长度:16;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public DateTime UpdDate
{
get
{
return mdteUpdDate;
}
set
{
 mdteUpdDate = value;
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
}
}
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
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
 mstrModifyUserID = value;
}
else
{
 mstrModifyUserID = value;
}
}
}
/// <summary>
/// 系统字段_修改字段集合串(说明:;字段类型:str;字段长度:4;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string sf_UpdFldSetStr
{
get
{
return mstrsf_UpdFldSetStr;
}
set
{
if (value  ==  "")
{
 mstrsf_UpdFldSetStr = value;
}
else
{
 mstrsf_UpdFldSetStr = value;
}
}
}
}
}