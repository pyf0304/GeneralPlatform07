
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserStateEN
 表名:QxUserState(00140016)
 生成代码版本:2019.07.12.1
 生成日期:2019/07/12 10:47:36
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
 /// 表QxUserState的关键字(UserStateId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_UserStateId_QxUserState
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUserStateId">表关键字</param>
public K_UserStateId_QxUserState(string strUserStateId)
{
if (IsValid(strUserStateId)) Value = strUserStateId;
else
{
Value = null;
}
}
private static bool IsValid(string strUserStateId)
{
if (string.IsNullOrEmpty(strUserStateId) == true) return false;
if (strUserStateId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UserStateId_QxUserState]类型的对象</returns>
public static implicit operator K_UserStateId_QxUserState(string value)
{
return new K_UserStateId_QxUserState(value);
}
}
 /// <summary>
 /// 用户状态(QxUserState)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserStateEN : clsEntityBase2
{
public const string _CurrTabName_S = "QxUserState"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"UserStateId", "UserStateName", "Memo"};
//以下是属性变量

protected string mstrUserStateId;    //用户状态Id
protected string mstrUserStateName;    //用户状态名
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserStateId = "UserStateId";    //用户状态Id

 /// <summary>
 /// 常量:"UserStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserStateName = "UserStateName";    //用户状态名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserStateEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxUserState";
 lstKeyFldNames.Add("UserStateId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strUserStateId">关键字:用户状态Id</param>
public clsQxUserStateEN(string strUserStateId)
 {
strUserStateId = strUserStateId.Replace("'", "''");
if (strUserStateId.Length > 2)
{
throw new Exception("在表:QxUserState中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserStateId)  ==  true)
{
throw new Exception("在表:QxUserState中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserStateId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUserStateId = strUserStateId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxUserState";
 lstKeyFldNames.Add("UserStateId");
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
if (strAttributeName  ==  con_UserStateId)
{
return mstrUserStateId;
}
else if (strAttributeName  ==  con_UserStateName)
{
return mstrUserStateName;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_UserStateId)
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(con_UserStateId);
}
else if (strAttributeName  ==  con_UserStateName)
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(con_UserStateName);
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
if (con_UserStateId  ==  AttributeName[intIndex])
{
return mstrUserStateId;
}
else if (con_UserStateName  ==  AttributeName[intIndex])
{
return mstrUserStateName;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_UserStateId  ==  AttributeName[intIndex])
{
mstrUserStateId = value.ToString();
 AddUpdatedFld(con_UserStateId);
}
else if (con_UserStateName  ==  AttributeName[intIndex])
{
mstrUserStateName = value.ToString();
 AddUpdatedFld(con_UserStateName);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
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
 AddUpdatedFld(con_UserStateId);
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
 AddUpdatedFld(con_UserStateName);
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
  return mstrUserStateId;
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
  return mstrUserStateName;
 }
 }
}
}