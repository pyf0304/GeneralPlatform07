
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxProjectsDAEx
表名:QxProjects
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:05:41
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:工程管理
模块英文名:PrjManage
框架-层名:数据处理扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.commexception;
using com.taishsoft.commdb;

using GeneralPlatform.Entity;

namespace GeneralPlatform.DAL
{
    /// <summary>
    /// 工程表(QxProjects)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenDALExCode)
    /// </summary>
    public class clsQxProjectsDAEx : clsQxProjectsDA
    {

        /// <summary>
        /// 获取当前关键字的记录对象,用对象的形式表示.
        /// </summary>
        /// <param name="objProjects">需要添加到数据库中的对象</param>
        /// <returns>是否成功</returns>
        public bool GetProjectsEx(ref clsQxProjectsENEx objProjects)
        {
            clsQxProjectsEN objProjectsEN =                 GetObjByQxPrjId(objProjects.QxPrjId);
            objProjects = (clsQxProjectsENEx)objProjectsEN;
            return true;
        }
    }
}