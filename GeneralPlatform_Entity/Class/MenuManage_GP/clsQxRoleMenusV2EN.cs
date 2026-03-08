
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRoleMenusV2EN
 表名:QxRoleMenusV2(00140114)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:18:35
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:菜单管理(MenuManage_GP)
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
 /// 表QxRoleMenusV2的关键字(RId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RId_QxRoleMenusV2
{
private int _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public int Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="intRId">表关键字</param>
public K_RId_QxRoleMenusV2(int intRId)
{
if (IsValid(intRId)) Value = intRId;
else
{
Value = 0;
}
}
private static bool IsValid(int intRId)
{
if (intRId == 0) return false;
if (intRId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_RId_QxRoleMenusV2]类型的对象</returns>
public static implicit operator K_RId_QxRoleMenusV2(int value)
{
return new K_RId_QxRoleMenusV2(value);
}
}
 /// <summary>
 /// 角色菜单V2(QxRoleMenusV2)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxRoleMenusV2EN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxRoleMenusV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RId,MeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 7;
public static string[] AttributeName = new string[] {"RId", "MeId", "QxPrjId", "IsDisp", "UpdDate", "UpdUserId", "Memo"};

protected int mintRId;    //角色Id
protected int mintMeId;    //菜单Id
protected string mstrQxPrjId;    //项目Id
protected bool mbolIsDisp;    //是否显示
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxRoleMenusV2EN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RId");
 lstKeyFldNames.Add("MeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "intRId">关键字:角色Id</param>
public clsQxRoleMenusV2EN(int intRId , int intMeId)
 {
 if (intRId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mintRId = intRId;
this.mintMeId = intMeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RId");
 lstKeyFldNames.Add("MeId");
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
if (strAttributeName  ==  conQxRoleMenusV2.RId)
{
return mintRId;
}
else if (strAttributeName  ==  conQxRoleMenusV2.MeId)
{
return mintMeId;
}
else if (strAttributeName  ==  conQxRoleMenusV2.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxRoleMenusV2.IsDisp)
{
return mbolIsDisp;
}
else if (strAttributeName  ==  conQxRoleMenusV2.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxRoleMenusV2.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conQxRoleMenusV2.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxRoleMenusV2.RId)
{
mintRId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxRoleMenusV2.RId);
}
else if (strAttributeName  ==  conQxRoleMenusV2.MeId)
{
mintMeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxRoleMenusV2.MeId);
}
else if (strAttributeName  ==  conQxRoleMenusV2.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxRoleMenusV2.QxPrjId);
}
else if (strAttributeName  ==  conQxRoleMenusV2.IsDisp)
{
mbolIsDisp = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxRoleMenusV2.IsDisp);
}
else if (strAttributeName  ==  conQxRoleMenusV2.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxRoleMenusV2.UpdDate);
}
else if (strAttributeName  ==  conQxRoleMenusV2.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxRoleMenusV2.UpdUserId);
}
else if (strAttributeName  ==  conQxRoleMenusV2.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxRoleMenusV2.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxRoleMenusV2.RId  ==  AttributeName[intIndex])
{
return mintRId;
}
else if (conQxRoleMenusV2.MeId  ==  AttributeName[intIndex])
{
return mintMeId;
}
else if (conQxRoleMenusV2.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxRoleMenusV2.IsDisp  ==  AttributeName[intIndex])
{
return mbolIsDisp;
}
else if (conQxRoleMenusV2.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxRoleMenusV2.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conQxRoleMenusV2.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxRoleMenusV2.RId  ==  AttributeName[intIndex])
{
mintRId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxRoleMenusV2.RId);
}
else if (conQxRoleMenusV2.MeId  ==  AttributeName[intIndex])
{
mintMeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxRoleMenusV2.MeId);
}
else if (conQxRoleMenusV2.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxRoleMenusV2.QxPrjId);
}
else if (conQxRoleMenusV2.IsDisp  ==  AttributeName[intIndex])
{
mbolIsDisp = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxRoleMenusV2.IsDisp);
}
else if (conQxRoleMenusV2.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxRoleMenusV2.UpdDate);
}
else if (conQxRoleMenusV2.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxRoleMenusV2.UpdUserId);
}
else if (conQxRoleMenusV2.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxRoleMenusV2.Memo);
}
}
}

/// <summary>
/// 角色Id(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int RId
{
get
{
return mintRId;
}
set
{
 mintRId = value;
//记录修改过的字段
 AddUpdatedFld(conQxRoleMenusV2.RId);
}
}
/// <summary>
/// 菜单Id(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int MeId
{
get
{
return mintMeId;
}
set
{
 mintMeId = value;
//记录修改过的字段
 AddUpdatedFld(conQxRoleMenusV2.MeId);
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
 AddUpdatedFld(conQxRoleMenusV2.QxPrjId);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDisp
{
get
{
return mbolIsDisp;
}
set
{
 mbolIsDisp = value;
//记录修改过的字段
 AddUpdatedFld(conQxRoleMenusV2.IsDisp);
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
 AddUpdatedFld(conQxRoleMenusV2.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
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
 AddUpdatedFld(conQxRoleMenusV2.UpdUserId);
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
 AddUpdatedFld(conQxRoleMenusV2.Memo);
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
  return mintRId.ToString();
 }
 }
}
 /// <summary>
 /// 角色菜单V2(QxRoleMenusV2)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxRoleMenusV2
{
public const string _CurrTabName = "QxRoleMenusV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RId,MeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RId", "MeId", "QxPrjId", "IsDisp", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RId = "RId";    //角色Id

 /// <summary>
 /// 常量:"MeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MeId = "MeId";    //菜单Id

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"IsDisp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDisp = "IsDisp";    //是否显示

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}