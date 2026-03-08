
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPotenceSymbolForRoleEN
 表名:vQxPotenceSymbolForRole(00140047)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 09:57:41
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理
 模块英文名:PotenceMan
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
 /// 表vQxPotenceSymbolForRole的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_mId_vQxPotenceSymbolForRole
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vQxPotenceSymbolForRole(long lngmId)
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vQxPotenceSymbolForRole]类型的对象</returns>
public static implicit operator K_mId_vQxPotenceSymbolForRole(long value)
{
return new K_mId_vQxPotenceSymbolForRole(value);
}
}
 /// <summary>
 /// vPotenceSymbolForRole(vQxPotenceSymbolForRole)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxPotenceSymbolForRoleEN : clsEntityBase2
{
public const string _CurrTabName_S = "vQxPotenceSymbolForRole"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "RoleId", "RelaMid", "PotenceId", "SymbolForProgramme", "PotenceName", "PotenceTypeId", "PotenceTypeName", "SymbolName"};
//以下是属性变量

protected long mlngmId;    //流水号
protected string mstrRoleId;    //角色Id
protected long mlngRelaMid;    //流水号
protected string mstrPotenceId;    //权限ID
protected string mstrSymbolForProgramme;    //编程标志
protected string mstrPotenceName;    //权限名称
protected string mstrPotenceTypeId;    //权限类型Id
protected string mstrPotenceTypeName;    //权限类型名
protected string mstrSymbolName;    //标志名称


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId = "mId";    //流水号

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"RelaMid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RelaMid = "RelaMid";    //流水号

 /// <summary>
 /// 常量:"PotenceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PotenceId = "PotenceId";    //权限ID

 /// <summary>
 /// 常量:"SymbolForProgramme"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SymbolForProgramme = "SymbolForProgramme";    //编程标志

 /// <summary>
 /// 常量:"PotenceName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PotenceName = "PotenceName";    //权限名称

 /// <summary>
 /// 常量:"PotenceTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PotenceTypeId = "PotenceTypeId";    //权限类型Id

 /// <summary>
 /// 常量:"PotenceTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PotenceTypeName = "PotenceTypeName";    //权限类型名

 /// <summary>
 /// 常量:"SymbolName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SymbolName = "SymbolName";    //标志名称

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxPotenceSymbolForRoleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vQxPotenceSymbolForRole";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:流水号</param>
public clsvQxPotenceSymbolForRoleEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vQxPotenceSymbolForRole";
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
if (strAttributeName  ==  con_mId)
{
return mlngmId;
}
else if (strAttributeName  ==  con_RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  con_RelaMid)
{
return mlngRelaMid;
}
else if (strAttributeName  ==  con_PotenceId)
{
return mstrPotenceId;
}
else if (strAttributeName  ==  con_SymbolForProgramme)
{
return mstrSymbolForProgramme;
}
else if (strAttributeName  ==  con_PotenceName)
{
return mstrPotenceName;
}
else if (strAttributeName  ==  con_PotenceTypeId)
{
return mstrPotenceTypeId;
}
else if (strAttributeName  ==  con_PotenceTypeName)
{
return mstrPotenceTypeName;
}
else if (strAttributeName  ==  con_SymbolName)
{
return mstrSymbolName;
}
return null;
}
set
{
if (strAttributeName  ==  con_mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (strAttributeName  ==  con_RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(con_RoleId);
}
else if (strAttributeName  ==  con_RelaMid)
{
mlngRelaMid = TransNullToInt(value.ToString());
 AddUpdatedFld(con_RelaMid);
}
else if (strAttributeName  ==  con_PotenceId)
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(con_PotenceId);
}
else if (strAttributeName  ==  con_SymbolForProgramme)
{
mstrSymbolForProgramme = value.ToString();
 AddUpdatedFld(con_SymbolForProgramme);
}
else if (strAttributeName  ==  con_PotenceName)
{
mstrPotenceName = value.ToString();
 AddUpdatedFld(con_PotenceName);
}
else if (strAttributeName  ==  con_PotenceTypeId)
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(con_PotenceTypeId);
}
else if (strAttributeName  ==  con_PotenceTypeName)
{
mstrPotenceTypeName = value.ToString();
 AddUpdatedFld(con_PotenceTypeName);
}
else if (strAttributeName  ==  con_SymbolName)
{
mstrSymbolName = value.ToString();
 AddUpdatedFld(con_SymbolName);
}
}
}
public object this[int intIndex]
{
get
{
if (con_mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (con_RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (con_RelaMid  ==  AttributeName[intIndex])
{
return mlngRelaMid;
}
else if (con_PotenceId  ==  AttributeName[intIndex])
{
return mstrPotenceId;
}
else if (con_SymbolForProgramme  ==  AttributeName[intIndex])
{
return mstrSymbolForProgramme;
}
else if (con_PotenceName  ==  AttributeName[intIndex])
{
return mstrPotenceName;
}
else if (con_PotenceTypeId  ==  AttributeName[intIndex])
{
return mstrPotenceTypeId;
}
else if (con_PotenceTypeName  ==  AttributeName[intIndex])
{
return mstrPotenceTypeName;
}
else if (con_SymbolName  ==  AttributeName[intIndex])
{
return mstrSymbolName;
}
return null;
}
set
{
if (con_mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (con_RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(con_RoleId);
}
else if (con_RelaMid  ==  AttributeName[intIndex])
{
mlngRelaMid = TransNullToInt(value.ToString());
 AddUpdatedFld(con_RelaMid);
}
else if (con_PotenceId  ==  AttributeName[intIndex])
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(con_PotenceId);
}
else if (con_SymbolForProgramme  ==  AttributeName[intIndex])
{
mstrSymbolForProgramme = value.ToString();
 AddUpdatedFld(con_SymbolForProgramme);
}
else if (con_PotenceName  ==  AttributeName[intIndex])
{
mstrPotenceName = value.ToString();
 AddUpdatedFld(con_PotenceName);
}
else if (con_PotenceTypeId  ==  AttributeName[intIndex])
{
mstrPotenceTypeId = value.ToString();
 AddUpdatedFld(con_PotenceTypeId);
}
else if (con_PotenceTypeName  ==  AttributeName[intIndex])
{
mstrPotenceTypeName = value.ToString();
 AddUpdatedFld(con_PotenceTypeName);
}
else if (con_SymbolName  ==  AttributeName[intIndex])
{
mstrSymbolName = value.ToString();
 AddUpdatedFld(con_SymbolName);
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
 AddUpdatedFld(con_mId);
}
}
/// <summary>
/// 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleId = value;
}
else
{
 mstrRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_RoleId);
}
}
/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long RelaMid
{
get
{
return mlngRelaMid;
}
set
{
 mlngRelaMid = value;
//记录修改过的字段
 AddUpdatedFld(con_RelaMid);
}
}
/// <summary>
/// 权限ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PotenceId
{
get
{
return mstrPotenceId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPotenceId = value;
}
else
{
 mstrPotenceId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_PotenceId);
}
}
/// <summary>
/// 编程标志(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SymbolForProgramme
{
get
{
return mstrSymbolForProgramme;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSymbolForProgramme = value;
}
else
{
 mstrSymbolForProgramme = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SymbolForProgramme);
}
}
/// <summary>
/// 权限名称(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PotenceName
{
get
{
return mstrPotenceName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPotenceName = value;
}
else
{
 mstrPotenceName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_PotenceName);
}
}
/// <summary>
/// 权限类型Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PotenceTypeId
{
get
{
return mstrPotenceTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPotenceTypeId = value;
}
else
{
 mstrPotenceTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_PotenceTypeId);
}
}
/// <summary>
/// 权限类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PotenceTypeName
{
get
{
return mstrPotenceTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPotenceTypeName = value;
}
else
{
 mstrPotenceTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_PotenceTypeName);
}
}
/// <summary>
/// 标志名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SymbolName
{
get
{
return mstrSymbolName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSymbolName = value;
}
else
{
 mstrSymbolName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SymbolName);
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
  return mlngmId.ToString();
 }
 }
}
}