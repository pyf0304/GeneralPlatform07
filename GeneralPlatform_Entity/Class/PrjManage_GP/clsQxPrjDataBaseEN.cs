
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjDataBaseEN
 表名:QxPrjDataBase(00140039)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:28:46
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
 /// 表QxPrjDataBase的关键字(QxPrjDataBaseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QxPrjDataBaseId_QxPrjDataBase
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strQxPrjDataBaseId">表关键字</param>
public K_QxPrjDataBaseId_QxPrjDataBase(string strQxPrjDataBaseId)
{
if (IsValid(strQxPrjDataBaseId)) Value = strQxPrjDataBaseId;
else
{
Value = null;
}
}
private static bool IsValid(string strQxPrjDataBaseId)
{
if (string.IsNullOrEmpty(strQxPrjDataBaseId) == true) return false;
if (strQxPrjDataBaseId.Length != 4) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_QxPrjDataBaseId_QxPrjDataBase]类型的对象</returns>
public static implicit operator K_QxPrjDataBaseId_QxPrjDataBase(string value)
{
return new K_QxPrjDataBaseId_QxPrjDataBase(value);
}
}
 /// <summary>
 /// 数据库对象(QxPrjDataBase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxPrjDataBaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxPrjDataBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QxPrjDataBaseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 13;
public static string[] AttributeName = new string[] {"QxPrjDataBaseId", "PrjDataBaseName", "DataBaseName", "DatabaseOwner", "DataBasePwd", "DataBaseTypeId", "DataBaseUserId", "IpAddress", "SID", "TableSpace", "UserId", "UpdDate", "Memo"};

