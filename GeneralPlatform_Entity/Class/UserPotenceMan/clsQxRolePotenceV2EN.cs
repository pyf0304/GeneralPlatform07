
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRolePotenceV2EN
 表名:QxRolePotenceV2(00140117)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:31:07
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户权限管理(UserPotenceMan)
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
 /// 表QxRolePotenceV2的关键字(RId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_RId_QxRolePotenceV2
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
public K_RId_QxRolePotenceV2(int intRId)
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
 /// <returns>返回:[K_RId_QxRolePotenceV2]类型的对象</returns>
public static implicit operator K_RId_QxRolePotenceV2(int value)
{
return new K_RId_QxRolePotenceV2(value);
}
}
 /// <summary>
 /// 角色权限关系V2(QxRolePotenceV2)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxRolePotenceV2EN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxRolePotenceV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "RId,PId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"RId", "PId", "QxPrjId", "Memo"};

protected int mintRId;    //角色Id
protected int mintPId;    //菜单Id
protected string mstrQxPrjId;    //项目Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxRolePotenceV2EN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RId");
 lstKeyFldNames.Add("PId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "intRId">关键字:角色Id</param>
public clsQxRolePotenceV2EN(int intRId , int intPId)
 {
 if (intRId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mintRId = intRId;
this.mintPId = intPId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("RId");
 lstKeyFldNames.Add("PId");
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
if (strAttributeName  ==  conQxRolePotenceV2.RId)
{
return mintRId;
}
else if (strAttributeName  ==  conQxRolePotenceV2.PId)
{
return mintPId;
}
else if (strAttributeName  ==  conQxRolePotenceV2.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxRolePotenceV2.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxRolePotenceV2.RId)
{
mintRId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxRolePotenceV2.RId);
}
else if (strAttributeName  ==  conQxRolePotenceV2.PId)
{
mintPId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxRolePotenceV2.PId);
}
else if (strAttributeName  ==  conQxRolePotenceV2.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxRolePotenceV2.QxPrjId);
}
else if (strAttributeName  ==  conQxRolePotenceV2.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxRolePotenceV2.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxRolePotenceV2.RId  ==  AttributeName[intIndex])
{
return mintRId;
}
else if (conQxRolePotenceV2.PId  ==  AttributeName[intIndex])
{
return mintPId;
}
else if (conQxRolePotenceV2.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxRolePotenceV2.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxRolePotenceV2.RId  ==  AttributeName[intIndex])
{
mintRId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxRolePotenceV2.RId);
}
else if (conQxRolePotenceV2.PId  ==  AttributeName[intIndex])
{
mintPId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxRolePotenceV2.PId);
}
else if (conQxRolePotenceV2.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxRolePotenceV2.QxPrjId);
}
else if (conQxRolePotenceV2.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxRolePotenceV2.Memo);
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
 AddUpdatedFld(conQxRolePotenceV2.RId);
}
}
/// <summary>
/// 菜单Id(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int PId
{
get
{
return mintPId;
}
set
{
 mintPId = value;
//记录修改过的字段
 AddUpdatedFld(conQxRolePotenceV2.PId);
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
 AddUpdatedFld(conQxRolePotenceV2.QxPrjId);
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
 AddUpdatedFld(conQxRolePotenceV2.Memo);
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
 /// 角色权限关系V2(QxRolePotenceV2)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxRolePotenceV2
{
public const string _CurrTabName = "QxRolePotenceV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "RId,PId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"RId", "PId", "QxPrjId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"RId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RId = "RId";    //角色Id

 /// <summary>
 /// 常量:"PId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PId = "PId";    //菜单Id

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