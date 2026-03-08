
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPageDispModeEN
 表名:QxPageDispMode(00140044)
 * 版本:2024.08.23.1(服务器:WIN-SRV103-116)
 日期:2024/08/29 07:13:39
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
 /// 表QxPageDispMode的关键字(PageDispModeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PageDispModeId_QxPageDispMode
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPageDispModeId">表关键字</param>
public K_PageDispModeId_QxPageDispMode(string strPageDispModeId)
{
if (IsValid(strPageDispModeId)) Value = strPageDispModeId;
else
{
Value = null;
}
}
private static bool IsValid(string strPageDispModeId)
{
if (string.IsNullOrEmpty(strPageDispModeId) == true) return false;
if (strPageDispModeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PageDispModeId_QxPageDispMode]类型的对象</returns>
public static implicit operator K_PageDispModeId_QxPageDispMode(string value)
{
return new K_PageDispModeId_QxPageDispMode(value);
}
}
 /// <summary>
 /// 页面显示模式(QxPageDispMode)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxPageDispModeEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxPageDispMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PageDispModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 3;
public static string[] AttributeName = new string[] {"PageDispModeId", "PageDispModeName", "Memo"};

protected string mstrPageDispModeId;    //页面显示模式Id
protected string mstrPageDispModeName;    //页面显示模式名称
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxPageDispModeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PageDispModeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPageDispModeId">关键字:页面显示模式Id</param>
public clsQxPageDispModeEN(string strPageDispModeId)
 {
strPageDispModeId = strPageDispModeId.Replace("'", "''");
if (strPageDispModeId.Length > 2)
{
throw new Exception("在表:QxPageDispMode中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPageDispModeId)  ==  true)
{
throw new Exception("在表:QxPageDispMode中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPageDispModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPageDispModeId = strPageDispModeId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PageDispModeId");
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
if (strAttributeName  ==  conQxPageDispMode.PageDispModeId)
{
return mstrPageDispModeId;
}
else if (strAttributeName  ==  conQxPageDispMode.PageDispModeName)
{
return mstrPageDispModeName;
}
else if (strAttributeName  ==  conQxPageDispMode.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxPageDispMode.PageDispModeId)
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(conQxPageDispMode.PageDispModeId);
}
else if (strAttributeName  ==  conQxPageDispMode.PageDispModeName)
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(conQxPageDispMode.PageDispModeName);
}
else if (strAttributeName  ==  conQxPageDispMode.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPageDispMode.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxPageDispMode.PageDispModeId  ==  AttributeName[intIndex])
{
return mstrPageDispModeId;
}
else if (conQxPageDispMode.PageDispModeName  ==  AttributeName[intIndex])
{
return mstrPageDispModeName;
}
else if (conQxPageDispMode.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxPageDispMode.PageDispModeId  ==  AttributeName[intIndex])
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(conQxPageDispMode.PageDispModeId);
}
else if (conQxPageDispMode.PageDispModeName  ==  AttributeName[intIndex])
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(conQxPageDispMode.PageDispModeName);
}
else if (conQxPageDispMode.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPageDispMode.Memo);
}
}
}

/// <summary>
/// 页面显示模式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageDispModeId
{
get
{
return mstrPageDispModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageDispModeId = value;
}
else
{
 mstrPageDispModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPageDispMode.PageDispModeId);
}
}
/// <summary>
/// 页面显示模式名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageDispModeName
{
get
{
return mstrPageDispModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageDispModeName = value;
}
else
{
 mstrPageDispModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPageDispMode.PageDispModeName);
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
 AddUpdatedFld(conQxPageDispMode.Memo);
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
  return mstrPageDispModeId;
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
  return mstrPageDispModeName;
 }
 }
}
 /// <summary>
 /// 页面显示模式(QxPageDispMode)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxPageDispMode
{
public const string _CurrTabName = "QxPageDispMode"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PageDispModeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PageDispModeId", "PageDispModeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PageDispModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageDispModeId = "PageDispModeId";    //页面显示模式Id

 /// <summary>
 /// 常量:"PageDispModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageDispModeName = "PageDispModeName";    //页面显示模式名称

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}