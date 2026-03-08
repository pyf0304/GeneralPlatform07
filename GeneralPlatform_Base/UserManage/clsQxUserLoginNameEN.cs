
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserLoginNameEN
 表名:QxUserLoginName(00140051)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 10:01:13
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
 /// 表QxUserLoginName的关键字(UserLoginName)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_UserLoginName_QxUserLoginName
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strUserLoginName">表关键字</param>
public K_UserLoginName_QxUserLoginName(string strUserLoginName)
{
if (IsValid(strUserLoginName)) Value = strUserLoginName;
else
{
Value = null;
}
}
private static bool IsValid(string strUserLoginName)
{
if (string.IsNullOrEmpty(strUserLoginName) == true) return false;
if (strUserLoginName.Length > 30) return false;
if (strUserLoginName.IndexOf(' ') >= 0) return false;
if (strUserLoginName.IndexOf(')') >= 0) return false;
if (strUserLoginName.IndexOf('(') >= 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_UserLoginName_QxUserLoginName]类型的对象</returns>
public static implicit operator K_UserLoginName_QxUserLoginName(string value)
{
return new K_UserLoginName_QxUserLoginName(value);
}
}
 /// <summary>
 /// 用户登录名(QxUserLoginName)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserLoginNameEN : clsEntityBase2
{
public const string _CurrTabName_S = "QxUserLoginName"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "UserLoginName"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"UserLoginName", "UserId", "UpdUserId", "UpdDate", "UpdTime", "Memo"};
//以下是属性变量

protected string mstrUserLoginName;    //用户登录名
protected string mstrUserId;    //用户ID
protected string mstrUpdUserId;    //修改用户Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdTime;    //修改时间
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"UserLoginName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserLoginName = "UserLoginName";    //用户登录名

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdTime = "UpdTime";    //修改时间

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserLoginNameEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxUserLoginName";
 lstKeyFldNames.Add("UserLoginName");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strUserLoginName">关键字:用户登录名</param>
public clsQxUserLoginNameEN(string strUserLoginName)
 {
strUserLoginName = strUserLoginName.Replace("'", "''");
if (strUserLoginName.Length > 30)
{
throw new Exception("在表:QxUserLoginName中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strUserLoginName)  ==  true)
{
throw new Exception("在表:QxUserLoginName中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserLoginName);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrUserLoginName = strUserLoginName;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxUserLoginName";
 lstKeyFldNames.Add("UserLoginName");
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
if (strAttributeName  ==  con_UserLoginName)
{
return mstrUserLoginName;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_UpdTime)
{
return mstrUpdTime;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_UserLoginName)
{
mstrUserLoginName = value.ToString();
 AddUpdatedFld(con_UserLoginName);
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName  ==  con_UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_UpdTime)
{
mstrUpdTime = value.ToString();
 AddUpdatedFld(con_UpdTime);
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
if (con_UserLoginName  ==  AttributeName[intIndex])
{
return mstrUserLoginName;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdTime  ==  AttributeName[intIndex])
{
return mstrUpdTime;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_UserLoginName  ==  AttributeName[intIndex])
{
mstrUserLoginName = value.ToString();
 AddUpdatedFld(con_UserLoginName);
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UpdTime  ==  AttributeName[intIndex])
{
mstrUpdTime = value.ToString();
 AddUpdatedFld(con_UpdTime);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// 用户登录名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserLoginName
{
get
{
return mstrUserLoginName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserLoginName = value;
}
else
{
 mstrUserLoginName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserLoginName);
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
 AddUpdatedFld(con_UserId);
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
/// 修改时间(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdTime
{
get
{
return mstrUpdTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdTime = value;
}
else
{
 mstrUpdTime = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UpdTime);
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
  return mstrUserLoginName;
 }
 }
}
}