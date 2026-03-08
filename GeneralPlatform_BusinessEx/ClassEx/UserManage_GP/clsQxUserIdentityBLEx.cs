
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUserIdentityBLEx
表名:QxUserIdentity
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:06:06
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
    /// 用户权限身份表(QxUserIdentity)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxUserIdentityBLEx : clsQxUserIdentityBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxUserIdentityDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxUserIdentityDAEx QxUserIdentityDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxUserIdentityDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        public static List<clsQxUserIdentityEN> arrQxUserIdentityObjLst = null;




        public static System.Data.DataTable GetIdentityID()
        {
            //获取某学院所有专业信息
            string strSQL = "select IdentityId, IdentityDesc from QxUserIdentity ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindCbo_IdentityID(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetIdentityID();
            clsQxUserIdentityEN objQxUserIdentity;
            //初始化一个对象列表
            ArrayList QxUserIdentityList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”，为了方便用户，与WEB方式类似。
            objQxUserIdentity = new clsQxUserIdentityEN();
            objQxUserIdentity.IdentityId = "0";
            objQxUserIdentity.IdentityDesc = "请选择...";
            QxUserIdentityList.Add(objQxUserIdentity);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objQxUserIdentity = new clsQxUserIdentityEN();
                objQxUserIdentity.IdentityId = objRow["IdentityId"].ToString();
                objQxUserIdentity.IdentityDesc = objRow["IdentityDesc"].ToString();
                QxUserIdentityList.Add(objQxUserIdentity);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = QxUserIdentityList;
            objComboBox.ValueMember = "IdentityId";
            objComboBox.DisplayMember = "IdentityDesc";
            objComboBox.SelectedIndex = 0;
        }

        ///绑定下拉框的函数代码
        public static void BindDdl_IdentityID(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetIdentityID();
            objDDL.DataValueField = "IdentityId";
            objDDL.DataTextField = "IdentityDesc";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_QxUserIdentity(System.Windows.Forms.ListView lvQxUserIdentity, string strWhereCond)
        {
            ///	操作步骤：(共4步)
            ///	1、组合界面条件串；
            ///	2、根据条件串获取该表满足条件的DataTable；
            ///	3、设置ListView的列头信息
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            ///		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviQxUserIdentity;
            List<clsQxUserIdentityEN> arrQxUserIdentityObjList;
            ///	2、根据条件串获取该表满足条件的DataTable；
            arrQxUserIdentityObjList = clsQxUserIdentityBL.GetObjLst(strWhereCond);
            ///	3、设置ListView的列头信息
            lvQxUserIdentity.Items.Clear();//清除原来所有Item
            lvQxUserIdentity.Columns.Clear();//清除原来所有列头信息
            lvQxUserIdentity.Columns.Add("身份编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxUserIdentity.Columns.Add("身份描述", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxUserIdentity.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxUserIdentity.View = System.Windows.Forms.View.Details;
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsQxUserIdentityEN objQxUserIdentity in arrQxUserIdentityObjList)
            {
                lviQxUserIdentity = new System.Windows.Forms.ListViewItem();
                lviQxUserIdentity.Tag = objQxUserIdentity.IdentityId;
                lviQxUserIdentity.Text = objQxUserIdentity.IdentityId.ToString();
                lviQxUserIdentity.SubItems.Add(objQxUserIdentity.IdentityDesc);
                lviQxUserIdentity.SubItems.Add(objQxUserIdentity.Memo);
                lvQxUserIdentity.Items.Add(lviQxUserIdentity);
            }
            ///	4、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。
            return arrQxUserIdentityObjList.Count;
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strIdentityID">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsQxUserIdentityEN GetQxUserIdentityObjByIdentityID(string strIdentityID)
        {
            if (arrQxUserIdentityObjLst == null)
            {
                arrQxUserIdentityObjLst = clsQxUserIdentityBL.GetObjLst("1=1");
            }
            foreach (clsQxUserIdentityEN objQxUserIdentity in arrQxUserIdentityObjLst)
            {
                if (objQxUserIdentity.IdentityId == strIdentityID)
                {
                    return objQxUserIdentity;
                }
            }
            return null;
        }

        /// <summary>
        /// 根据名称获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strIdentityDesc">用户身份名称</param>
        /// <returns>根据名称获取的对象</returns>
        public static clsQxUserIdentityEN GetObjByIdentityDescCache(string strIdentityDesc)
        {
            var arrQxUserIdentityObjLst_Cache = GetObjLstCache();

            foreach (clsQxUserIdentityEN objQxUserIdentityEN in arrQxUserIdentityObjLst_Cache)
            {
                if (objQxUserIdentityEN.IdentityDesc == strIdentityDesc)
                {
                    return objQxUserIdentityEN;
                }
            }
            return null;
        }
    }
}