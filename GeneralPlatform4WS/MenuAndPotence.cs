using com.taishsoft.common;
using com.taishsoft.datetime;
using GeneralPlatform4WS.ServiceReferenceQxDepartmentInfo;
using GeneralPlatform4WS.ServiceReferenceQxPrjUserRelation;
using GeneralPlatform4WS.ServiceReferenceQxProjects;
using GeneralPlatform4WS.ServiceReferenceQxUserMenus;
using GeneralPlatform4WS.ServiceReferenceQxUserRoleRelation;
using GeneralPlatform4WS.ServiceReferenceQxUserRoles;
using GeneralPlatform4WS.ServiceReferenceQxUsers;
using GeneralPlatform4WS.ServiceReferenceQxUserState;

using GeneralPlatform4WS.ServiceReferencevQxRoleMenus;
using SpecData;
///该类为统一平台客户端信息处理类，目标为方便各个应用系统编程，实现和统一平台的无缝结合
///本dll为web版
///目前版本：V0.31，
///定义时间：2005年8月15日
///最后修改：2005年8月28日
///最后修改者：鲍文俊
///
///修改日志：
///
///2005年8月15日：
///1。完成dll类的初步功能
///2。交付初步测试
///
///2005年8月22日
///1。添加了用户修改当前口令的接口函数
///2。修改并完善了权限等级的功能函数
///
///2005年8月28日
///1。添加用户登录的函数接口 便于每个系统自己制作登录页面
///2。添加返回用户系统角色列表的接口，便于用户自己制作登录页后查询并显示用户的多角色，供选择
///
///
///2005年8月31日
///1。修改了获取当前项目的属性方法，在取当前项目前判断Session中有项目号则取session中的，否则取config文件中的
///
///2005年11月21日
///1。增加函数，返回本项目的角色列表
///
///2005年11月22日
///1。增加函数，通过接口添加一个帐号和所属角色
///2。增加函数，通过接口删除一个帐号的角色
///3。增加函数，通过接口增加一个帐号的角的
///
///2005年12月21日
///1。增加函数，Get_PotenceSymbolForCurrentView 获取用户在当前页面的使用标志，配合新修改的数据库和view
///		优点：可以不需要在登陆以后加载权限列表，直接到view中查询，凡是修改好权限设置以后，不用重新登陆就立即生效
///


