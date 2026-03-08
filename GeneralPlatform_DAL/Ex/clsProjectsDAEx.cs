using System;
using System.Collections.Generic;
using System.Text;
using com.taishsoft.commdb;
using GeneralPlatform.Entity;

namespace GeneralPlatform.DAL
{
    /// <summary>
    /// 
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
            clsQxProjectsEN objProjectsEN = objProjects;
            GetQxProjects(ref objProjectsEN);
            objProjects = (clsQxProjectsENEx)objProjectsEN;
            return true;
        }
    }
}
