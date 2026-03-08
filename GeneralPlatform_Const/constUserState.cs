
/*-- -- -- -- -- -- -- -- -- -- --
类名:constUserState
表名:UserState
生成代码版本:2018.04.07.1
生成日期:2018/04/09 23:04:22
生成者:潘以锋
生成服务器IP:
工程名称:简单工程样例
工程ID:0116
模块中文名:系统基本参数
模块英文名:BaseParameter
框架-层名:表字段常量
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;

namespace SimplePrj.Const
{
    /// <summary>
    /// UserState(UserState)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenTableFldConstCode)
    /// </summary>
    public static class constUserState
    {
        public const string CurrTabName_S = "UserState"; //当前表名,与该类相关的表名
        public const string CurrTabKeyFldName_S = "UserStateId"; //当前表中的关键字名称,与该类相关的表中关键字名
        public static string[] AttributeName = new string[] { "UserStateId", "UserStateName", "Memo" };
        //以下是属性变量


        /// <summary>
        /// 常量:"UserStateId"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
        /// </summary>
        public const string UserStateId = "UserStateId";    //用户状态号

        /// <summary>
        /// 常量:"UserStateName"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
        /// </summary>
        public const string UserStateName = "UserStateName";    //用户状态名

        /// <summary>
        /// 常量:"Memo"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
        /// </summary>
        public const string Memo = "Memo";    //备注
    }
}