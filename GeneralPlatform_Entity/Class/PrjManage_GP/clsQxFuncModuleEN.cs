
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxFuncModuleEN
 表名:QxFuncModule(00140086)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:27:27
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程管理(PrjManage_GP)
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
 /// 表QxFuncModule的关键字(FuncModuleId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_FuncModuleId_QxFuncModule
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strFuncModuleId">表关键字</param>
public K_FuncModuleId_QxFuncModule(string strFuncModuleId)
{
if (IsValid(strFuncModuleId)) Value = strFuncModuleId;
else
{
Value = null;
}
}
private static bool IsValid(string strFuncModuleId)
{
if (string.IsNullOrEmpty(strFuncModuleId) == true) return false;
if (strFuncModuleId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_FuncModuleId_QxFuncModule]类型的对象</returns>
public static implicit operator K_FuncModuleId_QxFuncModule(string value)
{
return new K_FuncModuleId_QxFuncModule(value);
}
}
 /// <summary>
 /// 功能模块(QxFuncModule)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxFuncModuleEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxFuncModule"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "FuncModuleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "FuncModuleEnName", "OrderNum", "InUse", "QxPrjId", "UpdDate", "UpdUser"};

protected string mstrFuncModuleId;    //模块Id
protected string mstrFuncModuleName;    //模块名
protected string mstrFuncModuleNameSim;    //模块名_Sim
protected string mstrFuncModuleEnName;    //模块英文名
protected int mintOrderNum;    //排序号
protected bool mbolInUse;    //是否在用
protected string mstrQxPrjId;    //项目Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUser;    //修改用户

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxFuncModuleEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncModuleId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strFuncModuleId">关键字:模块Id</param>
public clsQxFuncModuleEN(string strFuncModuleId)
 {
strFuncModuleId = strFuncModuleId.Replace("'", "''");
if (strFuncModuleId.Length > 4)
{
throw new Exception("在表:QxFuncModule中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strFuncModuleId)  ==  true)
{
throw new Exception("在表:QxFuncModule中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncModuleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrFuncModuleId = strFuncModuleId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("FuncModuleId");
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
if (strAttributeName  ==  conQxFuncModule.FuncModuleId)
{
return mstrFuncModuleId;
}
else if (strAttributeName  ==  conQxFuncModule.FuncModuleName)
{
return mstrFuncModuleName;
}
else if (strAttributeName  ==  conQxFuncModule.FuncModuleNameSim)
{
return mstrFuncModuleNameSim;
}
else if (strAttributeName  ==  conQxFuncModule.FuncModuleEnName)
{
return mstrFuncModuleEnName;
}
else if (strAttributeName  ==  conQxFuncModule.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conQxFuncModule.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conQxFuncModule.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxFuncModule.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxFuncModule.UpdUser)
{
return mstrUpdUser;
}
return null;
}
set
{
if (strAttributeName  ==  conQxFuncModule.FuncModuleId)
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conQxFuncModule.FuncModuleId);
}
else if (strAttributeName  ==  conQxFuncModule.FuncModuleName)
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(conQxFuncModule.FuncModuleName);
}
else if (strAttributeName  ==  conQxFuncModule.FuncModuleNameSim)
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(conQxFuncModule.FuncModuleNameSim);
}
else if (strAttributeName  ==  conQxFuncModule.FuncModuleEnName)
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(conQxFuncModule.FuncModuleEnName);
}
else if (strAttributeName  ==  conQxFuncModule.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxFuncModule.OrderNum);
}
else if (strAttributeName  ==  conQxFuncModule.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxFuncModule.InUse);
}
else if (strAttributeName  ==  conQxFuncModule.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxFuncModule.QxPrjId);
}
else if (strAttributeName  ==  conQxFuncModule.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxFuncModule.UpdDate);
}
else if (strAttributeName  ==  conQxFuncModule.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxFuncModule.UpdUser);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxFuncModule.FuncModuleId  ==  AttributeName[intIndex])
{
return mstrFuncModuleId;
}
else if (conQxFuncModule.FuncModuleName  ==  AttributeName[intIndex])
{
return mstrFuncModuleName;
}
else if (conQxFuncModule.FuncModuleNameSim  ==  AttributeName[intIndex])
{
return mstrFuncModuleNameSim;
}
else if (conQxFuncModule.FuncModuleEnName  ==  AttributeName[intIndex])
{
return mstrFuncModuleEnName;
}
else if (conQxFuncModule.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conQxFuncModule.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (conQxFuncModule.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxFuncModule.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxFuncModule.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
return null;
}
set
{
if (conQxFuncModule.FuncModuleId  ==  AttributeName[intIndex])
{
mstrFuncModuleId = value.ToString();
 AddUpdatedFld(conQxFuncModule.FuncModuleId);
}
else if (conQxFuncModule.FuncModuleName  ==  AttributeName[intIndex])
{
mstrFuncModuleName = value.ToString();
 AddUpdatedFld(conQxFuncModule.FuncModuleName);
}
else if (conQxFuncModule.FuncModuleNameSim  ==  AttributeName[intIndex])
{
mstrFuncModuleNameSim = value.ToString();
 AddUpdatedFld(conQxFuncModule.FuncModuleNameSim);
}
else if (conQxFuncModule.FuncModuleEnName  ==  AttributeName[intIndex])
{
mstrFuncModuleEnName = value.ToString();
 AddUpdatedFld(conQxFuncModule.FuncModuleEnName);
}
else if (conQxFuncModule.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxFuncModule.OrderNum);
}
else if (conQxFuncModule.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxFuncModule.InUse);
}
else if (conQxFuncModule.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxFuncModule.QxPrjId);
}
else if (conQxFuncModule.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxFuncModule.UpdDate);
}
else if (conQxFuncModule.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxFuncModule.UpdUser);
}
}
}

