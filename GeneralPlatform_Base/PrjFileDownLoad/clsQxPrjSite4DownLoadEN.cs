
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjSite4DownLoadEN
 表名:QxPrjSite4DownLoad(00140055)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 10:00:40
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:工程文件下载
 模块英文名:PrjFileDownLoad
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
 /// 表QxPrjSite4DownLoad的关键字(PrjSiteId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_PrjSiteId_QxPrjSite4DownLoad
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
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
public const string _CurrTabName_S = "QxPrjSite4DownLoad"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "PrjSiteId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"PrjSiteId", "PrjSiteName", "QxPrjId", "FtpServer", "FtpUserId", "FtpUserPassword", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量

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
 /// 常量:"PrjSiteId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjSiteId = "PrjSiteId";    //工程站点Id

 /// <summary>
 /// 常量:"PrjSiteName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjSiteName = "PrjSiteName";    //工程站点名

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"FtpServer"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FtpServer = "FtpServer";    //Ftp服务器

 /// <summary>
 /// 常量:"FtpUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FtpUserId = "FtpUserId";    //Ftp用户Id

 /// <summary>
 /// 常量:"FtpUserPassword"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FtpUserPassword = "FtpUserPassword";    //Ftp用户口令

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxPrjSite4DownLoadEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxPrjSite4DownLoad";
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
 _CurrTabName = "QxPrjSite4DownLoad";
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
if (strAttributeName  ==  con_PrjSiteId)
{
return mstrPrjSiteId;
}
else if (strAttributeName  ==  con_PrjSiteName)
{
return mstrPrjSiteName;
}
else if (strAttributeName  ==  con_QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  con_FtpServer)
{
return mstrFtpServer;
}
else if (strAttributeName  ==  con_FtpUserId)
{
return mstrFtpUserId;
}
else if (strAttributeName  ==  con_FtpUserPassword)
{
return mstrFtpUserPassword;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_PrjSiteId)
{
mstrPrjSiteId = value.ToString();
 AddUpdatedFld(con_PrjSiteId);
}
else if (strAttributeName  ==  con_PrjSiteName)
{
mstrPrjSiteName = value.ToString();
 AddUpdatedFld(con_PrjSiteName);
}
else if (strAttributeName  ==  con_QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(con_QxPrjId);
}
else if (strAttributeName  ==  con_FtpServer)
{
mstrFtpServer = value.ToString();
 AddUpdatedFld(con_FtpServer);
}
else if (strAttributeName  ==  con_FtpUserId)
{
mstrFtpUserId = value.ToString();
 AddUpdatedFld(con_FtpUserId);
}
else if (strAttributeName  ==  con_FtpUserPassword)
{
mstrFtpUserPassword = value.ToString();
 AddUpdatedFld(con_FtpUserPassword);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
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
if (con_PrjSiteId  ==  AttributeName[intIndex])
{
return mstrPrjSiteId;
}
else if (con_PrjSiteName  ==  AttributeName[intIndex])
{
return mstrPrjSiteName;
}
else if (con_QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (con_FtpServer  ==  AttributeName[intIndex])
{
return mstrFtpServer;
}
else if (con_FtpUserId  ==  AttributeName[intIndex])
{
return mstrFtpUserId;
}
else if (con_FtpUserPassword  ==  AttributeName[intIndex])
{
return mstrFtpUserPassword;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_PrjSiteId  ==  AttributeName[intIndex])
{
mstrPrjSiteId = value.ToString();
 AddUpdatedFld(con_PrjSiteId);
}
else if (con_PrjSiteName  ==  AttributeName[intIndex])
{
mstrPrjSiteName = value.ToString();
 AddUpdatedFld(con_PrjSiteName);
}
else if (con_QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(con_QxPrjId);
}
else if (con_FtpServer  ==  AttributeName[intIndex])
{
mstrFtpServer = value.ToString();
 AddUpdatedFld(con_FtpServer);
}
else if (con_FtpUserId  ==  AttributeName[intIndex])
{
mstrFtpUserId = value.ToString();
 AddUpdatedFld(con_FtpUserId);
}
else if (con_FtpUserPassword  ==  AttributeName[intIndex])
{
mstrFtpUserPassword = value.ToString();
 AddUpdatedFld(con_FtpUserPassword);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
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
 AddUpdatedFld(con_PrjSiteId);
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
 AddUpdatedFld(con_PrjSiteName);
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
 AddUpdatedFld(con_QxPrjId);
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
 AddUpdatedFld(con_FtpServer);
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
 AddUpdatedFld(con_FtpUserId);
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
 AddUpdatedFld(con_FtpUserPassword);
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
/// 修改用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
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
 AddUpdatedFld(con_UpdUserId);
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
}