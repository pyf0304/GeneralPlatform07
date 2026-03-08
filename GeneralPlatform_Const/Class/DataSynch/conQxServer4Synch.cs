
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:conQxServer4Synch
 表名:QxServer4Synch(00140091)
 生成代码版本:2021.07.30.1
 生成日期:2021/07/30 00:12:25
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:统一平台
 工程ID:0014
 相关数据库:103.116.76.183,9433MSEduSys
 PrjDataBaseId:0199
 模块中文名:数据同步
 模块英文名:DataSynch
 框架-层名:表字段常量CSharp(TableFldConst)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 

namespace GeneralPlatform.Const
{
 /// <summary>
 /// 同步服务器(QxServer4Synch)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode)
 /// </summary>
public static class conQxServer4Synch
{
public const string _CurrTabName_S = "QxServer4Synch"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ServerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ServerId", "ServerName", "IpAddress", "WebApiAddress", "IsSelf", "InUse", "UpdDate", "UpdUser", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ServerId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ServerId = "ServerId";    //服务器Id

 /// <summary>
 /// 常量:"ServerName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ServerName = "ServerName";    //服务器名

 /// <summary>
 /// 常量:"IpAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IpAddress = "IpAddress";    //IP地址

 /// <summary>
 /// 常量:"WebApiAddress"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string WebApiAddress = "WebApiAddress";    //WApi地址

 /// <summary>
 /// 常量:"IsSelf"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsSelf = "IsSelf";    //是否当前服务器

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

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

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}
}