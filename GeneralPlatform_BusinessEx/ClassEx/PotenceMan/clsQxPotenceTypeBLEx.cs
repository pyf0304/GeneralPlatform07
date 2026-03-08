
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxPotenceTypeBLEx
表名:QxPotenceType
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:05:14
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:权限管理
模块英文名:PotenceMan
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
using System.Web.UI.WebControls;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 权限类型(QxPotenceType)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxPotenceTypeBLEx : clsQxPotenceTypeBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxPotenceTypeDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxPotenceTypeDAEx QxPotenceTypeDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxPotenceTypeDAEx();
                }
                return uniqueInstanceEx;
            }
        }


        public static void BindDdl_PotenceTypeIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetPotenceTypeIdEx(strPrjId);
            objDDL.DataValueField = "PotenceTypeId";
            objDDL.DataTextField = "PotenceTypeName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static System.Data.DataTable GetPotenceTypeIdEx(string strPrjId)
        {
            //获取某学院所有专业信息
            string strSQL = string.Format("select PotenceTypeId, PotenceTypeName + '('+PotenceTypeId+ ')' as PotenceTypeName  from {0} where QxPrjId = '{1}' and {2}='1' order by {3}",
               clsQxPotenceTypeEN._CurrTabName,
               strPrjId, conQxPotenceType.IsVisible, conQxPotenceType.PotenceTypeName);

            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 功能：设置多条部门为可用
        /// </summary>
        /// <param name="lstKey">给定的关键字值列表</param>
        /// <returns>设置是否成功?</returns>
        public static bool SetIsVisible(List<string> lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                else strKeyList += "," + "'" + lstKey[i].ToString() + "'";
            }
            strSQL = "";
            //删除QxPotenceType本表中与当前对象有关的记录
            strSQL = strSQL + string.Format("Update QxPotenceType Set {0}='1' where PotenceTypeId in (" + strKeyList + ")",
                conQxPotenceType.IsVisible);
            return objSQL.ExecSql(strSQL);
        }
        /// <summary>
        /// 功能：设置多条部门为可用
        /// </summary>
        /// <param name="lstKey">给定的关键字值列表</param>
        /// <returns>设置是否成功?</returns>
        public static bool SetNotIsVisible(List<string> lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsQxPotenceTypeDA.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                else strKeyList += "," + "'" + lstKey[i].ToString() + "'";
            }
            strSQL = "";
            //删除QxPotenceType本表中与当前对象有关的记录
            strSQL = strSQL + string.Format("Update QxPotenceType Set {0}='0' where PotenceTypeId in (" + strKeyList + ")",
                conQxPotenceType.IsVisible);
            return objSQL.ExecSql(strSQL);
        }

    }
}