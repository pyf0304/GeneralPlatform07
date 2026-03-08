
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTSysParaEN
 表名:TSysPara(00140033)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 10:01:24
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数
 模块英文名:SysPara
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
 /// 表TSysPara的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_mId_TSysPara
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_TSysPara(long lngmId)
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
 /// <returns>返回:[K_mId_TSysPara]类型的对象</returns>
public static implicit operator K_mId_TSysPara(long value)
{
return new K_mId_TSysPara(value);
}
}
 /// <summary>
 /// 系统参数(TSysPara)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsTSysParaEN : clsEntityBase2
{
public const string _CurrTabName_S = "TSysPara"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"mId", "SysParaName", "SysParaValue", "Memo", "ModifyDate", "ModifyUser", "id_School"};
//以下是属性变量

protected long mlngmId;    //流水号
protected string mstrSysParaName;    //系统参数名
protected string mstrSysParaValue;    //系统参数值
protected string mstrMemo;    //备注
protected string mstrModifyDate;    //修改日期
protected string mstrModifyUser;    //ModifyUser
protected string mstrid_School;    //学校流水号


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId = "mId";    //流水号

 /// <summary>
 /// 常量:"SysParaName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SysParaName = "SysParaName";    //系统参数名

 /// <summary>
 /// 常量:"SysParaValue"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SysParaValue = "SysParaValue";    //系统参数值

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"ModifyDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ModifyDate = "ModifyDate";    //修改日期

 /// <summary>
 /// 常量:"ModifyUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ModifyUser = "ModifyUser";    //ModifyUser

 /// <summary>
 /// 常量:"id_School"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_School = "id_School";    //学校流水号

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsTSysParaEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "TSysPara";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:流水号</param>
public clsTSysParaEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "TSysPara";
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
else if (strAttributeName  ==  con_SysParaName)
{
return mstrSysParaName;
}
else if (strAttributeName  ==  con_SysParaValue)
{
return mstrSysParaValue;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  con_ModifyDate)
{
return mstrModifyDate;
}
else if (strAttributeName  ==  con_ModifyUser)
{
return mstrModifyUser;
}
else if (strAttributeName  ==  con_id_School)
{
return mstrid_School;
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
else if (strAttributeName  ==  con_SysParaName)
{
mstrSysParaName = value.ToString();
 AddUpdatedFld(con_SysParaName);
}
else if (strAttributeName  ==  con_SysParaValue)
{
mstrSysParaValue = value.ToString();
 AddUpdatedFld(con_SysParaValue);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName  ==  con_ModifyDate)
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(con_ModifyDate);
}
else if (strAttributeName  ==  con_ModifyUser)
{
mstrModifyUser = value.ToString();
 AddUpdatedFld(con_ModifyUser);
}
else if (strAttributeName  ==  con_id_School)
{
mstrid_School = value.ToString();
 AddUpdatedFld(con_id_School);
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
else if (con_SysParaName  ==  AttributeName[intIndex])
{
return mstrSysParaName;
}
else if (con_SysParaValue  ==  AttributeName[intIndex])
{
return mstrSysParaValue;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (con_ModifyDate  ==  AttributeName[intIndex])
{
return mstrModifyDate;
}
else if (con_ModifyUser  ==  AttributeName[intIndex])
{
return mstrModifyUser;
}
else if (con_id_School  ==  AttributeName[intIndex])
{
return mstrid_School;
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
else if (con_SysParaName  ==  AttributeName[intIndex])
{
mstrSysParaName = value.ToString();
 AddUpdatedFld(con_SysParaName);
}
else if (con_SysParaValue  ==  AttributeName[intIndex])
{
mstrSysParaValue = value.ToString();
 AddUpdatedFld(con_SysParaValue);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_ModifyDate  ==  AttributeName[intIndex])
{
mstrModifyDate = value.ToString();
 AddUpdatedFld(con_ModifyDate);
}
else if (con_ModifyUser  ==  AttributeName[intIndex])
{
mstrModifyUser = value.ToString();
 AddUpdatedFld(con_ModifyUser);
}
else if (con_id_School  ==  AttributeName[intIndex])
{
mstrid_School = value.ToString();
 AddUpdatedFld(con_id_School);
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
/// 系统参数名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SysParaName
{
get
{
return mstrSysParaName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSysParaName = value;
}
else
{
 mstrSysParaName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SysParaName);
}
}
/// <summary>
/// 系统参数值(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SysParaValue
{
get
{
return mstrSysParaValue;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSysParaValue = value;
}
else
{
 mstrSysParaValue = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SysParaValue);
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
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyDate
{
get
{
return mstrModifyDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyDate = value;
}
else
{
 mstrModifyDate = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ModifyDate);
}
}
/// <summary>
/// ModifyUser(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ModifyUser
{
get
{
return mstrModifyUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrModifyUser = value;
}
else
{
 mstrModifyUser = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ModifyUser);
}
}
/// <summary>
/// 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string id_School
{
get
{
return mstrid_School;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_School = value;
}
else
{
 mstrid_School = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_School);
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