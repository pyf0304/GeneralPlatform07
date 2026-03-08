
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUserGroupPotenceBLEx
表名:QxUserGroupPotence
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:05:58
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:用户权限管理
模块英文名:UserPotenceMan
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
    /// 用户权限关系(QxUserGroupPotence)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxUserGroupPotenceBLEx : clsQxUserGroupPotenceBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxUserGroupPotenceDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxUserGroupPotenceDAEx QxUserGroupPotenceDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxUserGroupPotenceDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 功能：为用户添加权限
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPotenceId">权限码</param>
        /// <returns>返回添加是否成功</returns>
        public static bool UserAddPotence(string strPrjId, string strUserId, string strPotenceId)
        {
            StringBuilder strCondition = new StringBuilder();
            clsQxUserGroupPotenceEN objUserGroupPotence;
            strCondition.AppendFormat("{3}='{0}' and UserId='{1}' and PotenceId = '{2}'", strPrjId, strUserId, strPotenceId,
                conQxUserGroupPotence.QxPrjId);
            if (clsQxUserGroupPotenceBL.IsExistRecord(strCondition.ToString()) == false)
            {
                objUserGroupPotence = new clsQxUserGroupPotenceEN();
                objUserGroupPotence.QxPrjId = strPrjId;
                objUserGroupPotence.UserId = strUserId;
                objUserGroupPotence.PotenceId = strPotenceId;
                return clsQxUserGroupPotenceBL.AddNewRecordBySql2(objUserGroupPotence);
            }
            return true;
        }
        /// <summary>
        /// 功能：为用户组添加权限
        /// </summary>
        /// <param name="strGroupId">用户组ID</param>
        /// <param name="strPotenceId">权限码</param>
        /// <returns>返回添加是否成功</returns>
        public static bool GroupAddPotence(string strPrjId, string strGroupId, string strPotenceId)
        {
            StringBuilder strCondition = new StringBuilder();
            clsQxUserGroupPotenceEN objUserGroupPotence;
            strCondition.AppendFormat("{3}='{0}' and GroupId='{1}' and PotenceId = '{2}'", strPrjId, strGroupId, strPotenceId,
                conQxUserGroupPotence.QxPrjId);
            if (clsQxUserGroupPotenceBL.IsExistRecord(strCondition.ToString()) == false)
            {
                objUserGroupPotence = new clsQxUserGroupPotenceEN();
                objUserGroupPotence.QxPrjId = strPrjId;
                objUserGroupPotence.GroupId = strGroupId;
                objUserGroupPotence.PotenceId = strPotenceId;
                return clsQxUserGroupPotenceBL.AddNewRecordBySql2(objUserGroupPotence);
            }
            return true;
        }

        /// <summary>
        /// 功能：为单用户添加多权限
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="arrPotenceId">权限码列表</param>
        /// <returns>返回添加是否成功</returns>
        public static bool UserAddPotences(string strPrjId, string strUserId, ArrayList arrPotenceId)
        {
            StringBuilder strCondition;
            clsQxUserGroupPotenceEN objUserGroupPotence = new clsQxUserGroupPotenceEN();
            foreach (string strPotenceId in arrPotenceId)
            {
                strCondition = new StringBuilder();
                strCondition.AppendFormat("{3}='{0}' and UserId='{1}' and PotenceId = '{2}'", strPrjId, strUserId, strPotenceId,
                    conQxUserGroupPotence.QxPrjId);
                if (clsQxUserGroupPotenceBL.IsExistRecord(strCondition.ToString()) == false)
                {
                    objUserGroupPotence.QxPrjId = strPrjId;
                    objUserGroupPotence.UserId = strUserId;
                    objUserGroupPotence.PotenceId = strPotenceId;

                    clsQxUserGroupPotenceBL.AddNewRecordBySql2(objUserGroupPotence);
                }
            }
            return true;
        }
        /// <summary>
        /// 功能：为单用户组添加多权限
        /// </summary>
        /// <param name="strGroupId">用户组ID</param>
        /// <param name="arrPotenceId">权限码列表</param>
        /// <returns>返回添加是否成功</returns>
        public static bool GroupAddPotences(string strPrjId, string strGroupId, ArrayList arrPotenceId)
        {
            StringBuilder strCondition;
            clsQxUserGroupPotenceEN objUserGroupPotence = new clsQxUserGroupPotenceEN();
            foreach (string strPotenceId in arrPotenceId)
            {
                strCondition = new StringBuilder();
                strCondition.AppendFormat("{3}='{0}' and GroupId='{1}' and PotenceId = '{2}'",
                    strPrjId, strGroupId, strPotenceId,
                    conQxUserGroupPotence.QxPrjId);
                if (clsQxUserGroupPotenceBL.IsExistRecord(strCondition.ToString()) == false)
                {
                    objUserGroupPotence.QxPrjId = strPrjId;
                    objUserGroupPotence.GroupId = strGroupId;
                    objUserGroupPotence.PotenceId = strPotenceId;
                    clsQxUserGroupPotenceBL.AddNewRecordBySql2(objUserGroupPotence);
                }
            }
            return true;
        }

        /// <summary>
        /// 功能：为角色添加多权限
        /// </summary>
        /// <param name="strRoleId">角色ID</param>
        /// <param name="arrPotenceId">权限码列表</param>
        /// <returns>返回添加是否成功</returns>
        public static bool RoleAddPotences(string strPrjId, string strRoleId, ArrayList arrPotenceId)
        {
            StringBuilder strCondition;
            clsQxUserGroupPotenceEN objUserGroupPotence = new clsQxUserGroupPotenceEN();
            foreach (string strPotenceId in arrPotenceId)
            {
                strCondition = new StringBuilder();
                strCondition.AppendFormat("{3}='{0}' and RoleId='{1}' and PotenceId = '{2}'",
                    strPrjId, strRoleId, strPotenceId,
                    conQxUserGroupPotence.QxPrjId);
                if (clsQxUserGroupPotenceBL.IsExistRecord(strCondition.ToString()) == false)
                {
                    objUserGroupPotence.QxPrjId = strPrjId;
                    objUserGroupPotence.RoleId = strRoleId;
                    objUserGroupPotence.PotenceId = strPotenceId;
                    clsQxUserGroupPotenceBL.AddNewRecordBySql2(objUserGroupPotence);
                }
            }
            return true;
        }


        /// <summary>
        /// 功能：为角色添加多权限标志
        /// </summary>
        /// <param name="strRoleId">角色ID</param>
        /// <param name="arrPotenceId">权限码列表</param>
        /// <returns>返回添加是否成功</returns>
        public static bool RoleAddPotenceSymbol(string strPrjId, string strRoleId, ArrayList arrPotenceSymbolMid)
        {
            StringBuilder strCondition;
            clsQxUserGroupPotenceEN objUserGroupPotence = new clsQxUserGroupPotenceEN();
            foreach (string strPotenceSymbolMid in arrPotenceSymbolMid)
            {
                strCondition = new StringBuilder();
                strCondition.AppendFormat("{3}='{0}' and RoleId='{1}' and RelaMid = '{2}'",
                    strPrjId, strRoleId, strPotenceSymbolMid,
                    conQxUserGroupPotence.QxPrjId);
                if (clsQxUserGroupPotenceBL.IsExistRecord(strCondition.ToString()) == false)
                {
                    objUserGroupPotence.QxPrjId = strPrjId;
                    objUserGroupPotence.RoleId = strRoleId;
                    objUserGroupPotence.PotenceId = clsQxRelaOfPotenceAndSymbolBL.GetObjByRelaMid(long.Parse(strPotenceSymbolMid)).PotenceId;
                    objUserGroupPotence.RelaMid = long.Parse(strPotenceSymbolMid);
                    clsQxUserGroupPotenceBL.AddNewRecordBySql2(objUserGroupPotence);
                }
            }
            return true;
        }

        /// <summary>
        /// 功能：为角色添加多权限标志
        /// </summary>
        /// <param name="strRoleId">角色ID</param>
        /// <param name="arrPotenceId">权限码列表</param>
        /// <returns>返回添加是否成功</returns>
        public static bool AddPotenceSymbol4Role(string strRoleId, long lngReleMid, string strPrjId)
        {
            StringBuilder strCondition;
            clsQxUserGroupPotenceEN objUserGroupPotence = new clsQxUserGroupPotenceEN();
            strCondition = new StringBuilder();
            strCondition.AppendFormat("{3}='{0}' and RoleId='{1}' and RelaMid = '{2}'",
                strPrjId, strRoleId, lngReleMid,
                conQxUserGroupPotence.QxPrjId);
            if (clsQxUserGroupPotenceBL.IsExistRecord(strCondition.ToString()) == false)
            {
                objUserGroupPotence.QxPrjId = strPrjId;
                objUserGroupPotence.RoleId = strRoleId;
                objUserGroupPotence.PotenceId = clsQxRelaOfPotenceAndSymbolBL.GetObjByRelaMid(lngReleMid).PotenceId;
                objUserGroupPotence.RelaMid = lngReleMid;
                clsQxUserGroupPotenceBL.AddNewRecordBySql2(objUserGroupPotence);
            }
            return true;
        }
        /// <summary>
        /// 功能：为多用户添加多权限
        /// </summary>
        /// <param name="arrUserId">用户ID列表</param>
        /// <param name="arrPotenceId">权限码列表</param>
        /// <returns>返回添加是否成功</returns>
        public static bool UsersAddPotences(string strPrjId, ArrayList arrUserId, ArrayList arrPotenceId)
        {
            StringBuilder strCondition;
            clsQxUserGroupPotenceEN objUserGroupPotence = new clsQxUserGroupPotenceEN();
            foreach (string strUserId in arrUserId)
            {
                foreach (string strPotenceId in arrPotenceId)
                {
                    strCondition = new StringBuilder();
                    strCondition.AppendFormat("{3}='{0}' and UserId='{1}' and PotenceId = '{2}'",
                        strPrjId, strUserId, strPotenceId,
                        conQxUserGroupPotence.QxPrjId);
                    if (clsQxUserGroupPotenceBL.IsExistRecord(strCondition.ToString()) == false)
                    {
                        objUserGroupPotence.QxPrjId = strPrjId;
                        objUserGroupPotence.UserId = strUserId;
                        objUserGroupPotence.PotenceId = strPotenceId;
                        clsQxUserGroupPotenceBL.AddNewRecordBySql2(objUserGroupPotence);
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// 功能：为多用户组添加多权限
        /// </summary>
        /// <param name="arrGroupId">用户组ID列表</param>
        /// <param name="arrPotenceId">权限码列表</param>
        /// <returns>返回添加是否成功</returns>
        public static bool GroupsAddPotences(string strPrjId, ArrayList arrGroupId, ArrayList arrPotenceId)
        {
            StringBuilder strCondition;
            clsQxUserGroupPotenceEN objUserGroupPotence = new clsQxUserGroupPotenceEN();
            foreach (string strGroupId in arrGroupId)
            {
                foreach (string strPotenceId in arrPotenceId)
                {
                    strCondition = new StringBuilder();
                    strCondition.AppendFormat("{3}='{0}' and GroupId='{1}' and PotenceId = '{2}'",
                        strPrjId, strGroupId, strPotenceId,
                        conQxUserGroupPotence.QxPrjId);
                    if (clsQxUserGroupPotenceBL.IsExistRecord(strCondition.ToString()) == false)
                    {
                        objUserGroupPotence.QxPrjId = strPrjId;
                        objUserGroupPotence.GroupId = strGroupId;
                        objUserGroupPotence.PotenceId = strPotenceId;
                        clsQxUserGroupPotenceBL.AddNewRecordBySql2(objUserGroupPotence);
                    }
                }
            }
            return true;
        }


        /// <summary>
        /// 功能：删除某用户的某一权限
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPotenceId">权限码</param>
        /// <returns>返回删除的记录数</returns>
        public static int UserDelPotence(string strPrjId, string strUserId, string strPotenceId)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("{3}='{0}' and UserId='{1}' and PotenceId = '{2}'",
                strPrjId, strUserId, strPotenceId,
                conQxUserGroupPotence.QxPrjId);
            return clsQxUserGroupPotenceBL.DelQxUserGroupPotencesByCond(strCondition.ToString());
        }

        /// <summary>
        /// 功能：删除某用户的某些权限
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="arrNeedDelPotences">某些权限列表</param>
        /// <returns>被删除的权限个数</returns>
        public static int UserDelSomePotence(string strPrjId, string strUserId, ArrayList arrNeedDelPotences)
        {
            StringBuilder strCondition = new StringBuilder();
            string strPotenceId;
            foreach (object obj in arrNeedDelPotences)
            {
                strPotenceId = obj.ToString();
                strCondition.AppendFormat("{3}='{0}' and UserId='{1}' and PotenceId = '{2}'",
                    strPrjId, strUserId, strPotenceId,
                    conQxUserGroupPotence.QxPrjId);
                clsQxUserGroupPotenceBL.DelQxUserGroupPotencesByCond(strCondition.ToString());
            }
            return arrNeedDelPotences.Count;
        }

        /// <summary>
        /// 功能：删除某用户组的某一权限
        /// </summary>
        /// <param name="strGroupId">用户ID</param>
        /// <param name="strPotenceId">权限码</param>
        /// <returns>返回删除的记录数</returns>
        public static int GroupDelPotence(string strPrjId, string strGroupId, string strPotenceId)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("{3}='{0}' and GroupId='{1}' and PotenceId = '{2}'",
                strPrjId, strGroupId, strPotenceId,
                conQxUserGroupPotence.QxPrjId);
            return clsQxUserGroupPotenceBL.DelQxUserGroupPotencesByCond(strCondition.ToString());
        }
        /// <summary>
        /// 功能：删除某用户的所有权限
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>返回删除的记录数</returns>
        public static int UserDelAllPotence(string strPrjId, string strUserId)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("{2}='{0}' and UserId='{1}'", strPrjId, strUserId,
                conQxUserGroupPotence.QxPrjId);
            return clsQxUserGroupPotenceBL.DelQxUserGroupPotencesByCond(strCondition.ToString());
        }
        /// <summary>
        /// 功能：删除某用户组的所有权限
        /// </summary>
        /// <param name="strGroupId">用户ID</param>
        /// <returns>返回删除的记录数</returns>
        public static int GroupDelAllPotence(string strPrjId, string strGroupId)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("{2}='{0}' and GroupId='{1}'", strPrjId, strGroupId,
                conQxUserGroupPotence.QxPrjId);
            return clsQxUserGroupPotenceBL.DelQxUserGroupPotencesByCond(strCondition.ToString());
        }

        /// <summary>
        /// 功能：删除某用户组的某些权限
        /// </summary>
        /// <param name="strRoleId">角色ID</param>
        /// <param name="arrNeedDelPotences">某些权限列表</param>
        /// <returns>被删除的权限个数</returns>
        public static int GroupDelSomePotence(string strPrjId, string strGroupId, ArrayList arrNeedDelPotences)
        {
            StringBuilder strCondition = new StringBuilder();
            string strPotenceId;
            foreach (object obj in arrNeedDelPotences)
            {
                strPotenceId = obj.ToString();
                strCondition.AppendFormat("{3}='{0}' and GroupId='{1}' and PotenceId = '{2}'",
                    strPrjId, strGroupId, strPotenceId,
                    conQxUserGroupPotence.QxPrjId);
                clsQxUserGroupPotenceBL.DelQxUserGroupPotencesByCond(strCondition.ToString());
            }
            return arrNeedDelPotences.Count;
        }


        /// <summary>
        /// 功能：删除某角色的所有权限
        /// </summary>
        /// <param name="strGroupId">用户ID</param>
        /// <returns>返回删除的记录数</returns>
        public static int RoleDelAllPotence(string strPrjId, string strRoleId)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("{2}='{0}' and RoleId='{1}'", strPrjId, strRoleId,
                conQxUserGroupPotence.QxPrjId);
            return clsQxUserGroupPotenceBL.DelQxUserGroupPotencesByCond(strCondition.ToString());
        }

        /// <summary>
        /// 功能：删除某角色的某些权限
        /// </summary>
        /// <param name="strRoleId">角色ID</param>
        /// <param name="arrNeedDelPotences">某些权限列表</param>
        /// <returns>被删除的权限个数</returns>
        public static int RoleDelSomePotence(string strPrjId, string strRoleId, ArrayList arrNeedDelPotences)
        {
            StringBuilder strCondition;
            string strPotenceId;
            foreach (object obj in arrNeedDelPotences)
            {
                strPotenceId = obj.ToString();
                strCondition = new StringBuilder();
                strCondition.AppendFormat("{3}='{0}' and RoleId='{1}' and PotenceId = '{2}'",
                    strPrjId, strRoleId, strPotenceId,
                    conQxUserGroupPotence.QxPrjId);
                clsQxUserGroupPotenceBL.DelQxUserGroupPotencesByCond(strCondition.ToString());
            }
            return arrNeedDelPotences.Count;
        }


        /// <summary>
        /// 功能：删除某角色的某些权限
        /// </summary>
        /// <param name="strRoleId">角色ID</param>
        /// <param name="arrNeedDelPotences">某些权限列表</param>
        /// <returns>被删除的权限个数</returns>
        public static int DelPotence4Role(string strRoleId, long lngReleMid, string strPrjId)
        {
            StringBuilder strCondition;
            strCondition = new StringBuilder();
            strCondition.AppendFormat("{3}='{0}' and RoleId='{1}' and ReleMid = '{2}'",
                strPrjId, strRoleId, lngReleMid,
                conQxUserGroupPotence.QxPrjId);
            return clsQxUserGroupPotenceBL.DelQxUserGroupPotencesByCond(strCondition.ToString());

        }

        /// <summary>
        /// 功能：删除某角色的某些权限标志
        /// </summary>
        /// <param name="strRoleId">角色ID</param>
        /// <param name="arrNeedDelPotences">某些权限列表</param>
        /// <returns>被删除的权限个数</returns>
        public static int RoleDelSomePotenceSymbol(string strPrjId, string strRoleId, ArrayList arrNeedDelPotencesSymbolRelaMid)
        {
            StringBuilder strCondition;
            string strPotencesSymbolRelaMid;
            foreach (object obj in arrNeedDelPotencesSymbolRelaMid)
            {
                strPotencesSymbolRelaMid = obj.ToString();
                strCondition = new StringBuilder();
                strCondition.AppendFormat("{3}='{0}' and RoleId='{1}' and RelaMid = '{2}'",
                    strPrjId, strRoleId, strPotencesSymbolRelaMid,
                    conQxUserGroupPotence.QxPrjId);
                clsQxUserGroupPotenceBL.DelQxUserGroupPotencesByCond(strCondition.ToString());
            }
            return arrNeedDelPotencesSymbolRelaMid.Count;
        }

    }
}