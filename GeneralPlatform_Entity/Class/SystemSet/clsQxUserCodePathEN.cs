
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserCodePathEN
 表名:QxUserCodePath(00140056)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:42:04
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:系统设置(SystemSet)
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
 /// 表QxUserCodePath的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QxUserCodePath
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_QxUserCodePath(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_QxUserCodePath]类型的对象</returns>
public static implicit operator K_mId_QxUserCodePath(long value)
{
return new K_mId_QxUserCodePath(value);
}
}
 /// <summary>
 /// 用户生成路径(QxUserCodePath)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserCodePathEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUserCodePath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"mId", "QxPrjId", "UserId", "QxCodeTypeId", "CodePath", "CodePathBackup", "IsTemplate", "UpdDate", "UpdUserId", "Memo", "IsGeneReport"};

protected long mlngmId;    //流水号
protected string mstrQxPrjId;    //项目Id
protected string mstrUserId;    //用户ID
protected string mstrQxCodeTypeId;    //代码类型Id
protected string mstrCodePath;    //代码路径
protected string mstrCodePathBackup;    //备份代码路径
protected bool mbolIsTemplate;    //是否模板
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected bool mbolIsGeneReport;    //IsGeneReport

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserCodePathEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:流水号</param>
public clsQxUserCodePathEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  conQxUserCodePath.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQxUserCodePath.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxUserCodePath.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conQxUserCodePath.QxCodeTypeId)
{
return mstrQxCodeTypeId;
}
else if (strAttributeName  ==  conQxUserCodePath.CodePath)
{
return mstrCodePath;
}
else if (strAttributeName  ==  conQxUserCodePath.CodePathBackup)
{
return mstrCodePathBackup;
}
else if (strAttributeName  ==  conQxUserCodePath.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  conQxUserCodePath.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxUserCodePath.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conQxUserCodePath.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conQxUserCodePath.IsGeneReport)
{
return mbolIsGeneReport;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUserCodePath.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserCodePath.mId);
}
else if (strAttributeName  ==  conQxUserCodePath.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserCodePath.QxPrjId);
}
else if (strAttributeName  ==  conQxUserCodePath.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserCodePath.UserId);
}
else if (strAttributeName  ==  conQxUserCodePath.QxCodeTypeId)
{
mstrQxCodeTypeId = value.ToString();
 AddUpdatedFld(conQxUserCodePath.QxCodeTypeId);
}
else if (strAttributeName  ==  conQxUserCodePath.CodePath)
{
mstrCodePath = value.ToString();
 AddUpdatedFld(conQxUserCodePath.CodePath);
}
else if (strAttributeName  ==  conQxUserCodePath.CodePathBackup)
{
mstrCodePathBackup = value.ToString();
 AddUpdatedFld(conQxUserCodePath.CodePathBackup);
}
else if (strAttributeName  ==  conQxUserCodePath.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserCodePath.IsTemplate);
}
else if (strAttributeName  ==  conQxUserCodePath.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUserCodePath.UpdDate);
}
else if (strAttributeName  ==  conQxUserCodePath.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxUserCodePath.UpdUserId);
}
else if (strAttributeName  ==  conQxUserCodePath.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserCodePath.Memo);
}
else if (strAttributeName  ==  conQxUserCodePath.IsGeneReport)
{
mbolIsGeneReport = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserCodePath.IsGeneReport);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUserCodePath.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conQxUserCodePath.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxUserCodePath.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conQxUserCodePath.QxCodeTypeId  ==  AttributeName[intIndex])
{
return mstrQxCodeTypeId;
}
else if (conQxUserCodePath.CodePath  ==  AttributeName[intIndex])
{
return mstrCodePath;
}
else if (conQxUserCodePath.CodePathBackup  ==  AttributeName[intIndex])
{
return mstrCodePathBackup;
}
else if (conQxUserCodePath.IsTemplate  ==  AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (conQxUserCodePath.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxUserCodePath.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conQxUserCodePath.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conQxUserCodePath.IsGeneReport  ==  AttributeName[intIndex])
{
return mbolIsGeneReport;
}
return null;
}
set
{
if (conQxUserCodePath.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserCodePath.mId);
}
else if (conQxUserCodePath.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserCodePath.QxPrjId);
}
else if (conQxUserCodePath.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserCodePath.UserId);
}
else if (conQxUserCodePath.QxCodeTypeId  ==  AttributeName[intIndex])
{
mstrQxCodeTypeId = value.ToString();
 AddUpdatedFld(conQxUserCodePath.QxCodeTypeId);
}
else if (conQxUserCodePath.CodePath  ==  AttributeName[intIndex])
{
mstrCodePath = value.ToString();
 AddUpdatedFld(conQxUserCodePath.CodePath);
}
else if (conQxUserCodePath.CodePathBackup  ==  AttributeName[intIndex])
{
mstrCodePathBackup = value.ToString();
 AddUpdatedFld(conQxUserCodePath.CodePathBackup);
}
else if (conQxUserCodePath.IsTemplate  ==  AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserCodePath.IsTemplate);
}
else if (conQxUserCodePath.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxUserCodePath.UpdDate);
}
else if (conQxUserCodePath.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxUserCodePath.UpdUserId);
}
else if (conQxUserCodePath.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserCodePath.Memo);
}
else if (conQxUserCodePath.IsGeneReport  ==  AttributeName[intIndex])
{
mbolIsGeneReport = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserCodePath.IsGeneReport);
}
}
}

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
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
//记录修改过的字段
 AddUpdatedFld(conQxUserCodePath.mId);
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
 AddUpdatedFld(conQxUserCodePath.QxPrjId);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserCodePath.UserId);
}
}
/// <summary>
/// 代码类型Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QxCodeTypeId
{
get
{
return mstrQxCodeTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQxCodeTypeId = value;
}
else
{
 mstrQxCodeTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserCodePath.QxCodeTypeId);
}
}
/// <summary>
/// 代码路径(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodePath
{
get
{
return mstrCodePath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodePath = value;
}
else
{
 mstrCodePath = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserCodePath.CodePath);
}
}
/// <summary>
/// 备份代码路径(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodePathBackup
{
get
{
return mstrCodePathBackup;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodePathBackup = value;
}
else
{
 mstrCodePathBackup = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserCodePath.CodePathBackup);
}
}
/// <summary>
/// 是否模板(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsTemplate
{
get
{
return mbolIsTemplate;
}
set
{
 mbolIsTemplate = value;
//记录修改过的字段
 AddUpdatedFld(conQxUserCodePath.IsTemplate);
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
 AddUpdatedFld(conQxUserCodePath.UpdDate);
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
 AddUpdatedFld(conQxUserCodePath.UpdUserId);
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
 AddUpdatedFld(conQxUserCodePath.Memo);
}
}
/// <summary>
/// IsGeneReport(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsGeneReport
{
get
{
return mbolIsGeneReport;
}
set
{
 mbolIsGeneReport = value;
//记录修改过的字段
 AddUpdatedFld(conQxUserCodePath.IsGeneReport);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 用户生成路径(QxUserCodePath)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUserCodePath
{
public const string _CurrTabName = "QxUserCodePath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "QxPrjId", "UserId", "QxCodeTypeId", "CodePath", "CodePathBackup", "IsTemplate", "UpdDate", "UpdUserId", "Memo", "IsGeneReport"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //流水号

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"QxCodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxCodeTypeId = "QxCodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"CodePath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodePath = "CodePath";    //代码路径

 /// <summary>
 /// 常量:"CodePathBackup"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodePathBackup = "CodePathBackup";    //备份代码路径

 /// <summary>
 /// 常量:"IsTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTemplate = "IsTemplate";    //是否模板

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

 /// <summary>
 /// 常量:"IsGeneReport"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsGeneReport = "IsGeneReport";    //IsGeneReport
}

}