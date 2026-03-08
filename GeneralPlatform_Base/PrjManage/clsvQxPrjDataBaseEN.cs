
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjDataBaseEN
 表名:vQxPrjDataBase(00140040)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 09:57:43
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:工程管理
 模块英文名:PrjManage
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
 /// 表vQxPrjDataBase的关键字(QxPrjDataBaseId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_QxPrjDataBaseId_vQxPrjDataBase
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
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
public const string _CurrTabName_S = "vQxPrjDataBase"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QxPrjDataBaseId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 14;
public static string[] AttributeName = new string[] {"QxPrjDataBaseId", "PrjDataBaseName", "IpAddress", "DataBaseUserId", "DataBasePwd", "DataBaseName", "DataBaseTypeName", "DataBaseTypeId", "DatabaseOwner", "TableSpace", "UpdDate", "SID", "UserId", "Memo"};
//以下是属性变量

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
 /// 常量:"QxPrjDataBaseId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QxPrjDataBaseId = "QxPrjDataBaseId";    //项目数据库Id

 /// <summary>
 /// 常量:"PrjDataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjDataBaseName = "PrjDataBaseName";    //项目数据库名

 /// <summary>
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IpAddress = "IpAddress";    //IP地址

 /// <summary>
 /// 常量:"DataBaseUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DataBaseUserId = "DataBaseUserId";    //数据库用户Id

 /// <summary>
 /// 常量:"DataBasePwd"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DataBasePwd = "DataBasePwd";    //数据库用户口令

 /// <summary>
 /// 常量:"DataBaseName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DataBaseName = "DataBaseName";    //数据库名称

 /// <summary>
 /// 常量:"DataBaseTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DataBaseTypeName = "DataBaseTypeName";    //数据库类型名

 /// <summary>
 /// 常量:"DataBaseTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DataBaseTypeId = "DataBaseTypeId";    //数据库类型ID

 /// <summary>
 /// 常量:"DatabaseOwner"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_DatabaseOwner = "DatabaseOwner";    //数据库拥有者

 /// <summary>
 /// 常量:"TableSpace"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TableSpace = "TableSpace";    //表空间

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"SID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SID = "SID";    //SID

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxPrjDataBaseEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vQxPrjDataBase";
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
 _CurrTabName = "vQxPrjDataBase";
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
if (strAttributeName  ==  con_QxPrjDataBaseId)
{
return mstrQxPrjDataBaseId;
}
else if (strAttributeName  ==  con_PrjDataBaseName)
{
return mstrPrjDataBaseName;
}
else if (strAttributeName  ==  con_IpAddress)
{
return mstrIpAddress;
}
else if (strAttributeName  ==  con_DataBaseUserId)
{
return mstrDataBaseUserId;
}
else if (strAttributeName  ==  con_DataBasePwd)
{
return mstrDataBasePwd;
}
else if (strAttributeName  ==  con_DataBaseName)
{
return mstrDataBaseName;
}
else if (strAttributeName  ==  con_DataBaseTypeName)
{
return mstrDataBaseTypeName;
}
else if (strAttributeName  ==  con_DataBaseTypeId)
{
return mstrDataBaseTypeId;
}
else if (strAttributeName  ==  con_DatabaseOwner)
{
return mstrDatabaseOwner;
}
else if (strAttributeName  ==  con_TableSpace)
{
return mstrTableSpace;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_SID)
{
return mstrSID;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_QxPrjDataBaseId)
{
mstrQxPrjDataBaseId = value.ToString();
 AddUpdatedFld(con_QxPrjDataBaseId);
}
else if (strAttributeName  ==  con_PrjDataBaseName)
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(con_PrjDataBaseName);
}
else if (strAttributeName  ==  con_IpAddress)
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(con_IpAddress);
}
else if (strAttributeName  ==  con_DataBaseUserId)
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(con_DataBaseUserId);
}
else if (strAttributeName  ==  con_DataBasePwd)
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(con_DataBasePwd);
}
else if (strAttributeName  ==  con_DataBaseName)
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(con_DataBaseName);
}
else if (strAttributeName  ==  con_DataBaseTypeName)
{
mstrDataBaseTypeName = value.ToString();
 AddUpdatedFld(con_DataBaseTypeName);
}
else if (strAttributeName  ==  con_DataBaseTypeId)
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(con_DataBaseTypeId);
}
else if (strAttributeName  ==  con_DatabaseOwner)
{
mstrDatabaseOwner = value.ToString();
 AddUpdatedFld(con_DatabaseOwner);
}
else if (strAttributeName  ==  con_TableSpace)
{
mstrTableSpace = value.ToString();
 AddUpdatedFld(con_TableSpace);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_SID)
{
mstrSID = value.ToString();
 AddUpdatedFld(con_SID);
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (con_QxPrjDataBaseId  ==  AttributeName[intIndex])
{
return mstrQxPrjDataBaseId;
}
else if (con_PrjDataBaseName  ==  AttributeName[intIndex])
{
return mstrPrjDataBaseName;
}
else if (con_IpAddress  ==  AttributeName[intIndex])
{
return mstrIpAddress;
}
else if (con_DataBaseUserId  ==  AttributeName[intIndex])
{
return mstrDataBaseUserId;
}
else if (con_DataBasePwd  ==  AttributeName[intIndex])
{
return mstrDataBasePwd;
}
else if (con_DataBaseName  ==  AttributeName[intIndex])
{
return mstrDataBaseName;
}
else if (con_DataBaseTypeName  ==  AttributeName[intIndex])
{
return mstrDataBaseTypeName;
}
else if (con_DataBaseTypeId  ==  AttributeName[intIndex])
{
return mstrDataBaseTypeId;
}
else if (con_DatabaseOwner  ==  AttributeName[intIndex])
{
return mstrDatabaseOwner;
}
else if (con_TableSpace  ==  AttributeName[intIndex])
{
return mstrTableSpace;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_SID  ==  AttributeName[intIndex])
{
return mstrSID;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_QxPrjDataBaseId  ==  AttributeName[intIndex])
{
mstrQxPrjDataBaseId = value.ToString();
 AddUpdatedFld(con_QxPrjDataBaseId);
}
else if (con_PrjDataBaseName  ==  AttributeName[intIndex])
{
mstrPrjDataBaseName = value.ToString();
 AddUpdatedFld(con_PrjDataBaseName);
}
else if (con_IpAddress  ==  AttributeName[intIndex])
{
mstrIpAddress = value.ToString();
 AddUpdatedFld(con_IpAddress);
}
else if (con_DataBaseUserId  ==  AttributeName[intIndex])
{
mstrDataBaseUserId = value.ToString();
 AddUpdatedFld(con_DataBaseUserId);
}
else if (con_DataBasePwd  ==  AttributeName[intIndex])
{
mstrDataBasePwd = value.ToString();
 AddUpdatedFld(con_DataBasePwd);
}
else if (con_DataBaseName  ==  AttributeName[intIndex])
{
mstrDataBaseName = value.ToString();
 AddUpdatedFld(con_DataBaseName);
}
else if (con_DataBaseTypeName  ==  AttributeName[intIndex])
{
mstrDataBaseTypeName = value.ToString();
 AddUpdatedFld(con_DataBaseTypeName);
}
else if (con_DataBaseTypeId  ==  AttributeName[intIndex])
{
mstrDataBaseTypeId = value.ToString();
 AddUpdatedFld(con_DataBaseTypeId);
}
else if (con_DatabaseOwner  ==  AttributeName[intIndex])
{
mstrDatabaseOwner = value.ToString();
 AddUpdatedFld(con_DatabaseOwner);
}
else if (con_TableSpace  ==  AttributeName[intIndex])
{
mstrTableSpace = value.ToString();
 AddUpdatedFld(con_TableSpace);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_SID  ==  AttributeName[intIndex])
{
mstrSID = value.ToString();
 AddUpdatedFld(con_SID);
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
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
 AddUpdatedFld(con_QxPrjDataBaseId);
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
 AddUpdatedFld(con_PrjDataBaseName);
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
 AddUpdatedFld(con_IpAddress);
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
 AddUpdatedFld(con_DataBaseUserId);
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
 AddUpdatedFld(con_DataBasePwd);
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
 AddUpdatedFld(con_DataBaseName);
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
 AddUpdatedFld(con_DataBaseTypeName);
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
 AddUpdatedFld(con_DataBaseTypeId);
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
 AddUpdatedFld(con_DatabaseOwner);
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
 AddUpdatedFld(con_TableSpace);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
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
 AddUpdatedFld(con_UpdDate);
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
 AddUpdatedFld(con_SID);
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
/// 获取关键字Id(KeyId)
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
}