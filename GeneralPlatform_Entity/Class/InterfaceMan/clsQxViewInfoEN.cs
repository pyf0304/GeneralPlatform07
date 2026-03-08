
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxViewInfoEN
 表名:QxViewInfo(00140017)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:23:24
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:界面管理(InterfaceMan)
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
 /// 表QxViewInfo的关键字(ViewId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_ViewId_QxViewInfo
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strViewId">表关键字</param>
public K_ViewId_QxViewInfo(string strViewId)
{
if (IsValid(strViewId)) Value = strViewId;
else
{
Value = null;
}
}
private static bool IsValid(string strViewId)
{
if (string.IsNullOrEmpty(strViewId) == true) return false;
if (strViewId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ViewId_QxViewInfo]类型的对象</returns>
public static implicit operator K_ViewId_QxViewInfo(string value)
{
return new K_ViewId_QxViewInfo(value);
}
}
 /// <summary>
 /// 界面(QxViewInfo)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxViewInfoEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxViewInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 15;
public static string[] AttributeName = new string[] {"ViewId", "ViewName", "ViewCnName", "FileName", "FilePath", "DefaMenuName", "ViewTypeCode", "DataBaseName", "QxPrjId", "ViewFunction", "ViewDetail", "ModuleId", "UpdDate", "UpdUserId", "Memo"};

