
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExportExcel4UsersEN_Sim
 表名:ExportExcel4Users
 生成代码版本:2017.05.08.1
 生成日期:2017/05/08 11:04:55
 生成者:
 工程名称:统一平台
 工程ID:0014
 模块中文名:系统设置
 模块英文名:SystemSet
 框架-层名:实体层-简化
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
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
 /// 导出Excel用户字段表(ExportExcel4Users)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode_Sim)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsExportExcel4UsersEN_Sim 
{
//以下是属性变量

private long mlngmId;    //流水号
private string mstrid_ExportExcel4Users;    //导出Excel用户字段流水号
private string mstrFieldName;    //字段名
private string mstrFieldCnName;    //字段中文名称
private bool mbolIsExport;    //是否导出
private int mintOrderNum;    //排序号
private string mstrUpdDate;    //修改日期
private string mstrUpdUserId;    //修改用户Id
private string mstrMemo;    //备注
protected string mstrsf_UpdFldSetStr;    //系统字段_修改字段集合串

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
/// 导出Excel用户字段流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string id_ExportExcel4Users
{
get
{
return mstrid_ExportExcel4Users;
}
set
{
if (value  ==  "")
{
 mstrid_ExportExcel4Users = value;
}
else
{
 mstrid_ExportExcel4Users = value;
}
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
/// 字段中文名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string FieldCnName
{
get
{
return mstrFieldCnName;
}
set
{
if (value  ==  "")
{
 mstrFieldCnName = value;
}
else
{
 mstrFieldCnName = value;
}
}
}
/// <summary>
/// 是否导出(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public bool IsExport
{
get
{
return mbolIsExport;
}
set
{
 mbolIsExport = value;
}
}
/// <summary>
/// 排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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