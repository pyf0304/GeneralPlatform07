
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxViewInfoEN
 表名:vQxViewInfo(00140029)
 生成代码版本:2019.07.12.1
 生成日期:2019/07/12 10:42:42
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:界面管理
 模块英文名:InterfaceMan
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
 /// 表vQxViewInfo的关键字(ViewId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_ViewId_vQxViewInfo
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strViewId">表关键字</param>
public K_ViewId_vQxViewInfo(string strViewId)
{
if (IsValid(strViewId)) Value = strViewId;
else
{
Value = null;
}
}
private static bool IsValid(string strViewId)
{
if (strViewId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewId_vQxViewInfo]类型的对象</returns>
public static implicit operator K_ViewId_vQxViewInfo(string value)
{
return new K_ViewId_vQxViewInfo(value);
}
}
 /// <summary>
 /// v界面信息(vQxViewInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxViewInfoEN : clsEntityBase2
{
public const string _CurrTabName_S = "vQxViewInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"ViewId", "ViewName", "ViewCnName", "FileName", "FilePath", "DefaMenuName", "ViewTypeCode", "DataBaseName", "QxPrjId", "PrjName", "ViewFunction", "ViewDetail", "ModuleId", "ModuleName", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量

protected string mstrViewId;    //界面编号
protected string mstrViewName;    //界面名称
protected string mstrViewCnName;    //界面中文名称
protected string mstrFileName;    //文件名
protected string mstrFilePath;    //文件路径
protected string mstrDefaMenuName;    //缺省菜单名
protected string mstrViewTypeCode;    //界面类型码
protected string mstrDataBaseName;    //数据库名称
protected string mstrQxPrjId;    //项目Id
protected string mstrPrjName;    //工程名
protected string mstrViewFunction;    //界面功能
protected string mstrViewDetail;    //界面详细信息
protected string mstrModuleId;    //模块号
protected string mstrModuleName;    //模块名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewId = "ViewId";    //界面编号

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"ViewCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewCnName = "ViewCnName";    //界面中文名称

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FileName = "FileName";    //文件名

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FilePath = "FilePath";    //文件路径

 /// <summary>
 /// 常量:"DefaMenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DefaMenuName = "DefaMenuName";    //缺省菜单名

 /// <summary>
 /// 常量:"ViewTypeCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewTypeCode = "ViewTypeCode";    //界面类型码

 /// <summary>
 /// 常量:"DataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DataBaseName = "DataBaseName";    //数据库名称

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjName = "PrjName";    //工程名

 /// <summary>
 /// 常量:"ViewFunction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewFunction = "ViewFunction";    //界面功能

 /// <summary>
 /// 常量:"ViewDetail"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewDetail = "ViewDetail";    //界面详细信息

 /// <summary>
 /// 常量:"ModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ModuleId = "ModuleId";    //模块号

 /// <summary>
 /// 常量:"ModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ModuleName = "ModuleName";    //模块名称

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
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxViewInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vQxViewInfo";
 lstKeyFldNames.Add("ViewId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strViewId">关键字:界面编号</param>
public clsvQxViewInfoEN(string strViewId)
 {
strViewId = strViewId.Replace("'", "''");
if (strViewId.Length > 8)
{
throw new Exception("在表:vQxViewInfo中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewId)  ==  true)
{
throw new Exception("在表:vQxViewInfo中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrViewId = strViewId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vQxViewInfo";
 lstKeyFldNames.Add("ViewId");
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
if (strAttributeName  ==  con_ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  con_ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  con_ViewCnName)
{
return mstrViewCnName;
}
else if (strAttributeName  ==  con_FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  con_FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  con_DefaMenuName)
{
return mstrDefaMenuName;
}
else if (strAttributeName  ==  con_ViewTypeCode)
{
return mstrViewTypeCode;
}
else if (strAttributeName  ==  con_DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  con_QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  con_PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  con_ViewFunction)
{
return mstrViewFunction;
}
else if (strAttributeName  ==  con_ViewDetail)
{
return mstrViewDetail;
}
else if (strAttributeName  ==  con_ModuleId)
{
return mstrModuleId;
}
else if (strAttributeName  ==  con_ModuleName)
{
return mstrModuleName;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(con_ViewId);
}
else if (strAttributeName  ==  con_ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(con_ViewName);
}
else if (strAttributeName  ==  con_ViewCnName)
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(con_ViewCnName);
}
else if (strAttributeName  ==  con_FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(con_FileName);
}
else if (strAttributeName  ==  con_FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(con_FilePath);
}
else if (strAttributeName  ==  con_DefaMenuName)
{
mstrDefaMenuName = value.ToString();
 AddUpdatedFld(con_DefaMenuName);
}
else if (strAttributeName  ==  con_ViewTypeCode)
{
mstrViewTypeCode = value.ToString();
 AddUpdatedFld(con_ViewTypeCode);
}
else if (strAttributeName  ==  con_DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(con_DataBaseName);
}
else if (strAttributeName  ==  con_QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(con_QxPrjId);
}
else if (strAttributeName  ==  con_PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(con_PrjName);
}
else if (strAttributeName  ==  con_ViewFunction)
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(con_ViewFunction);
}
else if (strAttributeName  ==  con_ViewDetail)
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(con_ViewDetail);
}
else if (strAttributeName  ==  con_ModuleId)
{
mstrModuleId = value.ToString();
 AddUpdatedFld(con_ModuleId);
}
else if (strAttributeName  ==  con_ModuleName)
{
mstrModuleName = value.ToString();
 AddUpdatedFld(con_ModuleName);
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
if (con_ViewId  ==  AttributeName[intIndex])
{
return mstrViewId;
}
else if (con_ViewName  ==  AttributeName[intIndex])
{
return mstrViewName;
}
else if (con_ViewCnName  ==  AttributeName[intIndex])
{
return mstrViewCnName;
}
else if (con_FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (con_FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (con_DefaMenuName  ==  AttributeName[intIndex])
{
return mstrDefaMenuName;
}
else if (con_ViewTypeCode  ==  AttributeName[intIndex])
{
return mstrViewTypeCode;
}
else if (con_DataBaseName  ==  AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (con_QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (con_PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (con_ViewFunction  ==  AttributeName[intIndex])
{
return mstrViewFunction;
}
else if (con_ViewDetail  ==  AttributeName[intIndex])
{
return mstrViewDetail;
}
else if (con_ModuleId  ==  AttributeName[intIndex])
{
return mstrModuleId;
}
else if (con_ModuleName  ==  AttributeName[intIndex])
{
return mstrModuleName;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_ViewId  ==  AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(con_ViewId);
}
else if (con_ViewName  ==  AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(con_ViewName);
}
else if (con_ViewCnName  ==  AttributeName[intIndex])
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(con_ViewCnName);
}
else if (con_FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(con_FileName);
}
else if (con_FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(con_FilePath);
}
else if (con_DefaMenuName  ==  AttributeName[intIndex])
{
mstrDefaMenuName = value.ToString();
 AddUpdatedFld(con_DefaMenuName);
}
else if (con_ViewTypeCode  ==  AttributeName[intIndex])
{
mstrViewTypeCode = value.ToString();
 AddUpdatedFld(con_ViewTypeCode);
}
else if (con_DataBaseName  ==  AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(con_DataBaseName);
}
else if (con_QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(con_QxPrjId);
}
else if (con_PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(con_PrjName);
}
else if (con_ViewFunction  ==  AttributeName[intIndex])
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(con_ViewFunction);
}
else if (con_ViewDetail  ==  AttributeName[intIndex])
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(con_ViewDetail);
}
else if (con_ModuleId  ==  AttributeName[intIndex])
{
mstrModuleId = value.ToString();
 AddUpdatedFld(con_ModuleId);
}
else if (con_ModuleName  ==  AttributeName[intIndex])
{
mstrModuleName = value.ToString();
 AddUpdatedFld(con_ModuleName);
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
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// 界面编号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrViewId = value;
}
else
{
 mstrViewId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ViewId);
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
 AddUpdatedFld(con_ViewName);
}
}
/// <summary>
/// 界面中文名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrViewCnName = value;
}
else
{
 mstrViewCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ViewCnName);
}
}
/// <summary>
/// 文件名(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrFileName = value;
}
else
{
 mstrFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FileName);
}
}
/// <summary>
/// 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrFilePath = value;
}
else
{
 mstrFilePath = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FilePath);
}
}
/// <summary>
/// 缺省菜单名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrDefaMenuName = value;
}
else
{
 mstrDefaMenuName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_DefaMenuName);
}
}
/// <summary>
/// 界面类型码(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrViewTypeCode = value;
}
else
{
 mstrViewTypeCode = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ViewTypeCode);
}
}
/// <summary>
/// 数据库名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrDataBaseName = value;
}
else
{
 mstrDataBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_DataBaseName);
}
}
/// <summary>
/// 项目Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrQxPrjId = value;
}
else
{
 mstrQxPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_QxPrjId);
}
}
/// <summary>
/// 工程名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_PrjName);
}
}
/// <summary>
/// 界面功能(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrViewFunction = value;
}
else
{
 mstrViewFunction = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ViewFunction);
}
}
/// <summary>
/// 界面详细信息(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrViewDetail = value;
}
else
{
 mstrViewDetail = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ViewDetail);
}
}
/// <summary>
/// 模块号(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrModuleId = value;
}
else
{
 mstrModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ModuleId);
}
}
/// <summary>
/// 模块名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
mintErrNo = 1;
 mstrModuleName = value;
}
else
{
 mstrModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ModuleName);
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
  return mstrViewId;
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
  return mstrViewName;
 }
 }
}
}