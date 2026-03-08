
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxPrjMenusDAEx
表名:QxPrjMenus
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:05:23
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:菜单管理
模块英文名:MenuManage
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
    /// 工程菜单(QxPrjMenus)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenDALExCode)
    /// </summary>
    public class clsQxPrjMenusDAEx : clsQxPrjMenusDA
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static System.Data.DataTable GetMenuIdEx(string strPrjId)
        {
            //获取某学院所有专业信息
            string strSQL = string.Format("select MenuId, MenuName from QxPrjMenus where {2}='{0}' order by {1}",
                strPrjId,
                conQxPrjMenus.MenuName,
                conQxPrjMenus.QxPrjId);
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static System.Data.DataTable GetMenuId4IsLeafEx(string strPrjId)
        {
            //获取某学院所有专业信息
            string strSQL = string.Format("select MenuId, MenuName from QxPrjMenus where {3}='{0}' And {2}='1' order by {1}",
                strPrjId,
                conQxPrjMenus.MenuName,
                conQxPrjMenus.IsLeafNode,
                conQxPrjMenus.QxPrjId);
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
    }
}