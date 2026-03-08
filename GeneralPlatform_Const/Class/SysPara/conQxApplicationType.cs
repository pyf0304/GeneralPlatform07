
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:conQxApplicationType
 表名:QxApplicationType(00140088)
 生成代码版本:2021.07.30.1
 生成日期:2021/07/30 00:10:47
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:统一平台
 工程ID:0014
 相关数据库:103.116.76.183,9433MSEduSys
 PrjDataBaseId:0199
 模块中文名:系统参数
 模块英文名:SysPara
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
 /// 应用程序类型(QxApplicationType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode)
 /// </summary>
public static class conQxApplicationType
{
public const string _CurrTabName_S = "QxApplicationType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ApplicationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"ApplicationTypeId", "ApplicationTypeName", "ApplicationTypeENName", "ProgLangTypeId", "ProgLangTypeId2", "ProgLangTypeId3", "ProgLangTypeId4", "ProgLangTypeId5", "IsVisible", "OrderNum", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"ApplicationTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeENName = "ApplicationTypeENName";    //应用类型英文名

 /// <summary>
 /// 常量:"ProgLangTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId = "ProgLangTypeId";    //编程语言类型Id

 /// <summary>
 /// 常量:"ProgLangTypeId2"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId2 = "ProgLangTypeId2";    //编程语言类型Id2

 /// <summary>
 /// 常量:"ProgLangTypeId3"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId3 = "ProgLangTypeId3";    //编程语言类型Id3

 /// <summary>
 /// 常量:"ProgLangTypeId4"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId4 = "ProgLangTypeId4";    //编程语言类型Id4

 /// <summary>
 /// 常量:"ProgLangTypeId5"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ProgLangTypeId5 = "ProgLangTypeId5";    //编程语言类型Id5

 /// <summary>
 /// 常量:"IsVisible"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsVisible = "IsVisible";    //是否显示

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}
}