using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Text;
using System.Xml;
//using com.taishsoft.common;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// Class1 的摘要说明。
    /// </summary>
    public class MenuAndPotence
    {
        //private A1rrayList objPotenceArr=new A1rrayList();
        private string mstrModuleName;
        private const string EXCEPTION_MSG = "there was an error in the method. please see the Application Log for details.";
        //	
        public MenuAndPotence()
        {
            mstrModuleName = this.GetType().ToString();
        }




        /// <summary>
        /// 公共方法
        /// </summary>
        #region "Public Methods"


        /// <summary>
        /// 返回帐户当前状态号
        /// </summary>
        /// <param name="strUserId">帐户名</param>
        /// <returns>状态号：01表示正常，02表示暂停，0表示没有该用户</returns>
        public string Get_UserStateId(string strUserId)
        {
            
            if (clsQxUsersWS.IsExistWs(strUserId))
            {
                clsQxUsersEN objUsersEN = clsQxUsersWS.GetObjByUserIdWs(strUserId);

                string strUserStateId = objUsersEN.UserStateId;
                return strUserStateId;

            }
            else
            {
                return "0";

            }
        }

        /// <summary>
        /// 获取该帐户在本系统中的角色列表，其中包含列：用户号 UserId ，姓名UserName， 角色号RoleId ，角色名称Role
        /// </summary>
        /// <param name="strUserId">用户号</param>
        /// <returns>数据表，其中包含列：用户号 UserId ，姓名UserName， 角色号RoleId ，角色名称Role </returns>
        public DataTable Get_QxUserRoles(string strUserId, string strPrjId)
        {
            DataTable objDt = new DataTable();

            objDt = this.Get_QxUserRoleRelationByJoinUsersV(strUserId, strPrjId);

            return objDt;

        }
        /// <summary>
        /// 获取该帐户在本系统中的角色列表，其中包含列：用户号 UserId ，姓名UserName， 角色号RoleId ，角色名称Role
        /// </summary>
        /// <param name="strUserId">用户号</param>
        /// <returns>数据表，其中包含列：用户号 UserId ，姓名UserName， 角色号RoleId ，角色名称Role </returns>
        public List<clsQxUserRolesEN> Get_QxUserRoleObjList(string strPrjId, string strUserId)
        {
            List<clsQxUserRolesEN> arrObjList = new List<clsQxUserRolesEN>();
            DataTable objDT = new DataTable();

            objDT = this.Get_QxUserRoleRelationByJoinUsersV(strUserId, strPrjId);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsQxUserRolesEN objUserRoles = new clsQxUserRolesEN();
                objUserRoles.RoleId = objRow["RoleId"].ToString().Trim();     //角色Id
                objUserRoles.RoleName = objRow["RoleName"].ToString().Trim();     //角色名称
                objUserRoles.QxPrjId = objRow["QxPrjId"].ToString().Trim();     //项目编号
                objUserRoles.Memo = objRow["Memo"].ToString().Trim();     //备注
                arrObjList.Add(objUserRoles);
            }
            objDT = null;
            return arrObjList;

        }
        /// <summary>
        /// 获取该帐户在本系统中的角色号RoleId 列表，
        /// </summary>
        /// <param name="strUserId">用户号</param>
        /// <returns>角色号RoleId 的列表 </returns>
        public List<string>  Get_RoleIdList(string strPrjId, string strUserId)
        {
            List<string>  arrRoleIdList = new List<string> ();
            DataTable objDT = new DataTable();

            objDT = this.Get_QxUserRoleRelationByJoinUsersV(strUserId, strPrjId);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrRoleIdList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {

                arrRoleIdList.Add(objRow["RoleId"].ToString().Trim());
            }
            objDT = null;
            return arrRoleIdList;

        }
        /// <summary>
        /// 获取该帐户在本系统中的角色号RoleId 列表，
        /// </summary>
        /// <param name="strUserId">用户号</param>
        /// <returns>角色号RoleId 的列表 </returns>
        public List<string> Get_RoleIdList2(string strPrjId, string strUserId)
        {
            List<string> arrRoleIdList = new List<string>();
            DataTable objDT = new DataTable();

            objDT = this.Get_QxUserRoleRelationByJoinUsersV(strUserId, strPrjId);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrRoleIdList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {

                arrRoleIdList.Add(objRow["RoleId"].ToString().Trim());
            }
            objDT = null;
            return arrRoleIdList;

        }
        public string GetQxRoleNameByRoleId(string strRoleId)
        {
            clsQxUserRolesEN objUserRoles = new clsQxUserRolesEN();
            objUserRoles.RoleId = strRoleId;
            clsQxUserRolesWS.GetQxUserRolesWs(ref objUserRoles);
            if (objUserRoles == null)
            {
                return "";
            }
            return objUserRoles.RoleName;
        }
        /// <summary>
        /// 获取角色权限列表
        /// </summary>
        /// <param name="strRoleId"></param>
        public List<string>  Get_QxUserRolePotence(string strRoleId, string strPrjId)
        {
            List<string>  lstPotenceArr = new List<string> ();
            DataTable objDt = this.clsQxUserGroupPotence_GetQxUserGroupPotence(" RoleId='" + strRoleId + "' and QxPrjId='" + strPrjId + "'");
            foreach (DataRow dr in objDt.Rows)
            {
                string strTemp = dr["PotenceId"].ToString();
                if (strTemp != "")
                {
                    //if (this.objPotenceArr == null)
                    //{
                    //    this.objPotenceArr = new List<string> ();
                    //}
                    if (lstPotenceArr.Contains(strTemp) == false)
                    {
                        lstPotenceArr.Add(strTemp);
                    }
                }
            }
            return lstPotenceArr;

        }
        /// <summary>
        /// 根据权限类型获取权限列表
        /// </summary>
        /// <param name="strPotenceTypeId">权限类型ID</param>
        public System.Data.DataTable GetRoleIdByPotenceId(List<string>  arrPotenceIds)
        {
            StringBuilder sbPotenceIds = new StringBuilder();
            foreach (string strPotenceId in arrPotenceIds)
            {
                sbPotenceIds.AppendFormat("'{0}',", strPotenceId);
            }
            string strPotenceIdLst = sbPotenceIds.ToString().Substring(0, sbPotenceIds.Length - 1);

            StringBuilder sbCond = new StringBuilder();
            sbCond.Append(" roleid in ");
            sbCond.AppendFormat(" (select roleid from usergrouppotence where potenceid in ({0}))", strPotenceIdLst);

            DataTable objDT = clsQxUserRolesWS.GetDataTableWs(sbCond.ToString());
            return objDT;
        }
        /// <summary>
        /// 根据权限类型获取权限列表
        /// </summary>
        /// <param name="strPotenceTypeId">权限类型ID</param>
        public System.Data.DataTable GetRoleIdByPotenceTypeId(string strPotenceTypeId)
        {
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append(" roleid in ");
            sbSQL.AppendFormat(" (select roleid from usergrouppotence where potenceid in (select potenceid from prjpotence where potencetypeid = '{0}'))", strPotenceTypeId);

            DataTable objDT = clsQxUserRolesWS.GetDataTableWs(sbSQL.ToString());

            return objDT;
        }

        /// <summary>
        /// 根据权限类型获取权限列表
        /// </summary>
        /// <param name="strPotenceTypeId">权限类型ID</param>
        public System.Data.DataTable GetRoleIdByPotenceTypeIdWithoutRoleIdList(string strPotenceTypeId, List<string>  arrRoleId)
        {
            StringBuilder sbRoleIds = new StringBuilder();
            foreach (string strRoleId in arrRoleId)
            {
                sbRoleIds.AppendFormat("'{0}',", strRoleId);
            }
            string strRoleIdLst = sbRoleIds.ToString().Substring(0, sbRoleIds.Length - 1);

            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append(" roleid in ");
            sbSQL.AppendFormat(" (select roleid from usergrouppotence where potenceid in (select potenceid from prjpotence where potencetypeid = '{0}')", strPotenceTypeId);
            sbSQL.AppendFormat(" and RoleId not in ({0}))", strRoleIdLst);
            DataTable objDT = clsQxUserRolesWS.GetDataTableWs(sbSQL.ToString());

            return objDT;
        }

        /// <summary>
        /// 根据权限类型获取权限列表
        /// </summary>
        /// <param name="strPotenceTypeId">权限类型ID</param>
        public System.Data.DataTable GetPotenceByTypeId(string strPotenceTypeId)
        {
            List<string>  lstPotenceArr = new List<string> ();
            DataTable objDt = clsQxPrjPotenceWS.GetDataTableWs(string.Format(" PotenceTypeId='{0}'", strPotenceTypeId));
            return objDt;
        }
        public System.Data.DataTable GetQxUsersByPotenceAndRoleIds(string strPotenceId, List<string>  arrRoleIds)
        {
            StringBuilder sbRoleId = new StringBuilder();
            foreach (string strRoleId in arrRoleIds)
            {
                sbRoleId.AppendFormat("'{0}',", strRoleId);
            }
            string strRoleIdLst = sbRoleId.ToString().Substring(0, sbRoleId.Length - 1);
            StringBuilder sbSQL = new StringBuilder();

            sbSQL.Append(" userid in ");
            sbSQL.Append(" (select userid from Qxuserrolerelation ");
            sbSQL.AppendFormat(" where roleid in({0})", strRoleIdLst);
            sbSQL.Append(" and roleid in (");
            sbSQL.AppendFormat(" select roleid from Qxusergrouppotence where potenceid ='{0}'", strPotenceId);
            sbSQL.Append(")");
            sbSQL.Append(")");
            DataTable objDT = clsQxUsersWS.GetDataTableWs(sbSQL.ToString());

            return objDT;
        }

        public System.Data.DataTable GetQxUsersByDepartmentAndRoleIds(string strDepartmentId, List<string>  arrRoleIds)
        {
            StringBuilder sbRoleId = new StringBuilder();
            foreach (string strRoleId in arrRoleIds)
            {
                sbRoleId.AppendFormat("'{0}',", strRoleId);
            }
            string strRoleIdLst = sbRoleId.ToString().Substring(0, sbRoleId.Length - 1);
            StringBuilder sbSQL = new StringBuilder();

            sbSQL.Append("  userid in ");
            sbSQL.Append(" (select userid from Qxuserrolerelation ");
            sbSQL.AppendFormat(" where roleid in({0})", strRoleIdLst);
            sbSQL.AppendFormat(" and DepartmentId = '{0}'", strDepartmentId);
            sbSQL.Append(")");
            DataTable objDT = clsQxUsersWS.GetDataTableWs(sbSQL.ToString());

            return objDT;

        }

        public System.Data.DataTable GetQxUsersByDepartmentsAndRoleIds(List<string>  arrDepartmentIdLst, List<string>  arrRoleIds)
        {
            StringBuilder sbRoleId = new StringBuilder();
            foreach (string strRoleId in arrRoleIds)
            {
                sbRoleId.AppendFormat("'{0}',", strRoleId);
            }
            string strRoleIdLst = sbRoleId.ToString().Substring(0, sbRoleId.Length - 1);
            string strDepartments = clsArray.GetSqlInStrByArray(arrDepartmentIdLst, true);
            StringBuilder sbSQL = new StringBuilder();

            sbSQL.Append("  userid in ");
            sbSQL.Append(" (select userid from Qxuserrolerelation ");
            sbSQL.AppendFormat(" where roleid in({0})", strRoleIdLst);
            sbSQL.AppendFormat(" and DepartmentId in ({0})", strDepartments);
            sbSQL.Append(")");
            DataTable objDT = clsQxUsersWS.GetDataTableWs(sbSQL.ToString());

            return objDT;


        }
        public System.Data.DataTable GetQxUsersByPotenceAndNoRoleIds(string strPotenceId, List<string>  arrRoleIds)
        {
            StringBuilder sbRoleId = new StringBuilder();
            foreach (string strRoleId in arrRoleIds)
            {
                sbRoleId.AppendFormat("'{0}',", strRoleId);
            }
            string strRoleIdLst = sbRoleId.ToString().Substring(0, sbRoleId.Length - 1);
            StringBuilder sbSQL = new StringBuilder();

            sbSQL.Append("  userid in ");
            sbSQL.Append(" (select userid from Qxuserrolerelation ");
            sbSQL.AppendFormat(" where roleid not in({0})", strRoleIdLst);
            sbSQL.Append(" and roleid in (");
            sbSQL.AppendFormat(" select roleid from usergrouppotence where potenceid ='{0}'", strPotenceId);
            sbSQL.Append(")");
            sbSQL.Append(")");
            DataTable objDT = clsQxUsersWS.GetDataTableWs(sbSQL.ToString());

            return objDT;


        }

        public System.Data.DataTable GetQxUsersByRoleIds(string strRoleId)
        {
            StringBuilder sbSQL = new StringBuilder();

            sbSQL.Append(" userid in ");
            sbSQL.Append(" (select userid from Qxuserrolerelation ");
            sbSQL.AppendFormat(" where roleid ='{0}')", strRoleId);
            DataTable objDT = clsQxUsersWS.GetDataTableWs(sbSQL.ToString());
            return objDT;

        }

        /// <summary>
        /// 获取角色权限列表
        /// </summary>
        /// <param name="strRoleId"></param>
        public List<string>  Get_PotenceByRoleId(string strRoleId)
        {
            List<string>  lstPotenceArr = new List<string> ();
            DataTable objDt = this.clsQxUserGroupPotence_GetQxUserGroupPotence(" RoleId='" + strRoleId + "'");
            foreach (DataRow dr in objDt.Rows)
            {
                string strTemp = dr["PotenceId"].ToString();
                if (strTemp != "")
                {
                    if (lstPotenceArr.Contains(strTemp) == false)
                    {
                        lstPotenceArr.Add(strTemp);
                    }
                }
            }
            return lstPotenceArr;

        }
        /// <summary>
        /// 获取用户在当前页面的使用等级
        /// </summary>
        /// <param name="ViewId">界面编号</param>
        /// <returns>返回等级号，0表示没有权使用</returns>
        //public string Get_PotenceLevelBak(string ViewId)
        //{
        //    //Get_QxUserRolePotence(strRoleId);
        //    if (this.objPotenceArr != null && this.objPotenceArr.Count != 0)
        //    {

        //        DataTable objDt = clsQxViewPotence_GetViewPotence(" Viewid='" + ViewId + "' order by level");

        //        foreach (DataRow dr in objDt.Rows)
        //        {
        //            if (objPotenceArr.Contains(dr["PotenceId"].ToString()))
        //            {
        //                return dr["Level"].ToString();
        //            }
        //        }
        //        return "0";
        //    }
        //    else
        //    {
        //        return "0";
        //    }
        //}


        ///// <summary>
        ///// 获取用户在当前页面的使用等级
        ///// </summary>
        ///// <param name="ViewId">界面编号</param>
        ///// <returns>返回等级号，0表示没有权使用</returns>
        public string Get_PotenceLevel(string ViewId, string strRoleId)
        {

            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" Viewid='{0}'", ViewId);
            sbCondition.AppendFormat("  and PotenceId in (Select PotenceId from UserGroupPotence where roleid='{0}')", strRoleId);
            sbCondition.AppendFormat("              order by level");
            DataTable objDt = clsQxViewPotence_GetViewPotence(sbCondition.ToString());
            foreach (DataRow dr in objDt.Rows)
            {
                return dr["Level"].ToString();
            }
            return "0";

        }
        ///// <summary>
        ///// 获取用户在当前页面的使用等级
        ///// </summary>
        ///// <param name="ViewId">界面编号</param>
        ///// <returns>返回等级号，0表示没有权使用</returns>
        public string Get_PotenceLevelBak2(string ViewId, List<string>  lstPotenceArr)
        {

            if (lstPotenceArr != null && lstPotenceArr.Count != 0)
            {
                DataTable objDt = clsQxViewPotence_GetViewPotence(" Viewid='" + ViewId + "' order by level");
                foreach (DataRow dr in objDt.Rows)
                {
                    if (lstPotenceArr.Contains(dr["PotenceId"].ToString()))
                    {
                        return dr["Level"].ToString();
                    }
                }
                return "0";
            }
            else
            {
                return "0";
            }
        }
        ///<summary>
        ///获取用户在当前页面的使用标志
        ///</summary>
        ///<param name="ViewId">界面编号</param>
        ///<returns>返回等级号，0表示没有权使用</returns>
        public string Get_PotenceSymbolForCurrentView(string ViewId, string strRoleId)
        {
            string strSymbol;

            List<string > objArr = clsCommDBFunctionWS.funGetFldValue("vPotenceSymbolForRole", "SymbolForProgramme", " ViewId ='" + ViewId + "' and RoleId = '" + strRoleId + "'");
            if (objArr.Count > 0)
            {
                strSymbol = objArr[0].ToString();
            }
            else
            {
                strSymbol = "";
            }

            return strSymbol;


        }

        /// <summary>
        /// 获取用户当前系统中的菜单
        /// </summary>
        /// <returns>以html形式返回的菜单</returns>
        public string Get_UserMenu4CurrentUser(string strRoleId, string strUserId, string strPrjId)
        {
            return this.GetQxUserMenuHTML(strPrjId, strRoleId, strUserId);
        }


        /// <summary>
        /// 获取用户当前系统中的菜单
        /// </summary>
        /// <returns>以html形式返回的菜单</returns>
        public string Get_UserMenu4CurrentUser_ThreeLayer(string strRoleId, string strUserId, string strPrjId)
        {
            return this.GetQxUserMenuHTML2(strPrjId, strRoleId, strUserId);
        }

        /// <summary>
        /// 修改当前用户的系统口令
        /// </summary>
        /// <param name="strCurrUserId">当前用户</param>
        /// <param name="strOldPassword">用户当前的密码，用以验证</param>
        /// <param name="strNewPassword">用户需要修改的新密码</param>
        /// <returns>修改成功，返回true，失败返回false</returns>
        public bool Change_CurrentUserPassword(string strCurrUserId, string strOldPassword, string strNewPassword)
        {
            clsQxUsersEN objUsersEN = clsQxUsersWS.GetObjByUserIdWs(strCurrUserId);
            if (objUsersEN == null)
            {
                string strMsg = string.Format("用户:{0}的不存在，请检查！", strCurrUserId);
                throw new Exception(strMsg);
            }
            if (objUsersEN.Password == strOldPassword)
            {
                objUsersEN.Password =  strNewPassword;
                objUsersEN.UpdDate = clsDateTime.getTodayStr(0);
                clsQxUsersWS.UpdateBySql2Ws(objUsersEN);
                return true;
            }
            else
            {
                string strMsg = string.Format("用户:{0}的原密码不正确，请检查！", strCurrUserId);
                throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 修改给定用户的系统口令
        /// </summary>
        /// <param name="strCurrUserId">当前用户名，一般为管理员，操作员等</param>
        /// <param name="strUserId">被改用户Id</param>
        /// <param name="strUserNewPassword">被改用户的新密码，用以验证</param>
        /// <param name="strCurrentUserPassword">当前用户的密码，即操作员的密码，以免非法用户改口令</param>
        /// <returns>修改成功，返回true，失败返回false</returns>
        public bool Change_UserPassword(string strCurrUserId, string strUserId, string strUserNewPassword, string strCurrentUserPassword)
        {
             clsQxUsersEN objUsersEN = clsQxUsersWS.GetObjByUserIdWs(strCurrUserId);
            if (objUsersEN == null)
            {
                string strMsg = string.Format("用户:{0}的不存在，请检查！", strCurrUserId);
                throw new Exception(strMsg);
            }
            if (objUsersEN.Password == strCurrentUserPassword)
            {


                if (objUsersEN != null)
                {
                    objUsersEN.Password = strUserNewPassword;
                    objUsersEN.UpdDate = clsDateTime.getTodayStr(0);
                    clsQxUsersWS.UpdateBySql2Ws(objUsersEN);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                string strMsg = string.Format("用户:{0}的原密码不正确，请检查！", strUserId);
                throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 检查用户当前登陆信息是否正确
        /// </summary>
        /// <returns></returns>
        public bool Check_Login(string requestUserId, string requestUserStateId, string requestRoleId)
        {
            if (requestUserId != "0" || requestUserStateId != "0" || requestRoleId != "0")
            {
                //clsPubPara.UserId = requestUserId;
                //clsPubPara.UserStateId = requestUserStateId;
                //clsPubPara.RoleId = requestRoleId;			
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsExistUserId(string strUserId)
        {
            return clsQxUsersWS.IsExistWs(strUserId);
        }
        public string Get_UserPassword(string strUserId)
        {
            clsQxUsersEN objUsers = new clsQxUsersEN();
            objUsers.UserId = strUserId;
            clsQxUsersWS.GetQxUsersWs(ref objUsers);
            return objUsers.Password;
        }
        /// <summary>
        /// 获取当前项目的角色列表
        /// </summary>
        /// <returns></returns>
        public DataTable Get_CurrPrjRoles(string strPrjId)
        {
            return this.Get_QxRolesOfPrj(strPrjId);
        }


        /// <summary>
        /// 添加一个用户帐号,并设置角色
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        public void Add_UserAndRoleIntoUsersForCurrPrj(string UserId, string UserName, string Password, string RoleId, string strPrjId)
        {

            this.AddaUserIntoUsers(UserId, UserName, Password);

            this.AddRoleIdForUser(UserId, RoleId, strPrjId);

        }


        /// <summary>
        /// 为帐号删除一个角色
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="RoleId"></param>
        public void Delete_RoleForUser(string UserId, string RoleId, string strPrjId)
        {
            this.DelRoleIdForUser(UserId, RoleId, strPrjId);

        }


        /// <summary>
        /// 删除当前工程的一个用户帐号，只有当前用户帐号所有工程中均没有角色时，才能删除
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strResult"></param>
        public int DeleteUser(string strUserId, ref string strResult)
        {
            if (clsQxUserRoleRelationWS.IsExistRecordWs("UserId = '" + strUserId + "'") == true)
            {
                strResult = "当前用户还存在角色，请该用户的角色删除后才能删除该用户!";
                return 0;
            }
            return clsQxUsersWS.DelRecordWs(strUserId);

        }



        /// <summary>
        /// 为帐号添加一个当前项目中的角色
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="RoleId"></param>
        public void Add_RoleForUser(string UserId, string RoleId, string strPrjId)
        {
            this.AddRoleIdForUser(UserId, RoleId, strPrjId);

        }









        #endregion


        /// <summary>
        /// 私有方法
        /// </summary>
        #region "Private Methods"


        /// <summary>
        /// 获取用户角色关系表
        /// </summary>
        /// <param name="strUserId">帐号</param>
        /// <param name="strUserPrjId">项目号</param>
        /// <returns>数据表</returns>
        private DataTable Get_QxUserRoleRelationByJoinUsers1(string strUserId, string strUserPrjId)
        {
            StringBuilder sb = new StringBuilder("");

            sb.AppendFormat("  UserId = '{0}'", strUserId);
            sb.AppendFormat(" and Qx = '{0}'", strUserPrjId);


            DataTable objDT = clsQxUserRoleRelationWS.GetDataTableVWs(sb.ToString());

            return objDT;

        }

        /// <summary>
        /// 获取用户角色关系表
        /// </summary>
        /// <param name="strUserId">帐号</param>
        /// <param name="strUserPrjId">项目号</param>
        /// <returns>数据表</returns>
        private DataTable Get_QxUserRoleRelationByJoinUsersV(string strUserId, string strUserPrjId)
        {
            StringBuilder sb = new StringBuilder("");

            sb.AppendFormat(" UserId = '{0}'", strUserId);
            sb.AppendFormat(" and QxPrjId = '{0}'", strUserPrjId);

            DataTable objDT = clsQxUserRoleRelationWS.GetDataTableVWs(sb.ToString());

            return objDT;

        }

        ///// <summary>
        ///// 功能：获取当前表中的符合条件的某字段的值，以列表返回
        ///// </summary>
        ///// <param name="strFldName">字段名</param>
        ///// <param name="strCondition">条件串</param>
        ///// <returns>获取的字段值列表</returns>
        //private List<String> clsQxUsers_funGetFldValue(string strFldName, string strCondition)
        //{

        //    List<String> arrList = clsCommDBFunctionWS.funGetFldValue("Users", strFldName, strCondition);
        //    return arrList;
        //}



        ///// <summary>
        ///// 是否存在一个帐户
        ///// </summary>
        ///// <param name="strUserId"></param>
        ///// <returns></returns>
        //private bool clsQxUsers_IsExist(string strUserId)
        //{

        //    if (clsCommDBFunctionWS.IsExistRecord("Users", "UserId=" + "'" + strUserId + "'"))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        /// <summary>
        /// 系统是否存在一个角色
        /// </summary>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        private bool IsExistRoleIdForPrj(string strRoleId, string strPrjId)
        {

            if (clsCommDBFunctionWS.IsExistRecord("QxUserRoles", "RoleId=" + "'" + strRoleId + "' and QxPrjId='" + strPrjId + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 添加一个用户帐号
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strUserName"></param>
        /// <param name="strPassword"></param>
        /// <returns></returns>
        private bool AddaUserIntoUsers(string strUserId, string strUserName, string strPassword)
        {
            clsQxUsersEN objUsers = new clsQxUsersEN();
            objUsers.UserId = strUserId;
            objUsers.UserName = strUserName;
            objUsers.Password = strPassword;
            objUsers.UserStateId = "01";
            return clsQxUsersWS.AddNewRecordBySql2Ws(objUsers);

        }

        /// <summary>
        /// 为帐户增加一个角色
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strRoleId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        private bool AddRoleIdForUser(string strUserId, string strRoleId, string strPrjId)
        {

            if (this.IsExistRoleIdForPrj(strRoleId, strPrjId))
            {
                this.DelRoleIdForUser(strUserId, strRoleId, strPrjId);
                clsQxUserRoleRelationEN objUsers = new clsQxUserRoleRelationEN();
                objUsers.UserId = strUserId;
                objUsers.RoleId = strRoleId;
                objUsers.QxPrjId = strPrjId;
                clsQxPrjUserRelationEN objPrjUserRelation = new clsQxPrjUserRelationEN();
                objPrjUserRelation.QxPrjId = strPrjId;
                objPrjUserRelation.UserId = strUserId;
                StringBuilder sbCondition = new StringBuilder();
                sbCondition.AppendFormat("QxPrjId = '{0}'", strPrjId);
                sbCondition.AppendFormat(" and UserId = '{0}'", strUserId);

                if (clsQxPrjUserRelationWS.IsExistRecordWs(sbCondition.ToString()) == false)
                {
                    clsQxPrjUserRelationWS.AddNewRecordBySql2Ws(objPrjUserRelation);
                }
                return clsQxUserRoleRelationWS.AddNewRecordBySql2Ws(objUsers);
            }
            else
            {
                return false;
            }



        }


        /// <summary>
        /// 为帐户删除一个角色
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strRoleId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        private int DelRoleIdForUser(string strUserId, string strRoleId, string strPrjId)
        {
            string strSQL = string.Format(" UserId = '{0}' and RoleId = '{1}' and QxPrjId = '{2}'", strUserId, strRoleId, strPrjId);
            return clsQxUserRoleRelationWS.DelQxUserRoleRelationsByCondWs(strSQL.ToString());
        }
        /// <summary>
        /// 为帐户删除所有角色
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strRoleId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public int Delete_AllRoleForUser(string strUserId, string strPrjId)
        {

            string strSQL = string.Format(" UserId = '{0}' and QxPrjId = '{1}'", strUserId, strPrjId);
            return clsQxUserRoleRelationWS.DelQxUserRoleRelationsByCondWs(strSQL.ToString());




        }

        /// <summary>
        /// 功能：获取当前日期的字符串
        /// 日期格式：
        ///    日期的字符串的格式有三种：
        ///		1、YYYYMMDD。	例如20050120
        ///		2、YYYY-MM-DD	例如2005-01-20
        ///		3、YYYY/MM/DD	例如2005/01/20
        /// </summary>
        /// <param name="intFormat">日期格式，共有3种，传入参数0,1，2
        ///							参数不同，函数返回值就不同，
        ///							参见上面的日期格式
        ///	</param>
        /// <returns>返回当前日期的字符串</returns>
        private string getTodayStr(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay;
            int intYear, intMonth, intDay;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            intDay = System.DateTime.Today.Day;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strToday = strYear + strMonth + strDay;
            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay;
                    break;
            }
            return strToday;
        }


        /// <summary>
        /// 通过条件获取用户组权限
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        private System.Data.DataTable clsQxUserGroupPotence_GetQxUserGroupPotence(string strCondition)
        {

            DataTable objDT = clsQxUserGroupPotenceWS.GetDataTableWs(strCondition);

            return objDT;

        }



        /// <summary>
        /// 获取当前角色的顶层菜单列表，以DATATABLE的形式返回
        /// </summary>
        /// <param name="strCondtion"></param>
        /// <returns>以DATATABLE形式表示的顶层菜单列表</returns>
        private System.Data.DataTable clsQxRoleMenusEx_GetUpMenuTable(string strRoleId, string strPrjId)
        {
            StringBuilder strSQL = new StringBuilder();

            strSQL.AppendFormat(" (RoleId = '{0}') AND (UpMenuId = '00000000') AND ",
                strRoleId);
            strSQL.AppendFormat("( QxPrjId = '{0}')",
                strPrjId);
            strSQL.Append(" ORDER BY OrderNum");

            DataTable objDT = clsQxRoleMenusWS.GetDataTableVWs(strSQL.ToString());

            return objDT;
        }


        /// <summary>
        /// 获取当前角色的顶层菜单列表，以DATATABLE的形式返回
        /// </summary>
        /// <param name="strCondtion"></param>
        /// <returns>以DATATABLE形式表示的顶层菜单列表</returns>
        private System.Data.DataTable clsQxRoleMenusEx_GetSubMenuTable(string strRoleId, string strPrjId)
        {
            StringBuilder strSQL = new StringBuilder();

            strSQL.AppendFormat("  (RoleId = '{0}') AND (UpMenuId <> '00000000') AND ",
                strRoleId);
            strSQL.AppendFormat(" (QxPrjId = '{0}')",
                strPrjId);
            strSQL.Append(" ORDER BY OrderNum");

            DataTable objDT = clsQxRoleMenusWS.GetDataTableVWs(strSQL.ToString());

            return objDT;
        }

        /// <summary>
        /// 功能：获取当前表中的符合条件的某字段的值，以列表返回
        /// </summary>
        /// <param name="strFldName">字段名</param>
        /// <param name="strCondition">条件串</param>
        /// <returns>获取的字段值列表</returns>
        private List<String> clsQxUserMenus_funGetFldValue(string strFldName, string strCondition)
        {

            List<String> arrList = clsCommDBFunctionWS.funGetFldValue("UserMenus", strFldName, strCondition);
            return arrList;
        }

        /// <summary>
        /// 功能：设置当前表中的符合条件的某字段的值
        /// </summary>
        /// <param name="strFldName">字段名</param>
        /// <param name="strValue">值</param>
        /// <param name="strCondition">条件串</param>
        /// <returns>影响的记录数</returns>
        //private int clsQxUsers_funSetFldValue(string strFldName, string strValue, string strCondition)
        //{

        //    int intRecCount = clsCommDBFunctionWS.funSetFldValue("Users", strFldName, strValue, strCondition);
        //    return intRecCount;
        //}


        ///// <summary>
        ///// 功能：判断是否存在某一条件的记录
        ///// </summary>
        ///// <param name="strCondition">条件串</param>
        ///// <returns>如果存在就返回TRUE，否则返回FALSE</returns>
        //private bool clsQxUsers_IsExistCondRec(string strCondition)
        //{

        //    if (clsCommDBFunctionWS.IsExistRecord("Users", strCondition))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        private System.Data.DataTable clsQxViewPotence_GetViewPotence(string strCondition)
        {
            string strSQL;

            //strSQL = "Select * from ViewPotence where " + strCondition;

            DataTable objDT = clsQxViewPotenceWS.GetDataTableWs(strCondition);
            return objDT;
        }

        /// <summary>
        /// 功能：获取当前表中满足条件的记录数
        /// </summary>
        /// <param name="strCondtion">所给定的记录条件</param>
        /// <returns>记录数，为整型</returns>
        //public int clsQxUsers_funGetRecCountByCond(string strCondtion)
        //{

        //    int intRecCount = clsCommDBFunctionWS.funGetRecCountByCond("Users", strCondtion);
        //    return intRecCount;
        //}

        private string GetQxUserMenuHTML(string strCurrPrjId, string strCurrUserRoleId, string strUserId)
        {

            System.Data.DataTable objDTUpMenu = null, objDTSubMenu = null;

            ///操作步骤：
            ///1、从SESSION取出当前的用户ID(在每个界面上添加一个用户ID的属性，免除每次都必须操作SESSION)。
            ///2、从用户表得出当前用户的角色ID。	
            ///3、从Web.Config取出当前的工程ID			
            ///4、根据用户ID到<用户菜单信息表>中获取<是否用角色菜单>，
            ///   若为TRUE，则根据<角色ID>从<角色菜单表>和<工程菜单表>获取当前<用户ID>的菜单，
            ///       并且按OrderNum排序；
            ///   否则就到<用户菜单详细信息表>和<工程菜单表>获取当前用户的菜单列表。
            ///   获取的表作为DATATABLE(objDT)返回。					
            ///5、根据获取的用户菜单列表，组织成HTML菜单串。						
            ///6、把菜单HTML菜单串显示到界面上。						
            ///7、结束。


            List<String> arrList = new List<String>();
            //			clsQxPrjMenusEx objPrjMenuEx = new clsQxPrjMenusEx();
            StringBuilder strCondition = new StringBuilder();
            StringBuilder strHtml = new StringBuilder();		//需要插入的HTML代码
            StringBuilder strMenuSubItem = new StringBuilder();
            string strMenuId, strUpMenuId;
            int intMainMenuRow, intSubMenuRow;
            string strMainMenuName, strSubMenuName, strLinkFile, strMainImgFile, strSubImgFile;
            bool bolIsUseRoleMenu;		//判断当前用户是否用角色菜单。

            ///操作步骤CODE实现：

            ///4、根据用户ID到<用户菜单信息表>中获取<是否用角色菜单>，
            ///   若为TRUE，则根据<角色ID>从<角色菜单表>和<工程菜单表>获取当前<用户ID>的菜单，
            ///       并且按OrderNum排序；
            ///   否则就到<用户菜单详细信息表>和<工程菜单表>获取当前用户的菜单列表。
            ///   获取的表作为DATATABLE(objDT)返回。	
            ///   

            string strTemp = "true";

            arrList = clsQxUserMenus_funGetFldValue("IsUseRoleMenu", "UserId = '" + strUserId + "'");

            if (arrList.Count != 0)
            {
                strTemp = arrList[0].ToString();
            }

            bolIsUseRoleMenu = bool.Parse(strTemp);

            if (bolIsUseRoleMenu == true)		//如果使用角色菜单，即用户本身没有自定义菜单。
            {
                ///获取顶层菜单
                objDTUpMenu = clsQxRoleMenusEx_GetUpMenuTable(strCurrUserRoleId, strCurrPrjId);
                ///获取子菜单
                objDTSubMenu = clsQxRoleMenusEx_GetSubMenuTable(strCurrUserRoleId, strCurrPrjId);
            }
            else
            {
                return "";
            }
            ///5、根据获取的用户菜单列表，组织成HTML菜单串。						
            intMainMenuRow = 1;
            foreach (DataRow MainMenuRow in objDTUpMenu.Rows)
            {
                strMenuId = MainMenuRow["MenuId"].ToString();	//获取主菜单项ID
                strMainMenuName = MainMenuRow["MenuName"].ToString(); //获取主菜单项NAME
                strMainImgFile = MainMenuRow["ImgFile"].ToString();
                strHtml.Append("<DIV align=\"left\" class=\"style1\">");
                strHtml.AppendFormat("<TABLE width='94%' border='0' cellPadding='0' cellSpacing='0' borderColor='#2953c0' ID='Table{0}' class=\"style1\" >\n",
                    intMainMenuRow);
                strHtml.Append("<TBODY>\n");
                strHtml.Append("<TR>\n");
                strHtml.Append("<TD width='100%' align='left'>\n");
                strHtml.AppendFormat("<A title='单击展开！' onclick='showthis(\"menu{0}\");'>\n",
                    intMainMenuRow);
                strHtml.AppendFormat("&nbsp;<img src='{1}' width='12' height='12'>{0}\n",
                    strMainMenuName, strMainImgFile);
                strHtml.Append("</A>\n");
                strHtml.Append("</TD>\n");
                strHtml.Append("</TR>\n");
                strHtml.Append("</TBODY>\n");
                //				div1.Attributes.Add("class","style1");
                strHtml.Append("</TABLE>\n");
                strHtml.Append("</DIV>");
                strHtml.AppendFormat("<table width=\"100%\" border=\"0\" id=\"menu{0}\" class=\"style2\" style=\"DISPLAY:none\">\n",
                    intMainMenuRow);
                intSubMenuRow = 1;
                foreach (DataRow SubMenuRow in objDTSubMenu.Rows)
                {
                    strUpMenuId = SubMenuRow["UpMenuId"].ToString();

                    if (strMenuId == strUpMenuId)
                    {
                        strSubMenuName = SubMenuRow["MenuName"].ToString(); //获取主菜单项NAME
                        strSubImgFile = SubMenuRow["ImgFile"].ToString();
                        strLinkFile = SubMenuRow["LinkFile"].ToString();
                        string qsParameters = SubMenuRow["qsParameters"].ToString();
                        if (string.IsNullOrEmpty(qsParameters) == false)
                        {
                            if (strLinkFile.IndexOf("?") > 1)
                            {
                                strLinkFile += "&" + qsParameters;
                            }
                            else
                            {
                                strLinkFile += "?" + qsParameters;
                            }
                        }
                        strHtml.Append("<tr>\n");
                        strHtml.Append("	<td align=\"left\">\n");
                        strHtml.AppendFormat("	&nbsp;&nbsp;<img src=\"{0}\" width=\"12\" height=\"12\" border=\"0\">\n",
                            strSubImgFile);
                        strHtml.AppendFormat("<A href=\"{0}\" target=\"main\">{1}</A>\n",
                            strLinkFile, strSubMenuName);
                        strHtml.Append("</td>\n");
                        strHtml.Append("</tr>\n");
                    }

                    intSubMenuRow++;
                }
                strHtml.Append("</table>\n");
                intMainMenuRow++;
            }

            ///6、把菜单HTML菜单串显示到界面上。						
            return strHtml.ToString();
        }

        /// <summary>
        /// 获取用户菜单的HTML代码
        /// </summary>
        /// <param name="strCurrPrjId"></param>
        /// <param name="strCurrUserRoleId"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public string GetQxUserMenuHTML2(string strCurrPrjId, string strCurrUserRoleId, string strUserId)
        {

            //System.Data.DataTable objDTUpMenu = null, objDTSubMenu = null;
            List<clsvQxRoleMenusEN> arrUpMenu = null, arrSubMenu = null;
            ///操作步骤：
            ///1、从SESSION取出当前的用户ID(在每个界面上添加一个用户ID的属性，免除每次都必须操作SESSION)。
            ///2、从用户表得出当前用户的角色ID。	
            ///3、从Web.Config取出当前的工程ID			
            ///4、根据用户ID到<用户菜单信息表>中获取<是否用角色菜单>，
            ///   若为TRUE，则根据<角色ID>从<角色菜单表>和<工程菜单表>获取当前<用户ID>的菜单，
            ///       并且按OrderNum排序；
            ///   否则就到<用户菜单详细信息表>和<工程菜单表>获取当前用户的菜单列表。
            ///   获取的表作为DATATABLE(objDT)返回。					
            ///5、根据获取的用户菜单列表，组织成HTML菜单串。						
            ///6、把菜单HTML菜单串显示到界面上。						
            ///7、结束。

            StringBuilder strCondition = new StringBuilder();
            StringBuilder strHtml = new StringBuilder();		//需要插入的HTML代码
            StringBuilder strMenuSubItem = new StringBuilder();
            int intMainMenuRow;
            bool bolIsUseRoleMenu;		//判断当前用户是否用角色菜单。

            ///操作步骤CODE实现：

            ///4、根据用户ID到<用户菜单信息表>中获取<是否用角色菜单>，
            ///   若为TRUE，则根据<角色ID>从<角色菜单表>和<工程菜单表>获取当前<用户ID>的菜单，
            ///       并且按OrderNum排序；
            ///   否则就到<用户菜单详细信息表>和<工程菜单表>获取当前用户的菜单列表。
            ///   获取的表作为DATATABLE(objDT)返回。	
            ///   

            //string strTemp = "true";

           
            List<clsQxUserMenusEN> arr = clsQxUserMenusWS.GetObjLst("UserId = '" + strUserId + "'");
            clsQxUserMenusEN objUserMenus = null;
            if (arr.Count == 0)
            {
                //StringBuilder sbMessage = new StringBuilder();
                //sbMessage.AppendFormat("当前用户:{0} 没有设置用户菜单! ", strUserId);
                //throw new Exception(sbMessage.ToString());
                bolIsUseRoleMenu = true;
            }
            else
            {
                clsQxUserMenusEN objUserMenus1 = arr[0] as clsQxUserMenusEN;
                bolIsUseRoleMenu = objUserMenus.IsUseRoleMenu;
            }

            if (bolIsUseRoleMenu == true)		//如果使用角色菜单，即用户本身没有自定义菜单。
            {
                ///获取顶层菜单
                ///
                strCondition = new StringBuilder();
                strCondition.AppendFormat("RoleId = '{0}'", strCurrUserRoleId);
                strCondition.AppendFormat(" and QxPrjId = '{0}'", strCurrPrjId);
                strCondition.Append(" AND UpMenuId = '00000000'");
                strCondition.Append(" order by OrderNum");
                arrUpMenu = clsvQxRoleMenusWS.GetObjLst(strCondition.ToString());
                ///获取子菜单
                strCondition = new StringBuilder();
                strCondition.AppendFormat("RoleId = '{0}'", strCurrUserRoleId);
                strCondition.AppendFormat(" and QxPrjId = '{0}'", strCurrPrjId);
                strCondition.Append(" AND UpMenuId <> '00000000'");
                strCondition.Append(" order by OrderNum");

                arrSubMenu = clsvQxRoleMenusWS.GetObjLst(strCondition.ToString());
            }
            else
            {
                return "";
            }
            ///5、根据获取的用户菜单列表，组织成HTML菜单串。						
            intMainMenuRow = 1;
            foreach (clsvQxRoleMenusEN objMainMenuRow in arrUpMenu)
            {
                if (objMainMenuRow.InUse == false) continue;
                strHtml.Append("<DIV align=\"left\" class=\"style1\">");
                strHtml.AppendFormat("<TABLE width='94%' border='0' cellPadding='0' cellSpacing='0' borderColor='#2953c0' ID='Table{0}' class=\"style1\" >\n",
                    intMainMenuRow);
                strHtml.Append("<TBODY>\n");
                strHtml.Append("<TR>\n");
                strHtml.Append("<TD width='100%' align='left'>\n");
                strHtml.AppendFormat("<A title='单击展开！' onclick='showthis(\"menu{0}\");'>\n",
                    intMainMenuRow);
                strHtml.AppendFormat("&nbsp;<img src='{1}' width='12' height='12'>{0}\n",
                    objMainMenuRow.MenuName, objMainMenuRow.ImgFile);
                strHtml.Append("</A>\n");
                strHtml.Append("</TD>\n");
                strHtml.Append("</TR>\n");
                strHtml.Append("</TBODY>\n");
                //				div1.Attributes.Add("class","style1");
                strHtml.Append("</TABLE>\n");
                strHtml.Append("</DIV>");
                strHtml.AppendFormat("<table width=\"100%\" border=\"0\" id=\"menu{0}\" class=\"style2\" style=\"DISPLAY:none\">\n",
intMainMenuRow);

                BindSubMenu(arrSubMenu, objMainMenuRow.MenuId, ref strHtml, intMainMenuRow);

                strHtml.Append("</table>\n");


                intMainMenuRow++;
            }

            ///6、把菜单HTML菜单串显示到界面上。						
            return strHtml.ToString();
        }
        private void BindSubMenu(List<clsvQxRoleMenusEN> arrSubMenu, string strUpMenuId, ref StringBuilder strHtml, int intMainMenuRow)
        {
            int intSubMenuRow = 0;
            foreach (clsvQxRoleMenusEN objSubMenuRow in arrSubMenu)
            {
                if (objSubMenuRow.InUse == false) continue;
                if (strUpMenuId != objSubMenuRow.UpMenuId) continue;
                intSubMenuRow++;
                if (objSubMenuRow.IsLeafNode == true) //叶子结点
                {
                    strHtml.Append("<tr>\n");
                    strHtml.Append("	<td align=\"left\">\n");
                    strHtml.AppendFormat("	&nbsp;&nbsp;<img src=\"{0}\" width=\"12\" height=\"12\" border=\"0\">\n",
                        objSubMenuRow.ImgFile);
                    strHtml.AppendFormat("<A href=\"{0}\" target=\"mainform\">{1}</A>\n",
                       objSubMenuRow.LinkFile, objSubMenuRow.MenuName);
                    strHtml.Append("</td>\n");
                    strHtml.Append("</tr>\n");
                }
                else//非叶子结点
                {
                    strHtml.Append("<tr>\n");
                    strHtml.Append("	<td align=\"left\">\n");
                    strHtml.AppendFormat("<a title='单击展开！' onclick='showthis(\"menu{0}{1}\");'>&nbsp;",
                        intMainMenuRow.ToString("00"), intSubMenuRow.ToString("00"));
                    strHtml.AppendFormat("	&nbsp;&nbsp;<img src=\"{0}\" width=\"12\" height=\"12\" border=\"0\">\n",
                        objSubMenuRow.ImgFile);
                    strHtml.AppendFormat("{0}</A>\n",
                       objSubMenuRow.MenuName);
                    strHtml.Append("</td>\n");
                    strHtml.Append("</tr>\n");

                    strHtml.Append("<tr>");
                    strHtml.Append("<td align=\"left\">");
                    strHtml.AppendFormat("<table width=\"100%\" border=\"0\" id=\"menu{0}{1}\" class=\"style2\" style=\"DISPLAY:none\">\n",
                intMainMenuRow.ToString("00"), intSubMenuRow.ToString("00"));

                    int intLeafMenuRow = 0;
                    foreach (clsvQxRoleMenusEN objLeafMenuRow in arrSubMenu)
                    {
                        if (objLeafMenuRow.UpMenuId != objSubMenuRow.MenuId) continue;
                        if (objLeafMenuRow.IsLeafNode == false) continue; //叶子结点

                        intLeafMenuRow++;

                        strHtml.Append("<tr>\n");
                        strHtml.Append("	<td align=\"left\">\n");
                        strHtml.AppendFormat("&nbsp;&nbsp;	&nbsp;&nbsp;<img src=\"{0}\" width=\"12\" height=\"12\" border=\"0\">\n",
                            objLeafMenuRow.ImgFile);
                        strHtml.AppendFormat("<A href=\"{0}\" target=\"mainform\">{1}</A>\n",
                           objLeafMenuRow.LinkFile, objLeafMenuRow.MenuName);
                        strHtml.Append("</td>\n");
                        strHtml.Append("</tr>\n");

                    } // foreach (clsvQxRoleMenus objLeafMenuRow in arrSubMenu)
                    strHtml.Append("</table>\n");
                    strHtml.Append("</td>");
                    strHtml.Append("</tr>");

                }//非叶子结点
            } //foreach (clsvQxRoleMenus objSubMenuRow in arrSubMenu)
        }

        public clsQxUsersEN GetNewUserObj(string strUserId)
        {
            clsQxUsersEN objUsers = new clsQxUsersEN();
            objUsers.UserId = strUserId;
            clsQxUsersWS.GetQxUsersWs(ref objUsers);
            return objUsers;
        }
        /// <summary>
        /// 获取系统的角色列表
        /// </summary>
        /// <param name=clsQxProjectsEN.con_QxPrjId>项目编号</param>
        /// <returns>数据表</returns>
        private DataTable Get_QxRolesOfPrj(string strPrjId)
        {
            string strSQL = " QxPrjId='" + strPrjId + "'";

            DataTable objDT = clsQxUserRolesWS.GetDataTableWs(strSQL.ToString());

            return objDT;

        }

        /// <summary>
        /// 获取系统的角色对象列表
        /// </summary>
        /// <param name=clsQxProjectsEN.con_QxPrjId>项目编号</param>
        /// <returns>数据表</returns>
        public List<clsQxUserRolesEN> Get_QxRoleObjListOfPrj(string strPrjId)
        {
            List<clsQxUserRolesEN> arrLst = clsQxUserRolesWS.GetObjLst("QxPrjId='" + strPrjId + "'");
            return arrLst;

        }

        /// <summary>
        /// 获取系统的角色用户关系对象列表
        /// </summary>
        /// <param name=clsQxProjectsEN.con_QxPrjId>项目编号</param>
        /// <returns>数据表</returns>
        public List<clsQxUserRoleRelationEN> Get_QxRoleUserRelationObjListOfPrj(string strPrjId)
        {
            List<clsQxUserRoleRelationEN> arrLst = clsQxUserRoleRelationWS.GetObjLst("QxPrjId='" + strPrjId + "'");
            return arrLst;

        }

        /// <summary>
        /// 获取系统的用户对象列表
        /// </summary>
        /// <param name=clsQxProjectsEN.con_QxPrjId>项目编号</param>
        /// <returns>对象列表</returns>
        public List<clsQxUsersEN> Get_QxUserObjListOfPrj(string strPrjId)
        {
            List<clsQxUsersEN> arrLst = clsQxUsersWS.GetObjLst(" userid in (select userid from prjUserRelation where QxPrjId='" + strPrjId + "')");
            return arrLst;
        }

        /// <summary>
        /// 获取系统的用户对象列表
        /// </summary>
        /// <param name=clsQxProjectsEN.con_QxPrjId>项目编号</param>
        /// <returns>对象列表</returns>
        public System.Data.DataTable Get_QxUserDataTableOfPrj(string strPrjId)
        {
            string strSQL = " userid in (select userid from prjUserRelation where QxPrjId='" + strPrjId + "')";
            DataTable objDT = clsQxUsersWS.GetDataTableVWs(strSQL.ToString());

            return objDT;

        }

        /// <summary>
        /// 获取所有部门的对象列表
        /// </summary>
        /// <returns>对象列表</returns>
        public List<clsQxDepartmentInfoEN> Get_DepartMentObjList()
        {
            List<clsQxDepartmentInfoEN> arrLst = clsQxDepartmentInfoWS.GetObjLst("1=1");
            return arrLst;

        }


        /// <summary>
        /// 获取用户状态对象列表
        /// </summary>
        /// <returns>对象列表</returns>
        public List<clsQxUserStateEN> Get_QxUserStateObjList()
        {
            List<clsQxUserStateEN> arrLst = clsQxUserStateWS.GetObjLst("1=1");
            return arrLst;

        }
        /// <summary>
        /// 获取所有部门的对象列表
        /// </summary>
        /// <returns>对象列表</returns>
        public System.Data.DataTable Get_DepartMentDataTable()
        {
            System.Data.DataTable objDT = clsQxDepartmentInfoWS.GetDataTableWs("1=1");
            return objDT;

        }

        private void LogError(Exception objException)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {

                strLogMsg = "An error occurred in the following module: "
                    + mstrModuleName + "\nSource: " + objException.Source

                    + "Message: " + objException.Message + "\n"
                    + "Stack Trace:  " + objException.StackTrace

                    + "Target Site:  " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(mstrModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }



        #endregion


    }
}

