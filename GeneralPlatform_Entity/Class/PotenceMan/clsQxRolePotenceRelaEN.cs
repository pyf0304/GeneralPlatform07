
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRolePotenceRelaEN
 表名:QxRolePotenceRela(00140123)
 * 版本:2024.03.19.1(服务器:WIN-SRV103-116)
 日期:2024/03/20 11:14:52
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:权限管理(PotenceMan)
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
 /// 表QxRolePotenceRela的关键字(RoleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RoleId_QxRolePotenceRela
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strRoleId">表关键字</param>
public K_RoleId_QxRolePotenceRela(string strRoleId)
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
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RoleId_QxRolePotenceRela]类型的对象</returns>
public static implicit operator K_RoleId_QxRolePotenceRela(string value)
{
return new K_RoleId_QxRolePotenceRela(value);
}
}
 /// <summary>
 /// 角色权限关系(QxRolePotenceRela)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxRolePotenceRelaEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxRolePotenceRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RoleId,PotenceId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"RoleId", "PotenceId", "QxPrjId", "UpdDate", "UpdUser", "Memo"};

protected string mstrRoleId;    //角色Id
protected string mstrPotenceId;    //权限ID
protected string mstrQxPrjId;    //项目Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxRolePotenceRelaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RoleId");
 lstKeyFldNames.Add("PotenceId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strRoleId">关键字:角色Id</param>
public clsQxRolePotenceRelaEN(string strRoleId , string strPotenceId)
 {
strRoleId = strRoleId.Replace("'", "''");
if (strRoleId.Length > 8)
{
throw new Exception("在表:QxRolePotenceRela中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strRoleId)  ==  true)
{
throw new Exception("在表:QxRolePotenceRela中,关键字不能为空 或 null!");
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
this.mstrPotenceId = strPotenceId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RoleId");
 lstKeyFldNames.Add("PotenceId");
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
if (strAttributeName  ==  conQxRolePotenceRela.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  conQxRolePotenceRela.PotenceId)
{
return mstrPotenceId;
}
else if (strAttributeName  ==  conQxRolePotenceRela.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxRolePotenceRela.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxRolePotenceRela.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQxRolePotenceRela.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxRolePotenceRela.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQxRolePotenceRela.RoleId);
}
else if (strAttributeName  ==  conQxRolePotenceRela.PotenceId)
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(conQxRolePotenceRela.PotenceId);
}
else if (strAttributeName  ==  conQxRolePotenceRela.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxRolePotenceRela.QxPrjId);
}
else if (strAttributeName  ==  conQxRolePotenceRela.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxRolePotenceRela.UpdDate);
}
else if (strAttributeName  ==  conQxRolePotenceRela.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxRolePotenceRela.UpdUser);
}
else if (strAttributeName  ==  conQxRolePotenceRela.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxRolePotenceRela.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxRolePotenceRela.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (conQxRolePotenceRela.PotenceId  ==  AttributeName[intIndex])
{
return mstrPotenceId;
}
else if (conQxRolePotenceRela.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxRolePotenceRela.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxRolePotenceRela.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQxRolePotenceRela.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxRolePotenceRela.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQxRolePotenceRela.RoleId);
}
else if (conQxRolePotenceRela.PotenceId  ==  AttributeName[intIndex])
{
mstrPotenceId = value.ToString();
 AddUpdatedFld(conQxRolePotenceRela.PotenceId);
}
else if (conQxRolePotenceRela.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxRolePotenceRela.QxPrjId);
}
else if (conQxRolePotenceRela.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxRolePotenceRela.UpdDate);
}
else if (conQxRolePotenceRela.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxRolePotenceRela.UpdUser);
}
else if (conQxRolePotenceRela.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxRolePotenceRela.Memo);
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
 AddUpdatedFld(conQxRolePotenceRela.RoleId);
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
 AddUpdatedFld(conQxRolePotenceRela.PotenceId);
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
 AddUpdatedFld(conQxRolePotenceRela.QxPrjId);
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
 AddUpdatedFld(conQxRolePotenceRela.UpdDate);
}
}
/// <summary>
/// 修改用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxRolePotenceRela.UpdUser);
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
 AddUpdatedFld(conQxRolePotenceRela.Memo);
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
  return mstrRoleId;
 }
 }
}
 /// <summary>
 /// 角色权限关系(QxRolePotenceRela)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxRolePotenceRela
{
public const string _CurrTabName = "QxRolePotenceRela"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RoleId,PotenceId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RoleId", "PotenceId", "QxPrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"PotenceId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PotenceId = "PotenceId";    //权限ID

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改用户

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}