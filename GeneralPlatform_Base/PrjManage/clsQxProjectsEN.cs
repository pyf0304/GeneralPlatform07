
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxProjectsEN
 表名:QxProjects(00140006)
 生成代码版本:2019.07.12.1
 生成日期:2019/07/12 10:44:12
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:工程管理
 模块英文名:PrjManage
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
 /// 表QxProjects的关键字(QxPrjId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_QxPrjId_QxProjects
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strQxPrjId">表关键字</param>
public K_QxPrjId_QxProjects(string strQxPrjId)
{
if (IsValid(strQxPrjId)) Value = strQxPrjId;
else
{
Value = null;
}
}
private static bool IsValid(string strQxPrjId)
{
if (string.IsNullOrEmpty(strQxPrjId) == true) return false;
if (strQxPrjId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QxPrjId_QxProjects]类型的对象</returns>
public static implicit operator K_QxPrjId_QxProjects(string value)
{
return new K_QxPrjId_QxProjects(value);
}
}
 /// <summary>
 /// 工程表(QxProjects)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxProjectsEN : clsEntityBase2
{
public const string _CurrTabName_S = "QxProjects"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QxPrjId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 8;
public static string[] AttributeName = new string[] {"QxPrjId", "PrjName", "PrjDomain", "IsDefaultPrj", "QxPrjDataBaseId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量

protected string mstrQxPrjId;    //项目Id
protected string mstrPrjName;    //工程名
protected string mstrPrjDomain;    //工程域名
protected bool mbolIsDefaultPrj;    //是否默认工程
protected string mstrQxPrjDataBaseId;    //项目数据库Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户
protected string mstrMemo;    //备注


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
 /// 常量:"PrjDomain"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjDomain = "PrjDomain";    //工程域名

 /// <summary>
 /// 常量:"IsDefaultPrj"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsDefaultPrj = "IsDefaultPrj";    //是否默认工程

 /// <summary>
 /// 常量:"QxPrjDataBaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QxPrjDataBaseId = "QxPrjDataBaseId";    //项目数据库Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUser = "UpdUser";    //修改用户

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxProjectsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxProjects";
 lstKeyFldNames.Add("QxPrjId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strQxPrjId">关键字:项目Id</param>
public clsQxProjectsEN(string strQxPrjId)
 {
strQxPrjId = strQxPrjId.Replace("'", "''");
if (strQxPrjId.Length > 4)
{
throw new Exception("在表:QxProjects中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQxPrjId)  ==  true)
{
throw new Exception("在表:QxProjects中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQxPrjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrQxPrjId = strQxPrjId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxProjects";
 lstKeyFldNames.Add("QxPrjId");
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
if (strAttributeName  ==  con_QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  con_PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  con_PrjDomain)
{
return mstrPrjDomain;
}
else if (strAttributeName  ==  con_IsDefaultPrj)
{
return mbolIsDefaultPrj;
}
else if (strAttributeName  ==  con_QxPrjDataBaseId)
{
return mstrQxPrjDataBaseId;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(con_QxPrjId);
}
else if (strAttributeName  ==  con_PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(con_PrjName);
}
else if (strAttributeName  ==  con_PrjDomain)
{
mstrPrjDomain = value.ToString();
 AddUpdatedFld(con_PrjDomain);
}
else if (strAttributeName  ==  con_IsDefaultPrj)
{
mbolIsDefaultPrj = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDefaultPrj);
}
else if (strAttributeName  ==  con_QxPrjDataBaseId)
{
mstrQxPrjDataBaseId = value.ToString();
 AddUpdatedFld(con_QxPrjDataBaseId);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(con_UpdUser);
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
if (con_QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (con_PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (con_PrjDomain  ==  AttributeName[intIndex])
{
return mstrPrjDomain;
}
else if (con_IsDefaultPrj  ==  AttributeName[intIndex])
{
return mbolIsDefaultPrj;
}
else if (con_QxPrjDataBaseId  ==  AttributeName[intIndex])
{
return mstrQxPrjDataBaseId;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(con_QxPrjId);
}
else if (con_PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(con_PrjName);
}
else if (con_PrjDomain  ==  AttributeName[intIndex])
{
mstrPrjDomain = value.ToString();
 AddUpdatedFld(con_PrjDomain);
}
else if (con_IsDefaultPrj  ==  AttributeName[intIndex])
{
mbolIsDefaultPrj = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDefaultPrj);
}
else if (con_QxPrjDataBaseId  ==  AttributeName[intIndex])
{
mstrQxPrjDataBaseId = value.ToString();
 AddUpdatedFld(con_QxPrjDataBaseId);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(con_UpdUser);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
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
/// 工程域名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjDomain
{
get
{
return mstrPrjDomain;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjDomain = value;
}
else
{
 mstrPrjDomain = value;
}
//记录修改过的字段
 AddUpdatedFld(con_PrjDomain);
}
}
/// <summary>
/// 是否默认工程(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDefaultPrj
{
get
{
return mbolIsDefaultPrj;
}
set
{
 mbolIsDefaultPrj = value;
//记录修改过的字段
 AddUpdatedFld(con_IsDefaultPrj);
}
}
/// <summary>
/// 项目数据库Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QxPrjDataBaseId
{
get
{
return mstrQxPrjDataBaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQxPrjDataBaseId = value;
}
else
{
 mstrQxPrjDataBaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_QxPrjDataBaseId);
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
/// 修改用户(说明:;字段类型:varchar;字段长度:18;是否可空:True)
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
 AddUpdatedFld(con_UpdUser);
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
  return mstrQxPrjId;
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
  return mstrPrjName;
 }
 }
}
}