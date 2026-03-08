
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:conQxCodeType
 表名:QxCodeType(00140057)
 生成代码版本:2021.07.30.1
 生成日期:2021/07/30 00:09:32
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:统一平台
 工程ID:0014
 相关数据库:103.116.76.183,9433MSEduSys
 PrjDataBaseId:0199
 模块中文名:工程文件下载
 模块英文名:PrjFileDownLoad
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
 /// 代码类型(QxCodeType)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode)
 /// </summary>
public static class conQxCodeType
{
public const string _CurrTabName_S = "QxCodeType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "QxCodeTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"QxCodeTypeId", "CodeTypeName", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"QxCodeTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxCodeTypeId = "QxCodeTypeId";    //代码类型Id

 /// <summary>
 /// 常量:"CodeTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CodeTypeName = "CodeTypeName";    //代码类型名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}
}