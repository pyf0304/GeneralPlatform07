using System;
using System.Collections.Generic;
using System.Text;
using GeneralPlatform.DAL;
using com.taishsoft.commdb;
using GeneralPlatform.Entity;

namespace GeneralPlatform.DAL
{
    /// <summary>
    /// 
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
            string strSQL = string .Format("select MenuId, MenuName from QxPrjMenus where {2}='{0}' order by {1}", 
                strPrjId,
                clsQxPrjMenusEN.con_MenuName,
                clsQxPrjMenusEN.con_QxPrjId);
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
                clsQxPrjMenusEN.con_MenuName,
                clsQxPrjMenusEN.con_IsLeafNode,
                clsQxPrjMenusEN.con_QxPrjId);
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
    }
}
