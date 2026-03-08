
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserCodePathEN
 表名:vQxUserCodePath(00140064)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:47:24
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
 /// 表vQxUserCodePath的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vQxUserCodePath
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
public K_mId_vQxUserCodePath(long lngmId)
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
 /// <returns>返回:[K_mId_vQxUserCodePath]类型的对象</returns>
public static implicit operator K_mId_vQxUserCodePath(long value)
{
return new K_mId_vQxUserCodePath(value);
}
}
 /// <summary>
 /// v用户生成路径(vQxUserCodePath)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxUserCodePathEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxUserCodePath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 17;
public static string[] AttributeName = new string[] {"mId", "QxPrjId", "PrjName", "UserId", "UserName", "CodePath", "CodePathBackup", "DepartmentId", "DepartmentName", "QxCodeTypeId", "CodeTypeName", "IsTemplate", "UpdUserId", "UpdDate", "UserStateName", "UserStateId", "Memo"};

protected long mlngmId;    //流水号
protected string mstrQxPrjId;    //项目Id
protected string mstrPrjName;    //工程名
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrCodePath;    //代码路径
protected string mstrCodePathBackup;    //备份代码路径
protected string mstrDepartmentId;    //部门Id
protected string mstrDepartmentName;    //部门名
protected string mstrQxCodeTypeId;    //代码类型Id
protected string mstrCodeTypeName;    //代码类型名
protected bool mbolIsTemplate;    //是否模板
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrUserStateName;    //用户状态名
protected string mstrUserStateId;    //用户状态Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxUserCodePathEN()
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
public clsvQxUserCodePathEN(long lngmId)
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
if (strAttributeName  ==  convQxUserCodePath.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convQxUserCodePath.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxUserCodePath.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxUserCodePath.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convQxUserCodePath.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convQxUserCodePath.CodePath)
{
return mstrCodePath;
}
else if (strAttributeName  ==  convQxUserCodePath.CodePathBackup)
{
return mstrCodePathBackup;
}
else if (strAttributeName  ==  convQxUserCodePath.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  convQxUserCodePath.DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  convQxUserCodePath.QxCodeTypeId)
{
return mstrQxCodeTypeId;
}
else if (strAttributeName  ==  convQxUserCodePath.CodeTypeName)
{
return mstrCodeTypeName;
}
else if (strAttributeName  ==  convQxUserCodePath.IsTemplate)
{
return mbolIsTemplate;
}
else if (strAttributeName  ==  convQxUserCodePath.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convQxUserCodePath.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxUserCodePath.UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  convQxUserCodePath.UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  convQxUserCodePath.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxUserCodePath.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserCodePath.mId);
}
else if (strAttributeName  ==  convQxUserCodePath.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxUserCodePath.QxPrjId);
}
else if (strAttributeName  ==  convQxUserCodePath.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxUserCodePath.PrjName);
}
else if (strAttributeName  ==  convQxUserCodePath.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserCodePath.UserId);
}
else if (strAttributeName  ==  convQxUserCodePath.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUserCodePath.UserName);
}
else if (strAttributeName  ==  convQxUserCodePath.CodePath)
{
mstrCodePath = value.ToString();
 AddUpdatedFld(convQxUserCodePath.CodePath);
}
else if (strAttributeName  ==  convQxUserCodePath.CodePathBackup)
{
mstrCodePathBackup = value.ToString();
 AddUpdatedFld(convQxUserCodePath.CodePathBackup);
}
else if (strAttributeName  ==  convQxUserCodePath.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convQxUserCodePath.DepartmentId);
}
else if (strAttributeName  ==  convQxUserCodePath.DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convQxUserCodePath.DepartmentName);
}
else if (strAttributeName  ==  convQxUserCodePath.QxCodeTypeId)
{
mstrQxCodeTypeId = value.ToString();
 AddUpdatedFld(convQxUserCodePath.QxCodeTypeId);
}
else if (strAttributeName  ==  convQxUserCodePath.CodeTypeName)
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convQxUserCodePath.CodeTypeName);
}
else if (strAttributeName  ==  convQxUserCodePath.IsTemplate)
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUserCodePath.IsTemplate);
}
else if (strAttributeName  ==  convQxUserCodePath.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxUserCodePath.UpdUserId);
}
else if (strAttributeName  ==  convQxUserCodePath.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUserCodePath.UpdDate);
}
else if (strAttributeName  ==  convQxUserCodePath.UserStateName)
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convQxUserCodePath.UserStateName);
}
else if (strAttributeName  ==  convQxUserCodePath.UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convQxUserCodePath.UserStateId);
}
else if (strAttributeName  ==  convQxUserCodePath.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserCodePath.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxUserCodePath.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convQxUserCodePath.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxUserCodePath.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxUserCodePath.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convQxUserCodePath.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convQxUserCodePath.CodePath  ==  AttributeName[intIndex])
{
return mstrCodePath;
}
else if (convQxUserCodePath.CodePathBackup  ==  AttributeName[intIndex])
{
return mstrCodePathBackup;
}
else if (convQxUserCodePath.DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (convQxUserCodePath.DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (convQxUserCodePath.QxCodeTypeId  ==  AttributeName[intIndex])
{
return mstrQxCodeTypeId;
}
else if (convQxUserCodePath.CodeTypeName  ==  AttributeName[intIndex])
{
return mstrCodeTypeName;
}
else if (convQxUserCodePath.IsTemplate  ==  AttributeName[intIndex])
{
return mbolIsTemplate;
}
else if (convQxUserCodePath.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convQxUserCodePath.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxUserCodePath.UserStateName  ==  AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (convQxUserCodePath.UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (convQxUserCodePath.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxUserCodePath.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxUserCodePath.mId);
}
else if (convQxUserCodePath.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxUserCodePath.QxPrjId);
}
else if (convQxUserCodePath.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxUserCodePath.PrjName);
}
else if (convQxUserCodePath.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxUserCodePath.UserId);
}
else if (convQxUserCodePath.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convQxUserCodePath.UserName);
}
else if (convQxUserCodePath.CodePath  ==  AttributeName[intIndex])
{
mstrCodePath = value.ToString();
 AddUpdatedFld(convQxUserCodePath.CodePath);
}
else if (convQxUserCodePath.CodePathBackup  ==  AttributeName[intIndex])
{
mstrCodePathBackup = value.ToString();
 AddUpdatedFld(convQxUserCodePath.CodePathBackup);
}
else if (convQxUserCodePath.DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convQxUserCodePath.DepartmentId);
}
else if (convQxUserCodePath.DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convQxUserCodePath.DepartmentName);
}
else if (convQxUserCodePath.QxCodeTypeId  ==  AttributeName[intIndex])
{
mstrQxCodeTypeId = value.ToString();
 AddUpdatedFld(convQxUserCodePath.QxCodeTypeId);
}
else if (convQxUserCodePath.CodeTypeName  ==  AttributeName[intIndex])
{
mstrCodeTypeName = value.ToString();
 AddUpdatedFld(convQxUserCodePath.CodeTypeName);
}
else if (convQxUserCodePath.IsTemplate  ==  AttributeName[intIndex])
{
mbolIsTemplate = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxUserCodePath.IsTemplate);
}
else if (convQxUserCodePath.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxUserCodePath.UpdUserId);
}
else if (convQxUserCodePath.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxUserCodePath.UpdDate);
}
else if (convQxUserCodePath.UserStateName  ==  AttributeName[intIndex])
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(convQxUserCodePath.UserStateName);
}
else if (convQxUserCodePath.UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(convQxUserCodePath.UserStateId);
}
else if (convQxUserCodePath.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxUserCodePath.Memo);
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
 AddUpdatedFld(convQxUserCodePath.mId);
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
 AddUpdatedFld(convQxUserCodePath.QxPrjId);
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
 AddUpdatedFld(convQxUserCodePath.PrjName);
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
 AddUpdatedFld(convQxUserCodePath.UserId);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserCodePath.UserName);
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
 AddUpdatedFld(convQxUserCodePath.CodePath);
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
 AddUpdatedFld(convQxUserCodePath.CodePathBackup);
}
}
/// <summary>
/// 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentId
{
get
{
return mstrDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentId = value;
}
else
{
 mstrDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserCodePath.DepartmentId);
}
}
/// <summary>
/// 部门名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DepartmentName
{
get
{
return mstrDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDepartmentName = value;
}
else
{
 mstrDepartmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserCodePath.DepartmentName);
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
 AddUpdatedFld(convQxUserCodePath.QxCodeTypeId);
}
}
/// <summary>
/// 代码类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CodeTypeName
{
get
{
return mstrCodeTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCodeTypeName = value;
}
else
{
 mstrCodeTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserCodePath.CodeTypeName);
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
 AddUpdatedFld(convQxUserCodePath.IsTemplate);
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
 AddUpdatedFld(convQxUserCodePath.UpdUserId);
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
 AddUpdatedFld(convQxUserCodePath.UpdDate);
}
}
/// <summary>
/// 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserStateName
{
get
{
return mstrUserStateName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserStateName = value;
}
else
{
 mstrUserStateName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserCodePath.UserStateName);
}
}
/// <summary>
/// 用户状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserStateId
{
get
{
return mstrUserStateId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserStateId = value;
}
else
{
 mstrUserStateId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxUserCodePath.UserStateId);
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
 AddUpdatedFld(convQxUserCodePath.Memo);
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
 /// v用户生成路径(vQxUserCodePath)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxUserCodePath
{
public const string _CurrTabName = "vQxUserCodePath"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "QxPrjId", "PrjName", "UserId", "UserName", "CodePath", "CodePathBackup", "DepartmentId", "DepartmentName", "QxCodeTypeId", "CodeTypeName", "IsTemplate", "UpdUserId", "UpdDate", "UserStateName", "UserStateId", "Memo"};
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
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

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
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentId = "DepartmentId";    //部门Id

 /// <summary>
 /// 常量:"DepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentName = "DepartmentName";    //部门名

 /// <summary>
 /// 常量:"QxCodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxCodeTypeId = "QxCodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"CodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeName = "CodeTypeName";    //代码类型名

 /// <summary>
 /// 常量:"IsTemplate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsTemplate = "IsTemplate";    //是否模板

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UserStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateName = "UserStateName";    //用户状态名

 /// <summary>
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserStateId = "UserStateId";    //用户状态Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}