protected string mstrQxPrjDataBaseId;    //项目数据库Id
protected string mstrPrjDataBaseName;    //项目数据库名
protected string mstrDataBaseName;    //数据库名称
protected string mstrDatabaseOwner;    //数据库拥有者
protected string mstrDataBasePwd;    //数据库用户口令
protected string mstrDataBaseTypeId;    //数据库类型ID
protected string mstrDataBaseUserId;    //数据库用户Id
protected string mstrIpAddress;    //IP地址
protected string mstrSID;    //SID
protected string mstrTableSpace;    //表空间
protected string mstrUserId;    //用户ID
protected string mstrUpdDate;    //修改日期
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxPrjDataBaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QxPrjDataBaseId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strQxPrjDataBaseId">关键字:项目数据库Id</param>
public clsQxPrjDataBaseEN(string strQxPrjDataBaseId)
 {
strQxPrjDataBaseId = strQxPrjDataBaseId.Replace("'", "''");
if (strQxPrjDataBaseId.Length > 4)
{
throw new Exception("在表:QxPrjDataBase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQxPrjDataBaseId)  ==  true)
{
throw new Exception("在表:QxPrjDataBase中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQxPrjDataBaseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrQxPrjDataBaseId = strQxPrjDataBaseId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("QxPrjDataBaseId");
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
if (strAttributeName  ==  conQxPrjDataBase.QxPrjDataBaseId)
{
return mstrQxPrjDataBaseId;
}
else if (strAttributeName  ==  conQxPrjDataBase.PrjDataBaseName)
{
return mstrPrjDataBaseName;
}
else if (strAttributeName  ==  conQxPrjDataBase.DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  conQxPrjDataBase.DatabaseOwner)
{
return mstrDatabaseOwner;
}
else if (strAttributeName  ==  conQxPrjDataBase.DataBasePwd)
{
return mstrDataBasePwd;
}
else if (strAttributeName  ==  conQxPrjDataBase.DataBaseTypeId)
{
return mstrDataBaseTypeId;
}
else if (strAttributeName  ==  conQxPrjDataBase.DataBaseUserId)
{
return mstrDataBaseUserId;
}
else if (strAttributeName  ==  conQxPrjDataBase.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  conQxPrjDataBase.SID)
{
return mstrSID;
}
else if (strAttributeName  ==  conQxPrjDataBase.TableSpace)
{
return mstrTableSpace;
}
else if (strAttributeName  ==  conQxPrjDataBase.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conQxPrjDataBase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxPrjDataBase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxPrjDataBase.QxPrjDataBaseId)
{
mstrQxPrjDataBaseId = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.QxPrjDataBaseId);
}
else if (strAttributeName  ==  conQxPrjDataBase.PrjDataBaseName)
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.PrjDataBaseName);
}
else if (strAttributeName  ==  conQxPrjDataBase.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.DataBaseName);
}
else if (strAttributeName  ==  conQxPrjDataBase.DatabaseOwner)
{
mstrDatabaseOwner = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.DatabaseOwner);
}
else if (strAttributeName  ==  conQxPrjDataBase.DataBasePwd)
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.DataBasePwd);
}
else if (strAttributeName  ==  conQxPrjDataBase.DataBaseTypeId)
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.DataBaseTypeId);
}
else if (strAttributeName  ==  conQxPrjDataBase.DataBaseUserId)
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.DataBaseUserId);
}
else if (strAttributeName  ==  conQxPrjDataBase.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.IpAddress);
}
else if (strAttributeName  ==  conQxPrjDataBase.SID)
{
mstrSID = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.SID);
}
else if (strAttributeName  ==  conQxPrjDataBase.TableSpace)
{
mstrTableSpace = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.TableSpace);
}
else if (strAttributeName  ==  conQxPrjDataBase.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.UserId);
}
else if (strAttributeName  ==  conQxPrjDataBase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.UpdDate);
}
else if (strAttributeName  ==  conQxPrjDataBase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxPrjDataBase.QxPrjDataBaseId  ==  AttributeName[intIndex])
{
return mstrQxPrjDataBaseId;
}
else if (conQxPrjDataBase.PrjDataBaseName  ==  AttributeName[intIndex])
{
return mstrPrjDataBaseName;
}
else if (conQxPrjDataBase.DataBaseName  ==  AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (conQxPrjDataBase.DatabaseOwner  ==  AttributeName[intIndex])
{
return mstrDatabaseOwner;
}
else if (conQxPrjDataBase.DataBasePwd  ==  AttributeName[intIndex])
{
return mstrDataBasePwd;
}
else if (conQxPrjDataBase.DataBaseTypeId  ==  AttributeName[intIndex])
{
return mstrDataBaseTypeId;
}
else if (conQxPrjDataBase.DataBaseUserId  ==  AttributeName[intIndex])
{
return mstrDataBaseUserId;
}
else if (conQxPrjDataBase.IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (conQxPrjDataBase.SID  ==  AttributeName[intIndex])
{
return mstrSID;
}
else if (conQxPrjDataBase.TableSpace  ==  AttributeName[intIndex])
{
return mstrTableSpace;
}
else if (conQxPrjDataBase.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conQxPrjDataBase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxPrjDataBase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxPrjDataBase.QxPrjDataBaseId  ==  AttributeName[intIndex])
{
mstrQxPrjDataBaseId = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.QxPrjDataBaseId);
}
else if (conQxPrjDataBase.PrjDataBaseName  ==  AttributeName[intIndex])
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.PrjDataBaseName);
}
else if (conQxPrjDataBase.DataBaseName  ==  AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.DataBaseName);
}
else if (conQxPrjDataBase.DatabaseOwner  ==  AttributeName[intIndex])
{
mstrDatabaseOwner = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.DatabaseOwner);
}
else if (conQxPrjDataBase.DataBasePwd  ==  AttributeName[intIndex])
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.DataBasePwd);
}
else if (conQxPrjDataBase.DataBaseTypeId  ==  AttributeName[intIndex])
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.DataBaseTypeId);
}
else if (conQxPrjDataBase.DataBaseUserId  ==  AttributeName[intIndex])
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.DataBaseUserId);
}
else if (conQxPrjDataBase.IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.IpAddress);
}
else if (conQxPrjDataBase.SID  ==  AttributeName[intIndex])
{
mstrSID = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.SID);
}
else if (conQxPrjDataBase.TableSpace  ==  AttributeName[intIndex])
{
mstrTableSpace = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.TableSpace);
}
else if (conQxPrjDataBase.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.UserId);
}
else if (conQxPrjDataBase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.UpdDate);
}
else if (conQxPrjDataBase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjDataBase.Memo);
}
}
}

