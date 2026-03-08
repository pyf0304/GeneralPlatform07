
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserGroupsEN
 表名:QxUserGroups(00140010)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:21:52
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
 /// 表QxUserGroups的关键字(GroupId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_GroupId_QxUserGroups
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strGroupId">表关键字</param>
public K_GroupId_QxUserGroups(string strGroupId)
{
if (IsValid(strGroupId)) Value = strGroupId;
else
{
Value = null;
}
}
private static bool IsValid(string strGroupId)
{
if (string.IsNullOrEmpty(strGroupId) == true) return false;
if (strGroupId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_GroupId_QxUserGroups]类型的对象</returns>
public static implicit operator K_GroupId_QxUserGroups(string value)
{
return new K_GroupId_QxUserGroups(value);
}
}
 /// <summary>
 /// 用户组(QxUserGroups)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserGroupsEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUserGroups"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "GroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"GroupId", "GroupName", "QxPrjId", "Memo"};

protected string mstrGroupId;    //组Id
protected string mstrGroupName;    //组名
protected string mstrQxPrjId;    //项目Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserGroupsEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GroupId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strGroupId">关键字:组Id</param>
public clsQxUserGroupsEN(string strGroupId)
 {
strGroupId = strGroupId.Replace("'", "''");
if (strGroupId.Length > 8)
{
throw new Exception("在表:QxUserGroups中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strGroupId)  ==  true)
{
throw new Exception("在表:QxUserGroups中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGroupId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrGroupId = strGroupId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("GroupId");
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
if (strAttributeName  ==  conQxUserGroups.GroupId)
{
return mstrGroupId;
}
else if (strAttributeName  ==  conQxUserGroups.GroupName)
{
return mstrGroupName;
}
else if (strAttributeName  ==  conQxUserGroups.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxUserGroups.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUserGroups.GroupId)
{
mstrGroupId = value.ToString();
 AddUpdatedFld(conQxUserGroups.GroupId);
}
else if (strAttributeName  ==  conQxUserGroups.GroupName)
{
mstrGroupName = value.ToString();
 AddUpdatedFld(conQxUserGroups.GroupName);
}
else if (strAttributeName  ==  conQxUserGroups.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserGroups.QxPrjId);
}
else if (strAttributeName  ==  conQxUserGroups.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserGroups.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUserGroups.GroupId  ==  AttributeName[intIndex])
{
return mstrGroupId;
}
else if (conQxUserGroups.GroupName  ==  AttributeName[intIndex])
{
return mstrGroupName;
}
else if (conQxUserGroups.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxUserGroups.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxUserGroups.GroupId  ==  AttributeName[intIndex])
{
mstrGroupId = value.ToString();
 AddUpdatedFld(conQxUserGroups.GroupId);
}
else if (conQxUserGroups.GroupName  ==  AttributeName[intIndex])
{
mstrGroupName = value.ToString();
 AddUpdatedFld(conQxUserGroups.GroupName);
}
else if (conQxUserGroups.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserGroups.QxPrjId);
}
else if (conQxUserGroups.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserGroups.Memo);
}
}
}

/// <summary>
/// 组Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupId
{
get
{
return mstrGroupId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupId = value;
}
else
{
 mstrGroupId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserGroups.GroupId);
}
}
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string GroupName
{
get
{
return mstrGroupName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrGroupName = value;
}
else
{
 mstrGroupName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUserGroups.GroupName);
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
 AddUpdatedFld(conQxUserGroups.QxPrjId);
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
 AddUpdatedFld(conQxUserGroups.Memo);
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
  return mstrGroupId;
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
  return mstrGroupName;
 }
 }
}
 /// <summary>
 /// 用户组(QxUserGroups)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUserGroups
{
public const string _CurrTabName = "QxUserGroups"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "GroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"GroupId", "GroupName", "QxPrjId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"GroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupId = "GroupId";    //组Id

 /// <summary>
 /// 常量:"GroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string GroupName = "GroupName";    //组名

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}