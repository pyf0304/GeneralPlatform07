
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUserRoleRelationBLEx
表名:QxUserRoleRelation
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:06:19
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
using com.taishsoft.datetime;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 用户角色关系(QxUserRoleRelation)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxUserRoleRelationBLEx : clsQxUserRoleRelationBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxUserRoleRelationDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxUserRoleRelationDAEx QxUserRoleRelationDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxUserRoleRelationDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_QxUserRoleRelation(System.Windows.Forms.ListView lvQxUserRoleRelation, string strWhereCond)
        {
            ///	操作步骤：(共4步)
            ///	1、组合界面条件串；
            ///	2、根据条件串获取该表满足条件的DataTable；
            ///	3、设置ListView的列头信息
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            ///		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviUserRoleRelation;
            List<clsQxUserRoleRelationEN> arrUserRoleRelationObjList;
            ///	2、根据条件串获取该表满足条件的DataTable；
            arrUserRoleRelationObjList = clsQxUserRoleRelationBL.GetObjLst(strWhereCond);
            ///	3、设置ListView的列头信息
            lvQxUserRoleRelation.Items.Clear();//清除原来所有Item
            lvQxUserRoleRelation.Columns.Clear();//清除原来所有列头信息
            lvQxUserRoleRelation.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxUserRoleRelation.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxUserRoleRelation.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxUserRoleRelation.Columns.Add("项目编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxUserRoleRelation.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxUserRoleRelation.View = System.Windows.Forms.View.Details;
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsQxUserRoleRelationEN objUserRoleRelationEN in arrUserRoleRelationObjList)
            {
                lviUserRoleRelation = new System.Windows.Forms.ListViewItem();
                lviUserRoleRelation.Tag = objUserRoleRelationEN.mId;
                lviUserRoleRelation.Text = objUserRoleRelationEN.mId.ToString();
                lviUserRoleRelation.SubItems.Add(objUserRoleRelationEN.UserId);
                lviUserRoleRelation.SubItems.Add(objUserRoleRelationEN.RoleId);
                lviUserRoleRelation.SubItems.Add(objUserRoleRelationEN.QxPrjId);
                lviUserRoleRelation.SubItems.Add(objUserRoleRelationEN.Memo);
                lvQxUserRoleRelation.Items.Add(lviUserRoleRelation);
            }
            ///	4、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。
            return arrUserRoleRelationObjList.Count;
        }
        public static int DelRecord(string strUserId, string strRoleId)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("RoleId = '{0}'", strRoleId);
            sbCondition.AppendFormat(" and UserId = '{0}'", strUserId);
            return clsQxUserRoleRelationBL.DelQxUserRoleRelationsByCond(sbCondition.ToString());
        }
        /// <summary>
        /// 为用户添加角色，如果不存在就添加
        /// </summary>
        /// <param name="strRoleId">角色ID</param>
        /// <param name="strUserId">用户ID</param>
        /// <returns>是否成功</returns>
        public static bool AddRecord(string strUserId, string strRoleId, string strOpUser)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("RoleId = '{0}'", strRoleId);
            sbCondition.AppendFormat(" and UserId = '{0}'", strUserId);
            if (clsQxUserRoleRelationBL.IsExistRecord(sbCondition.ToString()) == false)
            {
                clsQxUserRoleRelationEN objUserRoleRelationEN = new clsQxUserRoleRelationEN();
                objUserRoleRelationEN.UserId = strUserId;
                objUserRoleRelationEN.RoleId = strRoleId;

                objUserRoleRelationEN.QxPrjId = clsQxRolesBL.GetObjByRoleId(strRoleId).QxPrjId;
                objUserRoleRelationEN.UpdUser = strOpUser;
                objUserRoleRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);

                string strCondition = string.Format("QxPrjId='{0}' And UserId='{1}'", objUserRoleRelationEN.QxPrjId, strUserId);
                if (clsQxPrjUserRelationBL.IsExistRecord(strCondition) == false)
                {
                    clsQxPrjUserRelationEN objQxPrjUserRelation = new clsQxPrjUserRelationEN();
                    objQxPrjUserRelation.UserId = strUserId;
                    objQxPrjUserRelation.QxPrjId = objUserRoleRelationEN.QxPrjId;
                    objQxPrjUserRelation.UpdUser = strOpUser;
                    objQxPrjUserRelation.Memo = clsDateTime.getTodayStr(0);
                    clsQxPrjUserRelationBL.AddNewRecordBySql2(objQxPrjUserRelation);

                }

                clsQxUserRoleRelationBL.AddNewRecordBySql2(objUserRoleRelationEN);
            }
            return true;
        }
        /// <summary>
        /// 更新某用户的角色，把原角色都删除，只添加新的角色。
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="arrRoles">角色列表</param>
        /// <param name="strPrjId">项目ID</param>
        /// <returns>是否成功</returns>
        public static bool UpdateRoles4User(string strUserId, ArrayList arrRoles, string strPrjId)
        {
            clsQxUserRoleRelationEN objUserRoleRelationEN = new clsQxUserRoleRelationEN();
            clsQxUserRoleRelationBL.DelQxUserRoleRelationsByCond(" UserId = '" + strUserId + "' and QxPrjId = '" + strPrjId + "'");//把原来此人的角色全部删除
            foreach (string strRole in arrRoles)
            {
                objUserRoleRelationEN.UserId = strUserId;
                objUserRoleRelationEN.RoleId = strRole;
                objUserRoleRelationEN.QxPrjId = strPrjId;
                string strCondition = string.Format("QxPrjId='{0}' And UserId='{1}'", strPrjId, strUserId);
                if (clsQxPrjUserRelationBL.IsExistRecord(strCondition) == false)
                {
                    clsQxPrjUserRelationEN objQxPrjUserRelation = new clsQxPrjUserRelationEN();
                    objQxPrjUserRelation.UserId = strUserId;
                    objQxPrjUserRelation.QxPrjId = strPrjId;
                    objQxPrjUserRelation.Memo = clsDateTime.getTodayStr(0);
                    clsQxPrjUserRelationBL.AddNewRecordBySql2(objQxPrjUserRelation);

                }
                clsQxUserRoleRelationBL.AddNewRecordBySql2(objUserRoleRelationEN);
            }
            return true;
        }

        /// <summary>
        /// 判断当前表中是否存在给定关键字值的记录
        /// </summary>
        /// <param name="lngmId">给定的关键字值</param>
        /// <returns>返回是否存在?</returns>
        public static bool IsExistCondRecEx(string strCondition, clsSpecSQLforSql objSQL)
        {

            if (objSQL.IsExistRecord(clsQxUserRoleRelationEN._CurrTabName, strCondition))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 获取该帐户在本系统中的角色号RoleId 列表，
        /// </summary>
        /// <param name="strUserId">用户号</param>
        /// <returns>角色号RoleId 的列表 </returns>
        public static List<string> Get_QxUserRoleIdList(string strPrjId, string strUserId)
        {
            List<string> arrRoleIdList = new List<string>();
            StringBuilder sb = new StringBuilder("");

            sb.AppendFormat(" UserId = '{0}'", strUserId);
            sb.AppendFormat(" and QxPrjId = '{0}'", strPrjId);
            arrRoleIdList = clsQxUserRoleRelationBL.GetFldValue(conQxUserRoleRelation.RoleId, sb.ToString());

            return arrRoleIdList;

        }
        /// <summary>
        /// 根据用户Id获取角色对象列表
        /// </summary>
        /// <param name="strUserId">用户Id</param>
        /// <returns></returns>
        public static List<clsQxUserRoleRelationEN> GetObjLstByUserId(string strUserId)
        {
            string strWhereCond = string.Format("{0}='{1}'", conQxUserRoleRelation.UserId, strUserId);

            List<clsQxUserRoleRelationEN> arrQxUserRoleRelationObjList;
            ///	2、根据条件串获取该表满足条件的DataTable；
            arrQxUserRoleRelationObjList = clsQxUserRoleRelationBL.GetObjLst(strWhereCond);
            ///	4、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。
            return arrQxUserRoleRelationObjList;
        }


        /// <summary>
        /// 获取该帐户在本系统中的角色号RoleId 列表，
        /// </summary>
        /// <param name="strUserId">用户号</param>
        /// <returns>角色号RoleId 的列表 </returns>
        public static List<string> Get_UserRoleIdList2(string strPrjId, string strUserId)
        {
            List<string> arrRoleIdList = new List<string>();

            StringBuilder sb = new StringBuilder("");

            sb.AppendFormat(" UserId = '{0}'", strUserId);
            sb.AppendFormat(" and QxPrjId = '{0}'", strPrjId);
            arrRoleIdList = clsQxUserRoleRelationBL.GetFldValue(conQxUserRoleRelation.RoleId, sb.ToString());
            return arrRoleIdList;

        }
    }
}