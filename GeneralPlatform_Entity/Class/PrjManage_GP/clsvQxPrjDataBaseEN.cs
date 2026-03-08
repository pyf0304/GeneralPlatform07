
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjDataBaseEN
 表名:vQxPrjDataBase(00140040)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:32:51
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
 /// 表vQxPrjDataBase的关键字(QxPrjDataBaseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_QxPrjDataBaseId_vQxPrjDataBase
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
public K_QxPrjDataBaseId_vQxPrjDataBase(string strQxPrjDataBaseId)
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
 /// <returns>返回:[K_QxPrjDataBaseId_vQxPrjDataBase]类型的对象</returns>
public static implicit operator K_QxPrjDataBaseId_vQxPrjDataBase(string value)
{
return new K_QxPrjDataBaseId_vQxPrjDataBase(value);
}
}
 /// <summary>
 /// v数据库对象(vQxPrjDataBase)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxPrjDataBaseEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxPrjDataBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "QxPrjDataBaseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"QxPrjDataBaseId", "PrjDataBaseName", "IpAddress", "DataBaseUserId", "DataBasePwd", "DataBaseName", "DataBaseTypeName", "DataBaseTypeId", "DatabaseOwner", "TableSpace", "UpdDate", "SID", "UserId", "Memo"};

protected string mstrQxPrjDataBaseId;    //项目数据库Id
protected string mstrPrjDataBaseName;    //项目数据库名
protected string mstrIpAddress;    //IP地址
protected string mstrDataBaseUserId;    //数据库用户Id
protected string mstrDataBasePwd;    //数据库用户口令
protected string mstrDataBaseName;    //数据库名称
protected string mstrDataBaseTypeName;    //数据库类型名
protected string mstrDataBaseTypeId;    //数据库类型ID
protected string mstrDatabaseOwner;    //数据库拥有者
protected string mstrTableSpace;    //表空间
protected string mstrUpdDate;    //修改日期
protected string mstrSID;    //SID
protected string mstrUserId;    //用户ID
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxPrjDataBaseEN()
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
public clsvQxPrjDataBaseEN(string strQxPrjDataBaseId)
 {
strQxPrjDataBaseId = strQxPrjDataBaseId.Replace("'", "''");
if (strQxPrjDataBaseId.Length > 4)
{
throw new Exception("在表:vQxPrjDataBase中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strQxPrjDataBaseId)  ==  true)
{
throw new Exception("在表:vQxPrjDataBase中,关键字不能为空 或 null!");
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
if (strAttributeName  ==  convQxPrjDataBase.QxPrjDataBaseId)
{
return mstrQxPrjDataBaseId;
}
else if (strAttributeName  ==  convQxPrjDataBase.PrjDataBaseName)
{
return mstrPrjDataBaseName;
}
else if (strAttributeName  ==  convQxPrjDataBase.IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  convQxPrjDataBase.DataBaseUserId)
{
return mstrDataBaseUserId;
}
else if (strAttributeName  ==  convQxPrjDataBase.DataBasePwd)
{
return mstrDataBasePwd;
}
else if (strAttributeName  ==  convQxPrjDataBase.DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  convQxPrjDataBase.DataBaseTypeName)
{
return mstrDataBaseTypeName;
}
else if (strAttributeName  ==  convQxPrjDataBase.DataBaseTypeId)
{
return mstrDataBaseTypeId;
}
else if (strAttributeName  ==  convQxPrjDataBase.DatabaseOwner)
{
return mstrDatabaseOwner;
}
else if (strAttributeName  ==  convQxPrjDataBase.TableSpace)
{
return mstrTableSpace;
}
else if (strAttributeName  ==  convQxPrjDataBase.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxPrjDataBase.SID)
{
return mstrSID;
}
else if (strAttributeName  ==  convQxPrjDataBase.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  convQxPrjDataBase.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxPrjDataBase.QxPrjDataBaseId)
{
mstrQxPrjDataBaseId = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.QxPrjDataBaseId);
}
else if (strAttributeName  ==  convQxPrjDataBase.PrjDataBaseName)
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.PrjDataBaseName);
}
else if (strAttributeName  ==  convQxPrjDataBase.IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.IpAddress);
}
else if (strAttributeName  ==  convQxPrjDataBase.DataBaseUserId)
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.DataBaseUserId);
}
else if (strAttributeName  ==  convQxPrjDataBase.DataBasePwd)
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.DataBasePwd);
}
else if (strAttributeName  ==  convQxPrjDataBase.DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.DataBaseName);
}
else if (strAttributeName  ==  convQxPrjDataBase.DataBaseTypeName)
{
mstrDataBaseTypeName = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.DataBaseTypeName);
}
else if (strAttributeName  ==  convQxPrjDataBase.DataBaseTypeId)
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.DataBaseTypeId);
}
else if (strAttributeName  ==  convQxPrjDataBase.DatabaseOwner)
{
mstrDatabaseOwner = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.DatabaseOwner);
}
else if (strAttributeName  ==  convQxPrjDataBase.TableSpace)
{
mstrTableSpace = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.TableSpace);
}
else if (strAttributeName  ==  convQxPrjDataBase.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.UpdDate);
}
else if (strAttributeName  ==  convQxPrjDataBase.SID)
{
mstrSID = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.SID);
}
else if (strAttributeName  ==  convQxPrjDataBase.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.UserId);
}
else if (strAttributeName  ==  convQxPrjDataBase.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxPrjDataBase.QxPrjDataBaseId  ==  AttributeName[intIndex])
{
return mstrQxPrjDataBaseId;
}
else if (convQxPrjDataBase.PrjDataBaseName  ==  AttributeName[intIndex])
{
return mstrPrjDataBaseName;
}
else if (convQxPrjDataBase.IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (convQxPrjDataBase.DataBaseUserId  ==  AttributeName[intIndex])
{
return mstrDataBaseUserId;
}
else if (convQxPrjDataBase.DataBasePwd  ==  AttributeName[intIndex])
{
return mstrDataBasePwd;
}
else if (convQxPrjDataBase.DataBaseName  ==  AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (convQxPrjDataBase.DataBaseTypeName  ==  AttributeName[intIndex])
{
return mstrDataBaseTypeName;
}
else if (convQxPrjDataBase.DataBaseTypeId  ==  AttributeName[intIndex])
{
return mstrDataBaseTypeId;
}
else if (convQxPrjDataBase.DatabaseOwner  ==  AttributeName[intIndex])
{
return mstrDatabaseOwner;
}
else if (convQxPrjDataBase.TableSpace  ==  AttributeName[intIndex])
{
return mstrTableSpace;
}
else if (convQxPrjDataBase.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxPrjDataBase.SID  ==  AttributeName[intIndex])
{
return mstrSID;
}
else if (convQxPrjDataBase.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (convQxPrjDataBase.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxPrjDataBase.QxPrjDataBaseId  ==  AttributeName[intIndex])
{
mstrQxPrjDataBaseId = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.QxPrjDataBaseId);
}
else if (convQxPrjDataBase.PrjDataBaseName  ==  AttributeName[intIndex])
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.PrjDataBaseName);
}
else if (convQxPrjDataBase.IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.IpAddress);
}
else if (convQxPrjDataBase.DataBaseUserId  ==  AttributeName[intIndex])
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.DataBaseUserId);
}
else if (convQxPrjDataBase.DataBasePwd  ==  AttributeName[intIndex])
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.DataBasePwd);
}
else if (convQxPrjDataBase.DataBaseName  ==  AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.DataBaseName);
}
else if (convQxPrjDataBase.DataBaseTypeName  ==  AttributeName[intIndex])
{
mstrDataBaseTypeName = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.DataBaseTypeName);
}
else if (convQxPrjDataBase.DataBaseTypeId  ==  AttributeName[intIndex])
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.DataBaseTypeId);
}
else if (convQxPrjDataBase.DatabaseOwner  ==  AttributeName[intIndex])
{
mstrDatabaseOwner = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.DatabaseOwner);
}
else if (convQxPrjDataBase.TableSpace  ==  AttributeName[intIndex])
{
mstrTableSpace = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.TableSpace);
}
else if (convQxPrjDataBase.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.UpdDate);
}
else if (convQxPrjDataBase.SID  ==  AttributeName[intIndex])
{
mstrSID = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.SID);
}
else if (convQxPrjDataBase.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.UserId);
}
else if (convQxPrjDataBase.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPrjDataBase.Memo);
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
 AddUpdatedFld(convQxPrjDataBase.QxPrjDataBaseId);
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
 AddUpdatedFld(convQxPrjDataBase.PrjDataBaseName);
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
 AddUpdatedFld(convQxPrjDataBase.IpAddress);
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
 AddUpdatedFld(convQxPrjDataBase.DataBaseUserId);
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
 AddUpdatedFld(convQxPrjDataBase.DataBasePwd);
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
 AddUpdatedFld(convQxPrjDataBase.DataBaseName);
}
}
/// <summary>
/// 数据库类型名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string DataBaseTypeName
{
get
{
return mstrDataBaseTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrDataBaseTypeName = value;
}
else
{
 mstrDataBaseTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjDataBase.DataBaseTypeName);
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
 AddUpdatedFld(convQxPrjDataBase.DataBaseTypeId);
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
 AddUpdatedFld(convQxPrjDataBase.DatabaseOwner);
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
 AddUpdatedFld(convQxPrjDataBase.TableSpace);
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
 AddUpdatedFld(convQxPrjDataBase.UpdDate);
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
 AddUpdatedFld(convQxPrjDataBase.SID);
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
 AddUpdatedFld(convQxPrjDataBase.UserId);
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
 AddUpdatedFld(convQxPrjDataBase.Memo);
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
 /// v数据库对象(vQxPrjDataBase)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxPrjDataBase
{
public const string _CurrTabName = "vQxPrjDataBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QxPrjDataBaseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QxPrjDataBaseId", "PrjDataBaseName", "IpAddress", "DataBaseUserId", "DataBasePwd", "DataBaseName", "DataBaseTypeName", "DataBaseTypeId", "DatabaseOwner", "TableSpace", "UpdDate", "SID", "UserId", "Memo"};
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
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //IP地址

 /// <summary>
 /// 常量:"DataBaseUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseUserId = "DataBaseUserId";    //数据库用户Id

 /// <summary>
 /// 常量:"DataBasePwd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBasePwd = "DataBasePwd";    //数据库用户口令

 /// <summary>
 /// 常量:"DataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseName = "DataBaseName";    //数据库名称

 /// <summary>
 /// 常量:"DataBaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseTypeName = "DataBaseTypeName";    //数据库类型名

 /// <summary>
 /// 常量:"DataBaseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DataBaseTypeId = "DataBaseTypeId";    //数据库类型ID

 /// <summary>
 /// 常量:"DatabaseOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DatabaseOwner = "DatabaseOwner";    //数据库拥有者

 /// <summary>
 /// 常量:"TableSpace"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TableSpace = "TableSpace";    //表空间

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"SID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SID = "SID";    //SID

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}