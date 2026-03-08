
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSubjectRelationEN_Sim
 表名:vSubjectRelation
 生成代码版本:2018.04.19.1
 生成日期:2018/04/20 12:40:42
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
 框架-层名:实体层-简化
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace GeneralPlatform.Entity
{
 /// <summary>
 /// v隶属关系(vSubjectRelation)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode_Sim)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvSubjectRelationEN_Sim 
{
//以下是属性变量

private long mlngmId;    //流水号
private string mstrUserId;    //用户ID
private string mstrUserName;    //用户名
private string mstrDepartmentId;    //部门Id
private string mstrDepartmentName;    //部门名
private string mstrLeaderId;    //领导Id
private bool mbolIsDirectLeader;    //是否直接领导
private string mstrMemo;    //备注
private string mstrLeaderUserName;    //LeaderUserName
private string mstrLeaderDepartmentId;    //LeaderDepartmentId
private string mstrLeaderDepartmentName;    //LeaderDepartmentName
private string mstrsf_UpdFldSetStr;    //系统字段_修改字段集合串

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
}
}
/// <summary>
/// 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrDepartmentId = value;
}
else
{
 mstrDepartmentId = value;
}
}
}
/// <summary>
/// 部门名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrDepartmentName = value;
}
else
{
 mstrDepartmentName = value;
}
}
}
/// <summary>
/// 领导Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrLeaderId = value;
}
else
{
 mstrLeaderId = value;
}
}
}
/// <summary>
/// 是否直接领导(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
}
}
/// <summary>
/// LeaderUserName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrLeaderUserName = value;
}
else
{
 mstrLeaderUserName = value;
}
}
}
/// <summary>
/// LeaderDepartmentId(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrLeaderDepartmentId = value;
}
else
{
 mstrLeaderDepartmentId = value;
}
}
}
/// <summary>
/// LeaderDepartmentName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrLeaderDepartmentName = value;
}
else
{
 mstrLeaderDepartmentName = value;
}
}
}
/// <summary>
/// 系统字段_修改字段集合串(说明:;字段类型:str;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string sf_UpdFldSetStr
{
get
{
return mstrsf_UpdFldSetStr;
}
set
{
if (value  ==  "")
{
 mstrsf_UpdFldSetStr = value;
}
else
{
 mstrsf_UpdFldSetStr = value;
}
}
}
}
}