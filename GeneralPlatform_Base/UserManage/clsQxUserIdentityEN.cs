
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserIdentityEN
 表名:QxUserIdentity(00140042)
 生成代码版本:2019.07.12.1
 生成日期:2019/07/12 11:00:39
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
 /// 表QxUserIdentity的关键字(IdentityID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_IdentityID_QxUserIdentity
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strIdentityID">表关键字</param>
public K_IdentityID_QxUserIdentity(string strIdentityID)
{
if (IsValid(strIdentityID)) Value = strIdentityID;
else
{
Value = null;
}
}
private static bool IsValid(string strIdentityID)
{
if (string.IsNullOrEmpty(strIdentityID) == true) return false;
if (strIdentityID.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_IdentityID_QxUserIdentity]类型的对象</returns>
public static implicit operator K_IdentityID_QxUserIdentity(string value)
{
return new K_IdentityID_QxUserIdentity(value);
}
}
 /// <summary>
 /// 用户权限身份表(QxUserIdentity)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserIdentityEN : clsEntityBase2
{
public const string _CurrTabName_S = "QxUserIdentity"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "IdentityID"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"IdentityID", "IdentityDesc", "Memo"};
//以下是属性变量

protected string mstrIdentityID;    //身份编号
protected string mstrIdentityDesc;    //身份描述
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"IdentityID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IdentityID = "IdentityID";    //身份编号

 /// <summary>
 /// 常量:"IdentityDesc"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IdentityDesc = "IdentityDesc";    //身份描述

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserIdentityEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxUserIdentity";
 lstKeyFldNames.Add("IdentityID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strIdentityID">关键字:身份编号</param>
public clsQxUserIdentityEN(string strIdentityID)
 {
strIdentityID = strIdentityID.Replace("'", "''");
if (strIdentityID.Length > 2)
{
throw new Exception("在表:QxUserIdentity中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strIdentityID)  ==  true)
{
throw new Exception("在表:QxUserIdentity中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdentityID);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrIdentityID = strIdentityID;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxUserIdentity";
 lstKeyFldNames.Add("IdentityID");
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
if (strAttributeName  ==  con_IdentityID)
{
return mstrIdentityID;
}
else if (strAttributeName  ==  con_IdentityDesc)
{
return mstrIdentityDesc;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_IdentityID)
{
mstrIdentityID = value.ToString();
 AddUpdatedFld(con_IdentityID);
}
else if (strAttributeName  ==  con_IdentityDesc)
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(con_IdentityDesc);
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
if (con_IdentityID  ==  AttributeName[intIndex])
{
return mstrIdentityID;
}
else if (con_IdentityDesc  ==  AttributeName[intIndex])
{
return mstrIdentityDesc;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_IdentityID  ==  AttributeName[intIndex])
{
mstrIdentityID = value.ToString();
 AddUpdatedFld(con_IdentityID);
}
else if (con_IdentityDesc  ==  AttributeName[intIndex])
{
mstrIdentityDesc = value.ToString();
 AddUpdatedFld(con_IdentityDesc);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// 身份编号(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdentityID
{
get
{
return mstrIdentityID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdentityID = value;
}
else
{
 mstrIdentityID = value;
}
//记录修改过的字段
 AddUpdatedFld(con_IdentityID);
}
}
/// <summary>
/// 身份描述(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdentityDesc
{
get
{
return mstrIdentityDesc;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdentityDesc = value;
}
else
{
 mstrIdentityDesc = value;
}
//记录修改过的字段
 AddUpdatedFld(con_IdentityDesc);
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
  return mstrIdentityID;
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
  return mstrIdentityDesc;
 }
 }
}
}