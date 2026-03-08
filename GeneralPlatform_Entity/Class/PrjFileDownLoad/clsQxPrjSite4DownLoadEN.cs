
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjSite4DownLoadEN
 表名:QxPrjSite4DownLoad(00140055)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:44:25
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:工程文件下载(PrjFileDownLoad)
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
 /// 表QxPrjSite4DownLoad的关键字(PrjSiteId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_PrjSiteId_QxPrjSite4DownLoad
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strPrjSiteId">表关键字</param>
public K_PrjSiteId_QxPrjSite4DownLoad(string strPrjSiteId)
{
if (IsValid(strPrjSiteId)) Value = strPrjSiteId;
else
{
Value = null;
}
}
private static bool IsValid(string strPrjSiteId)
{
if (string.IsNullOrEmpty(strPrjSiteId) == true) return false;
if (strPrjSiteId.Length != 6) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_PrjSiteId_QxPrjSite4DownLoad]类型的对象</returns>
public static implicit operator K_PrjSiteId_QxPrjSite4DownLoad(string value)
{
return new K_PrjSiteId_QxPrjSite4DownLoad(value);
}
}
 /// <summary>
 /// 文件下载站点(QxPrjSite4DownLoad)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxPrjSite4DownLoadEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxPrjSite4DownLoad"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "PrjSiteId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"PrjSiteId", "PrjSiteName", "QxPrjId", "FtpServer", "FtpUserId", "FtpUserPassword", "UpdDate", "UpdUserId", "Memo"};

protected string mstrPrjSiteId;    //工程站点Id
protected string mstrPrjSiteName;    //工程站点名
protected string mstrQxPrjId;    //项目Id
protected string mstrFtpServer;    //Ftp服务器
protected string mstrFtpUserId;    //Ftp用户Id
protected string mstrFtpUserPassword;    //Ftp用户口令
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxPrjSite4DownLoadEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjSiteId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strPrjSiteId">关键字:工程站点Id</param>
public clsQxPrjSite4DownLoadEN(string strPrjSiteId)
 {
strPrjSiteId = strPrjSiteId.Replace("'", "''");
if (strPrjSiteId.Length > 6)
{
throw new Exception("在表:QxPrjSite4DownLoad中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strPrjSiteId)  ==  true)
{
throw new Exception("在表:QxPrjSite4DownLoad中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjSiteId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrPrjSiteId = strPrjSiteId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("PrjSiteId");
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
if (strAttributeName  ==  conQxPrjSite4DownLoad.PrjSiteId)
{
return mstrPrjSiteId;
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.PrjSiteName)
{
return mstrPrjSiteName;
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.FtpServer)
{
return mstrFtpServer;
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.FtpUserId)
{
return mstrFtpUserId;
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.FtpUserPassword)
{
return mstrFtpUserPassword;
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxPrjSite4DownLoad.PrjSiteId)
{
mstrPrjSiteId = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.PrjSiteId);
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.PrjSiteName)
{
mstrPrjSiteName = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.PrjSiteName);
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.QxPrjId);
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.FtpServer)
{
mstrFtpServer = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.FtpServer);
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.FtpUserId)
{
mstrFtpUserId = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.FtpUserId);
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.FtpUserPassword)
{
mstrFtpUserPassword = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.FtpUserPassword);
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.UpdDate);
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.UpdUserId);
}
else if (strAttributeName  ==  conQxPrjSite4DownLoad.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxPrjSite4DownLoad.PrjSiteId  ==  AttributeName[intIndex])
{
return mstrPrjSiteId;
}
else if (conQxPrjSite4DownLoad.PrjSiteName  ==  AttributeName[intIndex])
{
return mstrPrjSiteName;
}
else if (conQxPrjSite4DownLoad.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxPrjSite4DownLoad.FtpServer  ==  AttributeName[intIndex])
{
return mstrFtpServer;
}
else if (conQxPrjSite4DownLoad.FtpUserId  ==  AttributeName[intIndex])
{
return mstrFtpUserId;
}
else if (conQxPrjSite4DownLoad.FtpUserPassword  ==  AttributeName[intIndex])
{
return mstrFtpUserPassword;
}
else if (conQxPrjSite4DownLoad.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxPrjSite4DownLoad.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conQxPrjSite4DownLoad.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxPrjSite4DownLoad.PrjSiteId  ==  AttributeName[intIndex])
{
mstrPrjSiteId = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.PrjSiteId);
}
else if (conQxPrjSite4DownLoad.PrjSiteName  ==  AttributeName[intIndex])
{
mstrPrjSiteName = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.PrjSiteName);
}
else if (conQxPrjSite4DownLoad.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.QxPrjId);
}
else if (conQxPrjSite4DownLoad.FtpServer  ==  AttributeName[intIndex])
{
mstrFtpServer = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.FtpServer);
}
else if (conQxPrjSite4DownLoad.FtpUserId  ==  AttributeName[intIndex])
{
mstrFtpUserId = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.FtpUserId);
}
else if (conQxPrjSite4DownLoad.FtpUserPassword  ==  AttributeName[intIndex])
{
mstrFtpUserPassword = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.FtpUserPassword);
}
else if (conQxPrjSite4DownLoad.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.UpdDate);
}
else if (conQxPrjSite4DownLoad.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.UpdUserId);
}
else if (conQxPrjSite4DownLoad.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjSite4DownLoad.Memo);
}
}
}

