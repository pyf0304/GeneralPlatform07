
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUserMenusBLEx
表名:QxUserMenus
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:06:15
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:菜单管理
模块英文名:MenuManage
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
using SpecData;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 用户菜单(QxUserMenus)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxUserMenusBLEx : clsQxUserMenusBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxUserMenusDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxUserMenusDAEx QxUserMenusDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxUserMenusDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        public static DataTable GetQxUsers4UserMenusQuery(string strCondition)
        {

            StringBuilder strbSQL = new StringBuilder();
            strbSQL.Append("select Users.UserId, Users.XM, Users.DepartmentId, Users.RoleId, Departments.DepartmentName,UserRole.RoleName, ");
            strbSQL.Append("CASE WHEN  UserMenus.IsUseRoleMenu='1' THEN '是' ELSE  '否' END AS 'IsUseRoleMenu', ");
            strbSQL.Append(" UserMenus.QxPrjId,QxProjects.PrjName,UserMenus.mId ");



            strbSQL.Append("from Users left join Departments on (Users.DepartmentId=Departments.DepartmentId) left join  UserRole on (Users.RoleId=UserRole.RoleId) ");
            strbSQL.Append("left join  UserMenus on (Users.UserId=UserMenus.UserId) left join QxProjects on (UserMenus.QxPrjId = QxProjects.QxPrjId ) ");
            strbSQL.AppendFormat("where  " + "{0} ", strCondition);
            //			strbSQL.Append("order by College.XYMC, Major.ZYMC");


            clsSpecSQL objSQL = new clsSpecSQL();
            string strSQL = strbSQL.ToString();
            return objSQL.GetDataTable(strSQL);
        }

    }
}