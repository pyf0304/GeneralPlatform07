
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxUserDownLoadDetailLogEN_Sim
 表名:vQxUserDownLoadDetailLog
 生成代码版本:2018.04.19.1
 生成日期:2018/04/20 12:40:15
 生成者:潘以锋
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:工程文件下载
 模块英文名:PrjFileDownLoad
 框架-层名:实体层-简化
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace GeneralPlatform.Entity
{
 /// <summary>
 /// v用户下载日志细节(vQxUserDownLoadDetailLog)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode_Sim)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxUserDownLoadDetailLogEN_Sim 
{
//以下是属性变量

private long mlngmId;    //流水号
private string mstrUserDownLoadLogId;    //用户下载日志Id
private string mstrPrjSiteId;    //工程站点Id
private string mstrPrjSiteName;    //工程站点名
private string mstrQxPrjId;    //项目Id
private string mstrPrjName;    //工程名
private string mstrUserId;    //用户ID
private string mstrFileName;    //文件名
private string mstrVersion;    //版本
private string mstrDownLownDate;    //下载日期
private bool mbolIsSuccess;    //是否成功
private string mstrLogInfo;    //日志信息
private string mstrFtpServer;    //Ftp服务器
private string mstrFtpUserId;    //Ftp用户Id
private string mstrFtpUserPassword;    //Ftp用户口令
private string mstrMemo;    //备注
private string mstrsf_UpdFldSetStr;    //系统字段_修改字段集合串

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
}
}
/// <summary>
/// 用户下载日志Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string UserDownLoadLogId
{
get
{
return mstrUserDownLoadLogId;
}
set
{
if (value  ==  "")
{
 mstrUserDownLoadLogId = value;
}
else
{
 mstrUserDownLoadLogId = value;
}
}
}
/// <summary>
/// 工程站点Id(说明:;字段类型:char;字段长度:6;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrPrjSiteId = value;
}
else
{
 mstrPrjSiteId = value;
}
}
}
/// <summary>
/// 工程站点名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrPrjSiteName = value;
}
else
{
 mstrPrjSiteName = value;
}
}
}
/// <summary>
/// 项目Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrQxPrjId = value;
}
else
{
 mstrQxPrjId = value;
}
}
}
/// <summary>
/// 工程名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
}
}
/// <summary>
/// 文件名(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string FileName
{
get
{
return mstrFileName;
}
set
{
if (value  ==  "")
{
 mstrFileName = value;
}
else
{
 mstrFileName = value;
}
}
}
/// <summary>
/// 版本(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string Version
{
get
{
return mstrVersion;
}
set
{
if (value  ==  "")
{
 mstrVersion = value;
}
else
{
 mstrVersion = value;
}
}
}
/// <summary>
/// 下载日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string DownLownDate
{
get
{
return mstrDownLownDate;
}
set
{
if (value  ==  "")
{
 mstrDownLownDate = value;
}
else
{
 mstrDownLownDate = value;
}
}
}
/// <summary>
/// 是否成功(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public bool IsSuccess
{
get
{
return mbolIsSuccess;
}
set
{
 mbolIsSuccess = value;
}
}
/// <summary>
/// 日志信息(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string LogInfo
{
get
{
return mstrLogInfo;
}
set
{
if (value  ==  "")
{
 mstrLogInfo = value;
}
else
{
 mstrLogInfo = value;
}
}
}
/// <summary>
/// Ftp服务器(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrFtpServer = value;
}
else
{
 mstrFtpServer = value;
}
}
}
/// <summary>
/// Ftp用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrFtpUserId = value;
}
else
{
 mstrFtpUserId = value;
}
}
}
/// <summary>
/// Ftp用户口令(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrFtpUserPassword = value;
}
else
{
 mstrFtpUserPassword = value;
}
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
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
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
}
}
/// <summary>
/// 系统字段_修改字段集合串(说明:;字段类型:str;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
  [DataMember]//非常重要
 public string sf_UpdFldSetStr
{
get
{
return mstrsf_UpdFldSetStr;
}
set
{
if (value  ==  "")
{
 mstrsf_UpdFldSetStr = value;
}
else
{
 mstrsf_UpdFldSetStr = value;
}
}
}
}
}