/// <summary>
/// 工程站点Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjSiteId
{
get
{
return mstrPrjSiteId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjSiteId = value;
}
else
{
 mstrPrjSiteId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjSite4DownLoad.PrjSiteId);
}
}
/// <summary>
/// 工程站点名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjSiteName
{
get
{
return mstrPrjSiteName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjSiteName = value;
}
else
{
 mstrPrjSiteName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjSite4DownLoad.PrjSiteName);
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
 AddUpdatedFld(conQxPrjSite4DownLoad.QxPrjId);
}
}
/// <summary>
/// Ftp服务器(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FtpServer
{
get
{
return mstrFtpServer;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFtpServer = value;
}
else
{
 mstrFtpServer = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjSite4DownLoad.FtpServer);
}
}
/// <summary>
/// Ftp用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FtpUserId
{
get
{
return mstrFtpUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFtpUserId = value;
}
else
{
 mstrFtpUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjSite4DownLoad.FtpUserId);
}
}
/// <summary>
/// Ftp用户口令(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FtpUserPassword
{
get
{
return mstrFtpUserPassword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFtpUserPassword = value;
}
else
{
 mstrFtpUserPassword = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjSite4DownLoad.FtpUserPassword);
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
 AddUpdatedFld(conQxPrjSite4DownLoad.UpdDate);
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
 AddUpdatedFld(conQxPrjSite4DownLoad.UpdUserId);
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
 AddUpdatedFld(conQxPrjSite4DownLoad.Memo);
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
  return mstrPrjSiteId;
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
  return mstrPrjSiteName;
 }
 }
}
 /// <summary>
 /// 文件下载站点(QxPrjSite4DownLoad)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxPrjSite4DownLoad
{
public const string _CurrTabName = "QxPrjSite4DownLoad"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjSiteId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"PrjSiteId", "PrjSiteName", "QxPrjId", "FtpServer", "FtpUserId", "FtpUserPassword", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"PrjSiteId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjSiteId = "PrjSiteId";    //工程站点Id

 /// <summary>
 /// 常量:"PrjSiteName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjSiteName = "PrjSiteName";    //工程站点名

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"FtpServer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FtpServer = "FtpServer";    //Ftp服务器

 /// <summary>
 /// 常量:"FtpUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FtpUserId = "FtpUserId";    //Ftp用户Id

 /// <summary>
 /// 常量:"FtpUserPassword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string FtpUserPassword = "FtpUserPassword";    //Ftp用户口令

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