/// <summary>
/// 项目数据库Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QxPrjDataBaseId
{
get
{
return mstrQxPrjDataBaseId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQxPrjDataBaseId = value;
}
else
{
 mstrQxPrjDataBaseId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjDataBase.QxPrjDataBaseId);
}
}
/// <summary>
/// 项目数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjDataBaseName
{
get
{
return mstrPrjDataBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjDataBaseName = value;
}
else
{
 mstrPrjDataBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjDataBase.PrjDataBaseName);
}
}
/// <summary>
/// 数据库名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseName
{
get
{
return mstrDataBaseName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseName = value;
}
else
{
 mstrDataBaseName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjDataBase.DataBaseName);
}
}
/// <summary>
/// 数据库拥有者(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DatabaseOwner
{
get
{
return mstrDatabaseOwner;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDatabaseOwner = value;
}
else
{
 mstrDatabaseOwner = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjDataBase.DatabaseOwner);
}
}
/// <summary>
/// 数据库用户口令(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBasePwd
{
get
{
return mstrDataBasePwd;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBasePwd = value;
}
else
{
 mstrDataBasePwd = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjDataBase.DataBasePwd);
}
}
/// <summary>
/// 数据库类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseTypeId
{
get
{
return mstrDataBaseTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseTypeId = value;
}
else
{
 mstrDataBaseTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjDataBase.DataBaseTypeId);
}
}
/// <summary>
/// 数据库用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseUserId
{
get
{
return mstrDataBaseUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseUserId = value;
}
else
{
 mstrDataBaseUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjDataBase.DataBaseUserId);
}
}
/// <summary>
/// IP地址(说明:;字段类型:varchar;字段长度:23;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IpAddress
{
get
{
return mstrIpAddress;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIpAddress = value;
}
else
{
 mstrIpAddress = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjDataBase.IpAddress);
}
}
/// <summary>
/// SID(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SID
{
get
{
return mstrSID;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSID = value;
}
else
{
 mstrSID = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjDataBase.SID);
}
}
/// <summary>
/// 表空间(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TableSpace
{
get
{
return mstrTableSpace;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTableSpace = value;
}
else
{
 mstrTableSpace = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjDataBase.TableSpace);
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
 AddUpdatedFld(conQxPrjDataBase.UserId);
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
 AddUpdatedFld(conQxPrjDataBase.UpdDate);
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
 AddUpdatedFld(conQxPrjDataBase.Memo);
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
  return mstrQxPrjDataBaseId;
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
  return mstrPrjDataBaseName;
 }
 }
}
 /// <summary>
 /// 数据库对象(QxPrjDataBase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxPrjDataBase
{
public const string _CurrTabName = "QxPrjDataBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QxPrjDataBaseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QxPrjDataBaseId", "PrjDataBaseName", "DataBaseName", "DatabaseOwner", "DataBasePwd", "DataBaseTypeId", "DataBaseUserId", "IpAddress", "SID", "TableSpace", "UserId", "UpdDate", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"QxPrjDataBaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjDataBaseId = "QxPrjDataBaseId";    //项目数据库Id

 /// <summary>
 /// 常量:"PrjDataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjDataBaseName = "PrjDataBaseName";    //项目数据库名

 /// <summary>
 /// 常量:"DataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseName = "DataBaseName";    //数据库名称

 /// <summary>
 /// 常量:"DatabaseOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DatabaseOwner = "DatabaseOwner";    //数据库拥有者

 /// <summary>
 /// 常量:"DataBasePwd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBasePwd = "DataBasePwd";    //数据库用户口令

 /// <summary>
 /// 常量:"DataBaseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseTypeId = "DataBaseTypeId";    //数据库类型ID

 /// <summary>
 /// 常量:"DataBaseUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseUserId = "DataBaseUserId";    //数据库用户Id

 /// <summary>
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //IP地址

 /// <summary>
 /// 常量:"SID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SID = "SID";    //SID

 /// <summary>
 /// 常量:"TableSpace"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableSpace = "TableSpace";    //表空间

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}