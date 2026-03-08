
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRoleRightRelationEN
 表名:QxRoleRightRelation(00140118)
 * 版本:2024.02.03.1(服务器:WIN-SRV103-116)
 日期:2024/02/18 15:41:35
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
 /// 表QxRoleRightRelation的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QxRoleRightRelation
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
public K_mId_QxRoleRightRelation(long lngmId)
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
 /// <returns>返回:[K_mId_QxRoleRightRelation]类型的对象</returns>
public static implicit operator K_mId_QxRoleRightRelation(long value)
{
return new K_mId_QxRoleRightRelation(value);
}
}
 /// <summary>
 /// 角色赋权关系(QxRoleRightRelation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxRoleRightRelationEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxRoleRightRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"mId", "MyRoleId", "RoleId", "QxPrjId", "UpdDate", "UpdUser", "Memo"};

protected long mlngmId;    //流水号
protected string mstrMyRoleId;    //主角色Id
protected string mstrRoleId;    //角色Id
protected string mstrQxPrjId;    //项目Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxRoleRightRelationEN()
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
public clsQxRoleRightRelationEN(long lngmId)
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
if (strAttributeName  ==  conQxRoleRightRelation.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQxRoleRightRelation.MyRoleId)
{
return mstrMyRoleId;
}
else if (strAttributeName  ==  conQxRoleRightRelation.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  conQxRoleRightRelation.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxRoleRightRelation.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxRoleRightRelation.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQxRoleRightRelation.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxRoleRightRelation.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxRoleRightRelation.mId);
}
else if (strAttributeName  ==  conQxRoleRightRelation.MyRoleId)
{
mstrMyRoleId = value.ToString();
 AddUpdatedFld(conQxRoleRightRelation.MyRoleId);
}
else if (strAttributeName  ==  conQxRoleRightRelation.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQxRoleRightRelation.RoleId);
}
else if (strAttributeName  ==  conQxRoleRightRelation.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxRoleRightRelation.QxPrjId);
}
else if (strAttributeName  ==  conQxRoleRightRelation.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxRoleRightRelation.UpdDate);
}
else if (strAttributeName  ==  conQxRoleRightRelation.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxRoleRightRelation.UpdUser);
}
else if (strAttributeName  ==  conQxRoleRightRelation.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxRoleRightRelation.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxRoleRightRelation.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conQxRoleRightRelation.MyRoleId  ==  AttributeName[intIndex])
{
return mstrMyRoleId;
}
else if (conQxRoleRightRelation.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (conQxRoleRightRelation.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxRoleRightRelation.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxRoleRightRelation.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQxRoleRightRelation.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxRoleRightRelation.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxRoleRightRelation.mId);
}
else if (conQxRoleRightRelation.MyRoleId  ==  AttributeName[intIndex])
{
mstrMyRoleId = value.ToString();
 AddUpdatedFld(conQxRoleRightRelation.MyRoleId);
}
else if (conQxRoleRightRelation.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQxRoleRightRelation.RoleId);
}
else if (conQxRoleRightRelation.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxRoleRightRelation.QxPrjId);
}
else if (conQxRoleRightRelation.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxRoleRightRelation.UpdDate);
}
else if (conQxRoleRightRelation.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxRoleRightRelation.UpdUser);
}
else if (conQxRoleRightRelation.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxRoleRightRelation.Memo);
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
 AddUpdatedFld(conQxRoleRightRelation.mId);
}
}
/// <summary>
/// 主角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MyRoleId
{
get
{
return mstrMyRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMyRoleId = value;
}
else
{
 mstrMyRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxRoleRightRelation.MyRoleId);
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
 AddUpdatedFld(conQxRoleRightRelation.RoleId);
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
 AddUpdatedFld(conQxRoleRightRelation.QxPrjId);
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
 AddUpdatedFld(conQxRoleRightRelation.UpdDate);
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
 AddUpdatedFld(conQxRoleRightRelation.UpdUser);
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
 AddUpdatedFld(conQxRoleRightRelation.Memo);
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
 /// 角色赋权关系(QxRoleRightRelation)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxRoleRightRelation
{
public const string _CurrTabName = "QxRoleRightRelation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "MyRoleId", "RoleId", "QxPrjId", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //流水号

 /// <summary>
 /// 常量:"MyRoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MyRoleId = "MyRoleId";    //主角色Id

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

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