protected string mstrViewId;    //界面编号
protected string mstrViewName;    //界面名称
protected string mstrViewCnName;    //界面中文名称
protected string mstrFileName;    //文件名
protected string mstrFilePath;    //文件路径
protected string mstrDefaMenuName;    //缺省菜单名
protected string mstrViewTypeCode;    //界面类型码
protected string mstrDataBaseName;    //数据库名称
protected string mstrQxPrjId;    //项目Id
protected string mstrViewFunction;    //界面功能
protected string mstrViewDetail;    //界面详细信息
protected string mstrModuleId;    //模块号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxViewInfoEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("ViewId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strViewId">关键字:界面编号</param>
public clsQxViewInfoEN(string strViewId)
 {
strViewId = strViewId.Replace("'", "''");
if (strViewId.Length > 8)
{
throw new Exception("在表:QxViewInfo中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strViewId)  ==  true)
{
throw new Exception("在表:QxViewInfo中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  conQxViewInfo.ViewId)
{
return mstrViewId;
}
else if (strAttributeName  ==  conQxViewInfo.ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  conQxViewInfo.ViewCnName)
{
return mstrViewCnName;
}
else if (strAttributeName  ==  conQxViewInfo.FileName)
{
return mstrFileName;
}
else if (strAttributeName  ==  conQxViewInfo.FilePath)
{
return mstrFilePath;
}
else if (strAttributeName  ==  conQxViewInfo.DefaMenuName)
{
return mstrDefaMenuName;
}
else if (strAttributeName  ==  conQxViewInfo.ViewTypeCode)
{
return mstrViewTypeCode;
}
else if (strAttributeName  ==  conQxViewInfo.DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  conQxViewInfo.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxViewInfo.ViewFunction)
{
return mstrViewFunction;
}
else if (strAttributeName  ==  conQxViewInfo.ViewDetail)
{
return mstrViewDetail;
}
else if (strAttributeName  ==  conQxViewInfo.ModuleId)
{
return mstrModuleId;
}
else if (strAttributeName  ==  conQxViewInfo.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxViewInfo.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conQxViewInfo.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxViewInfo.ViewId)
{
mstrViewId = value.ToString();
 AddUpdatedFld(conQxViewInfo.ViewId);
}
else if (strAttributeName  ==  conQxViewInfo.ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(conQxViewInfo.ViewName);
}
else if (strAttributeName  ==  conQxViewInfo.ViewCnName)
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(conQxViewInfo.ViewCnName);
}
else if (strAttributeName  ==  conQxViewInfo.FileName)
{
mstrFileName = value.ToString();
 AddUpdatedFld(conQxViewInfo.FileName);
}
else if (strAttributeName  ==  conQxViewInfo.FilePath)
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conQxViewInfo.FilePath);
}
else if (strAttributeName  ==  conQxViewInfo.DefaMenuName)
{
mstrDefaMenuName = value.ToString();
 AddUpdatedFld(conQxViewInfo.DefaMenuName);
}
else if (strAttributeName  ==  conQxViewInfo.ViewTypeCode)
{
mstrViewTypeCode = value.ToString();
 AddUpdatedFld(conQxViewInfo.ViewTypeCode);
}
else if (strAttributeName  ==  conQxViewInfo.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(conQxViewInfo.DataBaseName);
}
else if (strAttributeName  ==  conQxViewInfo.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxViewInfo.QxPrjId);
}
else if (strAttributeName  ==  conQxViewInfo.ViewFunction)
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(conQxViewInfo.ViewFunction);
}
else if (strAttributeName  ==  conQxViewInfo.ViewDetail)
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(conQxViewInfo.ViewDetail);
}
else if (strAttributeName  ==  conQxViewInfo.ModuleId)
{
mstrModuleId = value.ToString();
 AddUpdatedFld(conQxViewInfo.ModuleId);
}
else if (strAttributeName  ==  conQxViewInfo.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxViewInfo.UpdDate);
}
else if (strAttributeName  ==  conQxViewInfo.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxViewInfo.UpdUserId);
}
else if (strAttributeName  ==  conQxViewInfo.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxViewInfo.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxViewInfo.ViewId  ==  AttributeName[intIndex])
{
return mstrViewId;
}
else if (conQxViewInfo.ViewName  ==  AttributeName[intIndex])
{
return mstrViewName;
}
else if (conQxViewInfo.ViewCnName  ==  AttributeName[intIndex])
{
return mstrViewCnName;
}
else if (conQxViewInfo.FileName  ==  AttributeName[intIndex])
{
return mstrFileName;
}
else if (conQxViewInfo.FilePath  ==  AttributeName[intIndex])
{
return mstrFilePath;
}
else if (conQxViewInfo.DefaMenuName  ==  AttributeName[intIndex])
{
return mstrDefaMenuName;
}
else if (conQxViewInfo.ViewTypeCode  ==  AttributeName[intIndex])
{
return mstrViewTypeCode;
}
else if (conQxViewInfo.DataBaseName  ==  AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (conQxViewInfo.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxViewInfo.ViewFunction  ==  AttributeName[intIndex])
{
return mstrViewFunction;
}
else if (conQxViewInfo.ViewDetail  ==  AttributeName[intIndex])
{
return mstrViewDetail;
}
else if (conQxViewInfo.ModuleId  ==  AttributeName[intIndex])
{
return mstrModuleId;
}
else if (conQxViewInfo.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxViewInfo.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conQxViewInfo.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxViewInfo.ViewId  ==  AttributeName[intIndex])
{
mstrViewId = value.ToString();
 AddUpdatedFld(conQxViewInfo.ViewId);
}
else if (conQxViewInfo.ViewName  ==  AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(conQxViewInfo.ViewName);
}
else if (conQxViewInfo.ViewCnName  ==  AttributeName[intIndex])
{
mstrViewCnName = value.ToString();
 AddUpdatedFld(conQxViewInfo.ViewCnName);
}
else if (conQxViewInfo.FileName  ==  AttributeName[intIndex])
{
mstrFileName = value.ToString();
 AddUpdatedFld(conQxViewInfo.FileName);
}
else if (conQxViewInfo.FilePath  ==  AttributeName[intIndex])
{
mstrFilePath = value.ToString();
 AddUpdatedFld(conQxViewInfo.FilePath);
}
else if (conQxViewInfo.DefaMenuName  ==  AttributeName[intIndex])
{
mstrDefaMenuName = value.ToString();
 AddUpdatedFld(conQxViewInfo.DefaMenuName);
}
else if (conQxViewInfo.ViewTypeCode  ==  AttributeName[intIndex])
{
mstrViewTypeCode = value.ToString();
 AddUpdatedFld(conQxViewInfo.ViewTypeCode);
}
else if (conQxViewInfo.DataBaseName  ==  AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(conQxViewInfo.DataBaseName);
}
else if (conQxViewInfo.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxViewInfo.QxPrjId);
}
else if (conQxViewInfo.ViewFunction  ==  AttributeName[intIndex])
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(conQxViewInfo.ViewFunction);
}
else if (conQxViewInfo.ViewDetail  ==  AttributeName[intIndex])
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(conQxViewInfo.ViewDetail);
}
else if (conQxViewInfo.ModuleId  ==  AttributeName[intIndex])
{
mstrModuleId = value.ToString();
 AddUpdatedFld(conQxViewInfo.ModuleId);
}
else if (conQxViewInfo.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxViewInfo.UpdDate);
}
else if (conQxViewInfo.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxViewInfo.UpdUserId);
}
else if (conQxViewInfo.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxViewInfo.Memo);
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
 AddUpdatedFld(conQxViewInfo.ViewId);
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
 AddUpdatedFld(conQxViewInfo.ViewName);
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
 AddUpdatedFld(conQxViewInfo.ViewCnName);
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
 AddUpdatedFld(conQxViewInfo.FileName);
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
 AddUpdatedFld(conQxViewInfo.FilePath);
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
 AddUpdatedFld(conQxViewInfo.DefaMenuName);
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
 AddUpdatedFld(conQxViewInfo.ViewTypeCode);
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
 AddUpdatedFld(conQxViewInfo.DataBaseName);
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
 AddUpdatedFld(conQxViewInfo.QxPrjId);
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
 AddUpdatedFld(conQxViewInfo.ViewFunction);
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
 AddUpdatedFld(conQxViewInfo.ViewDetail);
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
 AddUpdatedFld(conQxViewInfo.ModuleId);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
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
 AddUpdatedFld(conQxViewInfo.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
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
 AddUpdatedFld(conQxViewInfo.UpdUserId);
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
 AddUpdatedFld(conQxViewInfo.Memo);
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
 /// <summary>
 /// 界面(QxViewInfo)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxViewInfo
{
public const string _CurrTabName = "QxViewInfo"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ViewId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ViewId", "ViewName", "ViewCnName", "FileName", "FilePath", "DefaMenuName", "ViewTypeCode", "DataBaseName", "QxPrjId", "ViewFunction", "ViewDetail", "ModuleId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ViewId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewId = "ViewId";    //界面编号

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"ViewCnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewCnName = "ViewCnName";    //界面中文名称

 /// <summary>
 /// 常量:"FileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FileName = "FileName";    //文件名

 /// <summary>
 /// 常量:"FilePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FilePath = "FilePath";    //文件路径

 /// <summary>
 /// 常量:"DefaMenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DefaMenuName = "DefaMenuName";    //缺省菜单名

 /// <summary>
 /// 常量:"ViewTypeCode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewTypeCode = "ViewTypeCode";    //界面类型码

 /// <summary>
 /// 常量:"DataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseName = "DataBaseName";    //数据库名称

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"ViewFunction"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewFunction = "ViewFunction";    //界面功能

 /// <summary>
 /// 常量:"ViewDetail"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ViewDetail = "ViewDetail";    //界面详细信息

 /// <summary>
 /// 常量:"ModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ModuleId = "ModuleId";    //模块号

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}