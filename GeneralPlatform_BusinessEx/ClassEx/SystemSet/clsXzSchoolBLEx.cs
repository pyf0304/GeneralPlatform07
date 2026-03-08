
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsXzSchoolBLEx
表名:XzSchool
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:08:11
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:系统设置
模块英文名:SystemSet
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
    /// 学校(XzSchool)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsXzSchoolBLEx : clsXzSchoolBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsXzSchoolDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsXzSchoolDAEx XzSchoolDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsXzSchoolDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 根据SchoolId获取关键字(IdSchool), 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strSchoolId">所给的关键字</param>
        /// <returns>获取关键字strIdSchool</returns>
        public static string GetId_SchoolBySchoolId(string strSchoolId)
        {
            var arrXzSchoolObjLst_Cache = clsXzSchoolBL.GetObjLstCache();

            foreach (clsXzSchoolEN objXzSchoolEN in arrXzSchoolObjLst_Cache)
            {
                if (objXzSchoolEN.SchoolId == strSchoolId)
                {
                    return objXzSchoolEN.IdSchool;
                }
            }
            return "";
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strSchoolId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsXzSchoolEN GetXzSchoolObjBySchoolId(string strSchoolId)
        {
            var arrXzSchoolObjLst_Cache = clsXzSchoolBL.GetObjLstCache();

            foreach (clsXzSchoolEN objXzSchoolEN in arrXzSchoolObjLst_Cache)
            {
                if (objXzSchoolEN.SchoolId == strSchoolId)
                {
                    return objXzSchoolEN;
                }
            }
            return null;
        }
        public static string GetCurrentUse_IdSchoolEx()
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("{0}='1'", conXzSchool.IsCurrentUse);
            clsXzSchoolEN objXzSchool = clsXzSchoolBL.GetFirstObj_S(strCondition);
            if (objXzSchool != null) return objXzSchool.IdSchool;
            string strMsg = string.Format("当前数据库中没有默认使用的学校编号。({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }


        #region 绑定下拉框

        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        public static void BindCbo_IdSchoolEx(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("{0}='1'", conXzSchool.IsCurrentUse);
            System.Data.DataTable objDT = clsXzSchoolBL.GetDataTable_XzSchool(strCondition);
            clsXzSchoolEN objXzSchoolEN;
            //初始化一个对象列表
            ArrayList XzSchoolList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objXzSchoolEN = new clsXzSchoolEN();
            objXzSchoolEN.IdSchool = "0";
            objXzSchoolEN.SchoolName = "请选择...";
            XzSchoolList.Add(objXzSchoolEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objXzSchoolEN = new clsXzSchoolEN();
                objXzSchoolEN.IdSchool = objRow[conXzSchool.IdSchool].ToString();
                objXzSchoolEN.SchoolName = objRow[conXzSchool.SchoolName].ToString();
                XzSchoolList.Add(objXzSchoolEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conXzSchool.IdSchool;
            objComboBox.DisplayMember = conXzSchool.SchoolName;
            objComboBox.DataSource = XzSchoolList;
            objComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_IdSchoolEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("{0}='1'", conXzSchool.IsCurrentUse);
            System.Data.DataTable objDT = clsXzSchoolBL.GetDataTable_XzSchool(strCondition);
            objDDL.DataValueField = conXzSchool.IdSchool;
            objDDL.DataTextField = conXzSchool.SchoolName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///// <summary>
        ///// 绑定基于Web的下拉框-使用Cache
        ///// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        ///// </summary>
        ///// <param name = "objDDL">需要绑定当前表的下拉框</param>
        //public static void BindDdl_IdSchoolCache(System.Web.UI.WebControls.DropDownList objDDL)
        //{
        //    //为数据源于表的下拉框设置内容
        //    System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
        //    List<clsXzSchoolEN> arrXzSchoolObjLst = GetAllXzSchoolObjLstCache();
        //    objDDL.DataValueField = conXzSchool.IdSchool;
        //    objDDL.DataTextField = conXzSchool.SchoolName;
        //    objDDL.DataSource = arrXzSchoolObjLst;
        //    objDDL.DataBind();
        //    objDDL.Items.Insert(0, li);
        //    objDDL.SelectedIndex = 0;
        //}


        #endregion 绑定下拉框

    }
}