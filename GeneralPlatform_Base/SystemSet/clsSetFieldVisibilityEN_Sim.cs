
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSetFieldVisibilityEN_Sim
 表名:SetFieldVisibility
 生成代码版本:2018.04.19.1
 生成日期:2018/04/20 12:38:35
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置
 模块英文名:SystemSet
 框架-层名:实体层-简化
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
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
 /// 设置字段可视性(SetFieldVisibility)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode_Sim)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSetFieldVisibilityEN_Sim 
{
//以下是属性变量

private long mlngmId;    //流水号
private string mstrid_School;    //学校流水号
private string mstrViewName;    //界面名称
private string mstrFieldName;    //字段名
private string mstrCtrlType;    //控件类型
private bool mbolIsVisible;    //IsVisible
private string mstrMemo;    //备注
private string mstrUpdDate;    //修改日期
private string mstrUpdUserId;    //修改用户Id
private string mstrFuncModuleId;    //FuncModuleId
private string mstrCaption;    //Caption
private string mstrsf_UpdFldSetStr;    //系统字段_修改字段集合串

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrid_School = value;
}
else
{
 mstrid_School = value;
}
}
}
/// <summary>
/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrViewName = value;
}
else
{
 mstrViewName = value;
}
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrFieldName = value;
}
else
{
 mstrFieldName = value;
}
}
}
/// <summary>
/// 控件类型(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrCtrlType = value;
}
else
{
 mstrCtrlType = value;
}
}
}
/// <summary>
/// IsVisible(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
}
}
/// <summary>
/// FuncModuleId(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
}
}
/// <summary>
/// Caption(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string Caption
{
get
{
return mstrCaption;
}
set
{
if (value  ==  "")
{
 mstrCaption = value;
}
else
{
 mstrCaption = value;
}
}
}
/// <summary>
/// 系统字段_修改字段集合串(说明:;字段类型:str;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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