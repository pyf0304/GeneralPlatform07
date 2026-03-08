
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxPrjUserRelationBLEx
表名:QxPrjUserRelation
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:05:38
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
using SpecData;
using com.taishsoft.datetime;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 工程用户关系(QxPrjUserRelation)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxPrjUserRelationBLEx : clsQxPrjUserRelationBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxPrjUserRelationDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxPrjUserRelationDAEx QxPrjUserRelationDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxPrjUserRelationDAEx();
                }
                return uniqueInstanceEx;
            }
        }


        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_QxPrjUserRelation(System.Windows.Forms.ListView lvQxPrjUserRelation, string strWhereCond)
        {
            ///	操作步骤：(共4步)
            ///	1、组合界面条件串；
            ///	2、根据条件串获取该表满足条件的DataTable；
            ///	3、设置ListView的列头信息
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            ///		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviQxPrjUserRelation;
            List<clsQxPrjUserRelationEN> arrQxPrjUserRelationObjList;
            ///	2、根据条件串获取该表满足条件的DataTable；
            arrQxPrjUserRelationObjList = clsQxPrjUserRelationBL.GetObjLst(strWhereCond);
            ///	3、设置ListView的列头信息
            lvQxPrjUserRelation.Items.Clear();//清除原来所有Item
            lvQxPrjUserRelation.Columns.Clear();//清除原来所有列头信息
            lvQxPrjUserRelation.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxPrjUserRelation.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxPrjUserRelation.Columns.Add("项目编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxPrjUserRelation.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxPrjUserRelation.View = System.Windows.Forms.View.Details;
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsQxPrjUserRelationEN objQxPrjUserRelation in arrQxPrjUserRelationObjList)
            {
                lviQxPrjUserRelation = new System.Windows.Forms.ListViewItem();
                lviQxPrjUserRelation.Tag = objQxPrjUserRelation.mId;
                lviQxPrjUserRelation.Text = objQxPrjUserRelation.mId.ToString();
                lviQxPrjUserRelation.SubItems.Add(objQxPrjUserRelation.Memo);
                lviQxPrjUserRelation.SubItems.Add(objQxPrjUserRelation.QxPrjId);
                lviQxPrjUserRelation.SubItems.Add(objQxPrjUserRelation.UserId);
                lvQxPrjUserRelation.Items.Add(lviQxPrjUserRelation);
            }
            ///	4、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。
            return arrQxPrjUserRelationObjList.Count;
        }
        public static bool AddRecord(string strPrjId, string strUserId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{1} = '{0}'", strPrjId, conQxPrjUserRelation.QxPrjId);
            sbCondition.AppendFormat(" and UserId = '{0}'", strUserId);
            if (clsQxPrjUserRelationBL.IsExistRecord(sbCondition.ToString()) == false)
            {
                clsQxPrjUserRelationEN objQxPrjUserRelation = new clsQxPrjUserRelationEN();
                objQxPrjUserRelation.UserId = strUserId;
                objQxPrjUserRelation.QxPrjId = strPrjId;
                objQxPrjUserRelation.Memo = clsDateTime.getTodayStr(0);
                clsQxPrjUserRelationBL.AddNewRecordBySql2(objQxPrjUserRelation);
            }
            return true;
        }
        public static int DelRecord(string strPrjId, string strUserId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{1} = '{0}'", strPrjId, conQxPrjUserRelation.QxPrjId);
            sbCondition.AppendFormat(" and UserId = '{0}'", strUserId);
            return clsQxPrjUserRelationBL.DelQxPrjUserRelationsByCond(sbCondition.ToString());
        }
        /// <summary>
        /// 功能：获取某一条件的相关表视图(View)
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
        public static System.Data.DataTable GetQxPrjUserRelationVEx(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQL objSQL = new clsSpecSQL();
            strSQL.Append("Select vQxPrjUserRelationByRole.* ");
            strSQL.Append(" from vQxPrjUserRelationByRole ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }


        public static List<clsQxPrjUserRelationEN> GetObjLstByUserId(string strUserId)
        {
            string strWhereCond = string.Format("{0}='{1}'", conQxPrjUserRelation.UserId, strUserId);

            List<clsQxPrjUserRelationEN> arrQxPrjUserRelationObjList;
            ///	2、根据条件串获取该表满足条件的DataTable；
            arrQxPrjUserRelationObjList = clsQxPrjUserRelationBL.GetObjLst(strWhereCond);
            ///	4、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。
            return arrQxPrjUserRelationObjList;
        }

    }
}