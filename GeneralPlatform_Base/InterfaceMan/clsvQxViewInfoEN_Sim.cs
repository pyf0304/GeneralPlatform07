
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxViewInfoEN_Sim
 表名:vQxViewInfo
 生成代码版本:2018.04.19.1
 生成日期:2018/04/20 12:40:32
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:界面管理
 模块英文名:InterfaceMan
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
 /// v界面信息(vQxViewInfo)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode_Sim)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxViewInfoEN_Sim 
{
//以下是属性变量

private string mstrViewId;    //界面编号
private string mstrViewName;    //界面名称
private string mstrViewCnName;    //界面中文名称
private string mstrFileName;    //文件名
private string mstrFilePath;    //文件路径
private string mstrDefaMenuName;    //缺省菜单名
private string mstrViewTypeCode;    //界面类型码
private string mstrDataBaseName;    //数据库名称
private string mstrQxPrjId;    //项目Id
private string mstrPrjName;    //工程名
private string mstrViewFunction;    //界面功能
private string mstrViewDetail;    //界面详细信息
private string mstrModuleId;    //模块号
private string mstrModuleName;    //模块名称
private string mstrUpdDate;    //修改日期
private string mstrUpdUserId;    //修改用户Id
private string mstrMemo;    //备注
private string mstrsf_UpdFldSetStr;    //系统字段_修改字段集合串

/// <summary>
/// 界面编号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string ViewId
{
get
{
return mstrViewId;
}
set
{
if (value  ==  "")
{
 mstrViewId = value;
}
else
{
 mstrViewId = value;
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
/// 界面中文名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string ViewCnName
{
get
{
return mstrViewCnName;
}
set
{
if (value  ==  "")
{
 mstrViewCnName = value;
}
else
{
 mstrViewCnName = value;
}
}
}
/// <summary>
/// 文件名(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string FileName
{
get
{
return mstrFileName;
}
set
{
if (value  ==  "")
{
 mstrFileName = value;
}
else
{
 mstrFileName = value;
}
}
}
/// <summary>
/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string FilePath
{
get
{
return mstrFilePath;
}
set
{
if (value  ==  "")
{
 mstrFilePath = value;
}
else
{
 mstrFilePath = value;
}
}
}
/// <summary>
/// 缺省菜单名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string DefaMenuName
{
get
{
return mstrDefaMenuName;
}
set
{
if (value  ==  "")
{
 mstrDefaMenuName = value;
}
else
{
 mstrDefaMenuName = value;
}
}
}
/// <summary>
/// 界面类型码(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string ViewTypeCode
{
get
{
return mstrViewTypeCode;
}
set
{
if (value  ==  "")
{
 mstrViewTypeCode = value;
}
else
{
 mstrViewTypeCode = value;
}
}
}
/// <summary>
/// 数据库名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseName
{
get
{
return mstrDataBaseName;
}
set
{
if (value  ==  "")
{
 mstrDataBaseName = value;
}
else
{
 mstrDataBaseName = value;
}
}
}
/// <summary>
/// 项目Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string QxPrjId
{
get
{
return mstrQxPrjId;
}
set
{
if (value  ==  "")
{
 mstrQxPrjId = value;
}
else
{
 mstrQxPrjId = value;
}
}
}
/// <summary>
/// 工程名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
}
}
/// <summary>
/// 界面功能(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string ViewFunction
{
get
{
return mstrViewFunction;
}
set
{
if (value  ==  "")
{
 mstrViewFunction = value;
}
else
{
 mstrViewFunction = value;
}
}
}
/// <summary>
/// 界面详细信息(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string ViewDetail
{
get
{
return mstrViewDetail;
}
set
{
if (value  ==  "")
{
 mstrViewDetail = value;
}
else
{
 mstrViewDetail = value;
}
}
}
/// <summary>
/// 模块号(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string ModuleId
{
get
{
return mstrModuleId;
}
set
{
if (value  ==  "")
{
 mstrModuleId = value;
}
else
{
 mstrModuleId = value;
}
}
}
/// <summary>
/// 模块名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string ModuleName
{
get
{
return mstrModuleName;
}
set
{
if (value  ==  "")
{
 mstrModuleName = value;
}
else
{
 mstrModuleName = value;
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