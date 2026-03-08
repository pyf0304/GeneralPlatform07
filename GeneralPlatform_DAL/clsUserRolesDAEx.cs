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
    public class clsQxUserRolesDAEx : clsQxUserRolesDA
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static System.Data.DataTable GetRoleIdEx(string strPrjId)
        {
            //获取某学院所有专业信息
            string strSQL = string .Format( "select RoleId, RoleName from {1} where {2}='{0}' ", 
                strPrjId, clsQxUserRolesEN._CurrTabName_S, clsQxUserRolesEN.con_QxPrjId);
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
    }
}
