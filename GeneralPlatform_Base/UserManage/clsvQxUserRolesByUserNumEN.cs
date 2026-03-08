
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserRolesByUserNumEN
 表名:vQxUserRolesByUserNum(00140081)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 09:58:08
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
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
 /// 表vQxUserRolesByUserNum的关键字(RoleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_RoleId_vQxUserRolesByUserNum
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRoleId">表关键字</param>
public K_RoleId_vQxUserRolesByUserNum(string strRoleId)
{
if (IsValid(strRoleId)) Value = strRoleId;
else
{
Value = null;
}
}
private static bool IsValid(string strRoleId)
{
if (string.IsNullOrEmpty(strRoleId) == true) return false;
if (strRoleId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RoleId_vQxUserRolesByUserNum]类型的对象</returns>
public static implicit operator K_RoleId_vQxUserRolesByUserNum(string value)
{
return new K_RoleId_vQxUserRolesByUserNum(value);
}
}
 /// <summary>
 /// v角色By用户数(vQxUserRolesByUserNum)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxUserRolesByUserNumEN : clsEntityBase2
{
public const string _CurrTabName_S = "vQxUserRolesByUserNum"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"RoleId", "RoleName", "RoleENName", "RoleIndex", "QxPrjId", "PrjName", "IsInUse", "UpdDate", "UpdUserId", "Memo", "UserNum"};
//以下是属性变量

protected string mstrRoleId;    //角色Id
protected string mstrRoleName;    //角色名称
protected string mstrRoleENName;    //角色英文名
protected int mintRoleIndex;    //角色序号
protected string mstrQxPrjId;    //项目Id
protected string mstrPrjName;    //工程名
protected bool mbolIsInUse;    //是否在使用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected int mintUserNum;    //用户数


 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"RoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RoleName = "RoleName";    //角色名称

 /// <summary>
 /// 常量:"RoleENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RoleENName = "RoleENName";    //角色英文名

 /// <summary>
 /// 常量:"RoleIndex"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RoleIndex = "RoleIndex";    //角色序号

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
 /// 常量:"IsInUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsInUse = "IsInUse";    //是否在使用

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
 /// 常量:"UserNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserNum = "UserNum";    //用户数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxUserRolesByUserNumEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vQxUserRolesByUserNum";
 lstKeyFldNames.Add("RoleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strRoleId">关键字:角色Id</param>
public clsvQxUserRolesByUserNumEN(string strRoleId)
 {
strRoleId = strRoleId.Replace("'", "''");
if (strRoleId.Length > 8)
{
throw new Exception("在表:vQxUserRolesByUserNum中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRoleId)  ==  true)
{
throw new Exception("在表:vQxUserRolesByUserNum中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRoleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrRoleId = strRoleId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vQxUserRolesByUserNum";
 lstKeyFldNames.Add("RoleId");
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
if (strAttributeName  ==  con_RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  con_RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  con_RoleENName)
{
return mstrRoleENName;
}
else if (strAttributeName  ==  con_RoleIndex)
{
return mintRoleIndex;
}
else if (strAttributeName  ==  con_QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  con_PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  con_IsInUse)
{
return mbolIsInUse;
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
else if (strAttributeName  ==  con_UserNum)
{
return mintUserNum;
}
return null;
}
set
{
if (strAttributeName  ==  con_RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(con_RoleId);
}
else if (strAttributeName  ==  con_RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(con_RoleName);
}
else if (strAttributeName  ==  con_RoleENName)
{
mstrRoleENName = value.ToString();
 AddUpdatedFld(con_RoleENName);
}
else if (strAttributeName  ==  con_RoleIndex)
{
mintRoleIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(con_RoleIndex);
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
else if (strAttributeName  ==  con_IsInUse)
{
mbolIsInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsInUse);
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
else if (strAttributeName  ==  con_UserNum)
{
mintUserNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_UserNum);
}
}
}
public object this[int intIndex]
{
get
{
if (con_RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (con_RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (con_RoleENName  ==  AttributeName[intIndex])
{
return mstrRoleENName;
}
else if (con_RoleIndex  ==  AttributeName[intIndex])
{
return mintRoleIndex;
}
else if (con_QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (con_PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (con_IsInUse  ==  AttributeName[intIndex])
{
return mbolIsInUse;
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
else if (con_UserNum  ==  AttributeName[intIndex])
{
return mintUserNum;
}
return null;
}
set
{
if (con_RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(con_RoleId);
}
else if (con_RoleName  ==  AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(con_RoleName);
}
else if (con_RoleENName  ==  AttributeName[intIndex])
{
mstrRoleENName = value.ToString();
 AddUpdatedFld(con_RoleENName);
}
else if (con_RoleIndex  ==  AttributeName[intIndex])
{
mintRoleIndex = TransNullToInt(value.ToString());
 AddUpdatedFld(con_RoleIndex);
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
else if (con_IsInUse  ==  AttributeName[intIndex])
{
mbolIsInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsInUse);
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
else if (con_UserNum  ==  AttributeName[intIndex])
{
mintUserNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_UserNum);
}
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
/// 角色名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleName
{
get
{
return mstrRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleName = value;
}
else
{
 mstrRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_RoleName);
}
}
/// <summary>
/// 角色英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleENName
{
get
{
return mstrRoleENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleENName = value;
}
else
{
 mstrRoleENName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_RoleENName);
}
}
/// <summary>
/// 角色序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int RoleIndex
{
get
{
return mintRoleIndex;
}
set
{
 mintRoleIndex = value;
//记录修改过的字段
 AddUpdatedFld(con_RoleIndex);
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
/// 是否在使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsInUse
{
get
{
return mbolIsInUse;
}
set
{
 mbolIsInUse = value;
//记录修改过的字段
 AddUpdatedFld(con_IsInUse);
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
/// 用户数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int UserNum
{
get
{
return mintUserNum;
}
set
{
 mintUserNum = value;
//记录修改过的字段
 AddUpdatedFld(con_UserNum);
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
  return mstrRoleId;
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
  return mstrRoleName;
 }
 }
}
}