
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUserStateBLEx
表名:QxUserState
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:06:33
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:用户管理
模块英文名:UserManage
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;

using GeneralPlatform.Entity;
using System.Data;
using System.Data.SqlClient;
using GeneralPlatform.DAL;
using GeneralPlatform.BusinessLogic;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 用户状态(QxUserState)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxUserStateBLEx : clsQxUserStateBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxUserStateDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxUserStateDAEx QxUserStateDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxUserStateDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        /// <summary>
        /// 根据名称获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strUserStateName">用户状态名称</param>
        /// <returns>根据名称获取的对象</returns>
        public static clsQxUserStateEN GetObjByUserStateNameCache(string strUserStateName)
        {
            var arrQxUserStateObjLst_Cache = GetObjLstCache();

            foreach (clsQxUserStateEN objQxUserStateEN in arrQxUserStateObjLst_Cache)
            {
                if (objQxUserStateEN.UserStateName == strUserStateName)
                {
                    return objQxUserStateEN;
                }
            }
            return null;
        }

    }
}