
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSubjectRelationEN
 表名:vSubjectRelation(00140053)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:44:01
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
 /// 表vSubjectRelation的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vSubjectRelation
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
public K_mId_vSubjectRelation(long lngmId)
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
 /// <returns>返回:[K_mId_vSubjectRelation]类型的对象</returns>
public static implicit operator K_mId_vSubjectRelation(long value)
{
return new K_mId_vSubjectRelation(value);
}
}
 /// <summary>
 /// v隶属关系(vSubjectRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSubjectRelationEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vSubjectRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "DepartmentId", "DepartmentName", "LeaderId", "IsDirectLeader", "Memo", "LeaderUserName", "LeaderDepartmentId", "LeaderDepartmentName"};

protected long mlngmId;    //流水号
protected string mstrUserId;    //用户ID
protected string mstrUserName;    //用户名
protected string mstrDepartmentId;    //部门Id
protected string mstrDepartmentName;    //部门名
protected string mstrLeaderId;    //领导Id
protected bool mbolIsDirectLeader;    //是否直接领导
protected string mstrMemo;    //备注
protected string mstrLeaderUserName;    //LeaderUserName
protected string mstrLeaderDepartmentId;    //LeaderDepartmentId
protected string mstrLeaderDepartmentName;    //LeaderDepartmentName

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSubjectRelationEN()
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
public clsvSubjectRelationEN(long lngmId)
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
if (strAttributeName  ==  convSubjectRelation.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convSubjectRelation.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convSubjectRelation.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  convSubjectRelation.DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  convSubjectRelation.DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  convSubjectRelation.LeaderId)
{
return mstrLeaderId;
}
else if (strAttributeName  ==  convSubjectRelation.IsDirectLeader)
{
return mbolIsDirectLeader;
}
else if (strAttributeName  ==  convSubjectRelation.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convSubjectRelation.LeaderUserName)
{
return mstrLeaderUserName;
}
else if (strAttributeName  ==  convSubjectRelation.LeaderDepartmentId)
{
return mstrLeaderDepartmentId;
}
else if (strAttributeName  ==  convSubjectRelation.LeaderDepartmentName)
{
return mstrLeaderDepartmentName;
}
return null;
}
set
{
if (strAttributeName  ==  convSubjectRelation.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convSubjectRelation.mId);
}
else if (strAttributeName  ==  convSubjectRelation.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convSubjectRelation.UserId);
}
else if (strAttributeName  ==  convSubjectRelation.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(convSubjectRelation.UserName);
}
else if (strAttributeName  ==  convSubjectRelation.DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convSubjectRelation.DepartmentId);
}
else if (strAttributeName  ==  convSubjectRelation.DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convSubjectRelation.DepartmentName);
}
else if (strAttributeName  ==  convSubjectRelation.LeaderId)
{
mstrLeaderId = value.ToString();
 AddUpdatedFld(convSubjectRelation.LeaderId);
}
else if (strAttributeName  ==  convSubjectRelation.IsDirectLeader)
{
mbolIsDirectLeader = TransNullToBool(value.ToString());
 AddUpdatedFld(convSubjectRelation.IsDirectLeader);
}
else if (strAttributeName  ==  convSubjectRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSubjectRelation.Memo);
}
else if (strAttributeName  ==  convSubjectRelation.LeaderUserName)
{
mstrLeaderUserName = value.ToString();
 AddUpdatedFld(convSubjectRelation.LeaderUserName);
}
else if (strAttributeName  ==  convSubjectRelation.LeaderDepartmentId)
{
mstrLeaderDepartmentId = value.ToString();
 AddUpdatedFld(convSubjectRelation.LeaderDepartmentId);
}
else if (strAttributeName  ==  convSubjectRelation.LeaderDepartmentName)
{
mstrLeaderDepartmentName = value.ToString();
 AddUpdatedFld(convSubjectRelation.LeaderDepartmentName);
}
}
}
public object this[int intIndex]
{
get
{
if (convSubjectRelation.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convSubjectRelation.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convSubjectRelation.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (convSubjectRelation.DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (convSubjectRelation.DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (convSubjectRelation.LeaderId  ==  AttributeName[intIndex])
{
return mstrLeaderId;
}
else if (convSubjectRelation.IsDirectLeader  ==  AttributeName[intIndex])
{
return mbolIsDirectLeader;
}
else if (convSubjectRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convSubjectRelation.LeaderUserName  ==  AttributeName[intIndex])
{
return mstrLeaderUserName;
}
else if (convSubjectRelation.LeaderDepartmentId  ==  AttributeName[intIndex])
{
return mstrLeaderDepartmentId;
}
else if (convSubjectRelation.LeaderDepartmentName  ==  AttributeName[intIndex])
{
return mstrLeaderDepartmentName;
}
return null;
}
set
{
if (convSubjectRelation.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convSubjectRelation.mId);
}
else if (convSubjectRelation.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convSubjectRelation.UserId);
}
else if (convSubjectRelation.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(convSubjectRelation.UserName);
}
else if (convSubjectRelation.DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(convSubjectRelation.DepartmentId);
}
else if (convSubjectRelation.DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(convSubjectRelation.DepartmentName);
}
else if (convSubjectRelation.LeaderId  ==  AttributeName[intIndex])
{
mstrLeaderId = value.ToString();
 AddUpdatedFld(convSubjectRelation.LeaderId);
}
else if (convSubjectRelation.IsDirectLeader  ==  AttributeName[intIndex])
{
mbolIsDirectLeader = TransNullToBool(value.ToString());
 AddUpdatedFld(convSubjectRelation.IsDirectLeader);
}
else if (convSubjectRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convSubjectRelation.Memo);
}
else if (convSubjectRelation.LeaderUserName  ==  AttributeName[intIndex])
{
mstrLeaderUserName = value.ToString();
 AddUpdatedFld(convSubjectRelation.LeaderUserName);
}
else if (convSubjectRelation.LeaderDepartmentId  ==  AttributeName[intIndex])
{
mstrLeaderDepartmentId = value.ToString();
 AddUpdatedFld(convSubjectRelation.LeaderDepartmentId);
}
else if (convSubjectRelation.LeaderDepartmentName  ==  AttributeName[intIndex])
{
mstrLeaderDepartmentName = value.ToString();
 AddUpdatedFld(convSubjectRelation.LeaderDepartmentName);
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
 AddUpdatedFld(convSubjectRelation.mId);
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
 AddUpdatedFld(convSubjectRelation.UserId);
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
 AddUpdatedFld(convSubjectRelation.UserName);
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
 AddUpdatedFld(convSubjectRelation.DepartmentId);
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
 AddUpdatedFld(convSubjectRelation.DepartmentName);
}
}
/// <summary>
/// 领导Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LeaderId
{
get
{
return mstrLeaderId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLeaderId = value;
}
else
{
 mstrLeaderId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSubjectRelation.LeaderId);
}
}
/// <summary>
/// 是否直接领导(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDirectLeader
{
get
{
return mbolIsDirectLeader;
}
set
{
 mbolIsDirectLeader = value;
//记录修改过的字段
 AddUpdatedFld(convSubjectRelation.IsDirectLeader);
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
 AddUpdatedFld(convSubjectRelation.Memo);
}
}
/// <summary>
/// LeaderUserName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LeaderUserName
{
get
{
return mstrLeaderUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLeaderUserName = value;
}
else
{
 mstrLeaderUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSubjectRelation.LeaderUserName);
}
}
/// <summary>
/// LeaderDepartmentId(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LeaderDepartmentId
{
get
{
return mstrLeaderDepartmentId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLeaderDepartmentId = value;
}
else
{
 mstrLeaderDepartmentId = value;
}
//记录修改过的字段
 AddUpdatedFld(convSubjectRelation.LeaderDepartmentId);
}
}
/// <summary>
/// LeaderDepartmentName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LeaderDepartmentName
{
get
{
return mstrLeaderDepartmentName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLeaderDepartmentName = value;
}
else
{
 mstrLeaderDepartmentName = value;
}
//记录修改过的字段
 AddUpdatedFld(convSubjectRelation.LeaderDepartmentName);
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
 /// v隶属关系(vSubjectRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convSubjectRelation
{
public const string _CurrTabName = "vSubjectRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "DepartmentId", "DepartmentName", "LeaderId", "IsDirectLeader", "Memo", "LeaderUserName", "LeaderDepartmentId", "LeaderDepartmentName"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //流水号

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
 /// 常量:"LeaderId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LeaderId = "LeaderId";    //领导Id

 /// <summary>
 /// 常量:"IsDirectLeader"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDirectLeader = "IsDirectLeader";    //是否直接领导

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"LeaderUserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LeaderUserName = "LeaderUserName";    //LeaderUserName

 /// <summary>
 /// 常量:"LeaderDepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LeaderDepartmentId = "LeaderDepartmentId";    //LeaderDepartmentId

 /// <summary>
 /// 常量:"LeaderDepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LeaderDepartmentName = "LeaderDepartmentName";    //LeaderDepartmentName
}

}