/// <summary>
/// 模块Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleId
{
get
{
return mstrFuncModuleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleId = value;
}
else
{
 mstrFuncModuleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxFuncModule.FuncModuleId);
}
}
/// <summary>
/// 模块名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleName
{
get
{
return mstrFuncModuleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleName = value;
}
else
{
 mstrFuncModuleName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxFuncModule.FuncModuleName);
}
}
/// <summary>
/// 模块名_Sim(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleNameSim
{
get
{
return mstrFuncModuleNameSim;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleNameSim = value;
}
else
{
 mstrFuncModuleNameSim = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxFuncModule.FuncModuleNameSim);
}
}
/// <summary>
/// 模块英文名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FuncModuleEnName
{
get
{
return mstrFuncModuleEnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFuncModuleEnName = value;
}
else
{
 mstrFuncModuleEnName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxFuncModule.FuncModuleEnName);
}
}
/// <summary>
/// 排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(conQxFuncModule.OrderNum);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(conQxFuncModule.InUse);
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
 AddUpdatedFld(conQxFuncModule.QxPrjId);
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
 AddUpdatedFld(conQxFuncModule.UpdDate);
}
}
/// <summary>
/// 修改用户(说明:;字段类型:varchar;字段长度:18;是否可空:True)
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
 AddUpdatedFld(conQxFuncModule.UpdUser);
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
  return mstrFuncModuleId;
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
  return mstrFuncModuleName;
 }
 }
}
 /// <summary>
 /// 功能模块(QxFuncModule)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxFuncModule
{
public const string _CurrTabName = "QxFuncModule"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "FuncModuleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"FuncModuleId", "FuncModuleName", "FuncModuleNameSim", "FuncModuleEnName", "OrderNum", "InUse", "QxPrjId", "UpdDate", "UpdUser"};
//以下是属性变量


 /// <summary>
 /// 常量:"FuncModuleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleId = "FuncModuleId";    //模块Id

 /// <summary>
 /// 常量:"FuncModuleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleName = "FuncModuleName";    //模块名

 /// <summary>
 /// 常量:"FuncModuleNameSim"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleNameSim = "FuncModuleNameSim";    //模块名_Sim

 /// <summary>
 /// 常量:"FuncModuleEnName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FuncModuleEnName = "FuncModuleEnName";    //模块英文名

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

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
}

}