
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSubjectRelationEN
 表名:vSubjectRelation(00140053)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 09:58:49
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
 /// 表vSubjectRelation的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_mId_vSubjectRelation
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get; }
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
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
public const string _CurrTabName_S = "vSubjectRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 11;
public static string[] AttributeName = new string[] {"mId", "UserId", "UserName", "DepartmentId", "DepartmentName", "LeaderId", "IsDirectLeader", "Memo", "LeaderUserName", "LeaderDepartmentId", "LeaderDepartmentName"};
//以下是属性变量

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
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId = "mId";    //流水号

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentId = "DepartmentId";    //部门Id

 /// <summary>
 /// 常量:"DepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DepartmentName = "DepartmentName";    //部门名

 /// <summary>
 /// 常量:"LeaderId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_LeaderId = "LeaderId";    //领导Id

 /// <summary>
 /// 常量:"IsDirectLeader"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsDirectLeader = "IsDirectLeader";    //是否直接领导

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"LeaderUserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_LeaderUserName = "LeaderUserName";    //LeaderUserName

 /// <summary>
 /// 常量:"LeaderDepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_LeaderDepartmentId = "LeaderDepartmentId";    //LeaderDepartmentId

 /// <summary>
 /// 常量:"LeaderDepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_LeaderDepartmentName = "LeaderDepartmentName";    //LeaderDepartmentName

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvSubjectRelationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vSubjectRelation";
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
 _CurrTabName = "vSubjectRelation";
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
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  con_DepartmentId)
{
return mstrDepartmentId;
}
else if (strAttributeName  ==  con_DepartmentName)
{
return mstrDepartmentName;
}
else if (strAttributeName  ==  con_LeaderId)
{
return mstrLeaderId;
}
else if (strAttributeName  ==  con_IsDirectLeader)
{
return mbolIsDirectLeader;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  con_LeaderUserName)
{
return mstrLeaderUserName;
}
else if (strAttributeName  ==  con_LeaderDepartmentId)
{
return mstrLeaderDepartmentId;
}
else if (strAttributeName  ==  con_LeaderDepartmentName)
{
return mstrLeaderDepartmentName;
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
else if (strAttributeName  ==  con_UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName  ==  con_UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(con_UserName);
}
else if (strAttributeName  ==  con_DepartmentId)
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (strAttributeName  ==  con_DepartmentName)
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(con_DepartmentName);
}
else if (strAttributeName  ==  con_LeaderId)
{
mstrLeaderId = value.ToString();
 AddUpdatedFld(con_LeaderId);
}
else if (strAttributeName  ==  con_IsDirectLeader)
{
mbolIsDirectLeader = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDirectLeader);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName  ==  con_LeaderUserName)
{
mstrLeaderUserName = value.ToString();
 AddUpdatedFld(con_LeaderUserName);
}
else if (strAttributeName  ==  con_LeaderDepartmentId)
{
mstrLeaderDepartmentId = value.ToString();
 AddUpdatedFld(con_LeaderDepartmentId);
}
else if (strAttributeName  ==  con_LeaderDepartmentName)
{
mstrLeaderDepartmentName = value.ToString();
 AddUpdatedFld(con_LeaderDepartmentName);
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
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (con_DepartmentId  ==  AttributeName[intIndex])
{
return mstrDepartmentId;
}
else if (con_DepartmentName  ==  AttributeName[intIndex])
{
return mstrDepartmentName;
}
else if (con_LeaderId  ==  AttributeName[intIndex])
{
return mstrLeaderId;
}
else if (con_IsDirectLeader  ==  AttributeName[intIndex])
{
return mbolIsDirectLeader;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (con_LeaderUserName  ==  AttributeName[intIndex])
{
return mstrLeaderUserName;
}
else if (con_LeaderDepartmentId  ==  AttributeName[intIndex])
{
return mstrLeaderDepartmentId;
}
else if (con_LeaderDepartmentName  ==  AttributeName[intIndex])
{
return mstrLeaderDepartmentName;
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
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(con_UserName);
}
else if (con_DepartmentId  ==  AttributeName[intIndex])
{
mstrDepartmentId = value.ToString();
 AddUpdatedFld(con_DepartmentId);
}
else if (con_DepartmentName  ==  AttributeName[intIndex])
{
mstrDepartmentName = value.ToString();
 AddUpdatedFld(con_DepartmentName);
}
else if (con_LeaderId  ==  AttributeName[intIndex])
{
mstrLeaderId = value.ToString();
 AddUpdatedFld(con_LeaderId);
}
else if (con_IsDirectLeader  ==  AttributeName[intIndex])
{
mbolIsDirectLeader = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDirectLeader);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_LeaderUserName  ==  AttributeName[intIndex])
{
mstrLeaderUserName = value.ToString();
 AddUpdatedFld(con_LeaderUserName);
}
else if (con_LeaderDepartmentId  ==  AttributeName[intIndex])
{
mstrLeaderDepartmentId = value.ToString();
 AddUpdatedFld(con_LeaderDepartmentId);
}
else if (con_LeaderDepartmentName  ==  AttributeName[intIndex])
{
mstrLeaderDepartmentName = value.ToString();
 AddUpdatedFld(con_LeaderDepartmentName);
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
 AddUpdatedFld(con_UserName);
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
 AddUpdatedFld(con_DepartmentId);
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
 AddUpdatedFld(con_DepartmentName);
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
 AddUpdatedFld(con_LeaderId);
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
 AddUpdatedFld(con_IsDirectLeader);
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
 AddUpdatedFld(con_LeaderUserName);
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
 AddUpdatedFld(con_LeaderDepartmentId);
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
 AddUpdatedFld(con_LeaderDepartmentName);
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