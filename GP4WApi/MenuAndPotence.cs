using com.taishsoft.common;
using com.taishsoft.datetime;
using GeneralPlatform.Entity;
using GP4WApi;


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

namespace GeneralPlatform4WApi
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
        public static string Get_UserStateId(string strUserId)
        {

            if (clsQxUsersWApi.IsExist(strUserId))
            {
                clsQxUsersEN objUsersEN = clsQxUsersWApi.GetObjByUserId(strUserId);

                string strUserStateId = objUsersEN.UserStateId;
                return strUserStateId;

            }
            else
            {
                return "0";

            }
        }
        /// <summary>
        /// 获取用户角色关系表
        /// </summary>
        /// <param name="strUserId">帐号</param>
        /// <param name="strUserPrjId">项目号</param>
        /// <returns>数据表</returns>
        private static List<clsvQxUserRoleRelationEN> GetObjLstByJoinUsersV(string strUserId, string strUserPrjId)
        {
            StringBuilder sb = new StringBuilder("");

            sb.AppendFormat(" UserId = '{0}'", strUserId);
            sb.AppendFormat(" and QxPrjId = '{0}'", strUserPrjId);

            List<clsvQxUserRoleRelationEN> objObjLst = clsvQxUserRoleRelationWApi.GetObjLst(sb.ToString());

            return objObjLst;

        }

        /// <summary>
        /// 获取该帐户在本系统中的角色列表，其中包含列：用户号 UserId ，姓名UserName， 角色号RoleId ，角色名称Role
        /// </summary>
        /// <param name="strUserId">用户号</param>
        /// <returns>数据表，其中包含列：用户号 UserId ，姓名UserName， 角色号RoleId ，角色名称Role </returns>
        public List<clsQxRolesEN> Get_QxUserRoleObjList(string strPrjId, string strUserId)
        {
            List<clsQxRolesEN> arrObjList = new List<clsQxRolesEN>();


            List<clsvQxUserRoleRelationEN> objObjLst = GetObjLstByJoinUsersV(strUserId, strPrjId);

            foreach (clsvQxUserRoleRelationEN objInFor in objObjLst)
            {
                clsQxRolesEN objUserRoles = new clsQxRolesEN();
                objUserRoles.RoleId = objInFor.RoleId;     //角色Id
                objUserRoles.RoleName = objInFor.RoleName;     //角色名称
                objUserRoles.QxPrjId = objInFor.QxPrjId;     //项目编号
                objUserRoles.Memo = objInFor.Memo;     //备注
                arrObjList.Add(objUserRoles);
            }
            return arrObjList;

        }
        /// <summary>
        /// 获取该帐户在本系统中的角色号RoleId 列表，
        /// </summary>
        /// <param name="strUserId">用户号</param>
        /// <returns>角色号RoleId 的列表 </returns>
        public static List<string> Get_RoleIdList(string strPrjId, string strUserId)
        {
            List<string> arrRoleIdList = new List<string>();
            DataTable objDT = new DataTable();

            List<clsvQxUserRoleRelationEN> objObjLst = GetObjLstByJoinUsersV(strUserId, strPrjId);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrRoleIdList;
            }
            foreach (clsvQxUserRoleRelationEN objInFor in objObjLst)
            {

                arrRoleIdList.Add(objInFor.RoleId);
            }
            objDT = null;
            return arrRoleIdList;

        }
        /// <summary>
        /// 获取该帐户在本系统中的角色号RoleId 列表，
        /// </summary>
        /// <param name="strUserId">用户号</param>
        /// <returns>角色号RoleId 的列表 </returns>
        public static List<string> Get_RoleIdList2(string strPrjId, string strUserId)
        {
            List<string> arrRoleIdList = new List<string>();
            DataTable objDT = new DataTable();

            List<clsvQxUserRoleRelationEN> objObjLst = GetObjLstByJoinUsersV(strUserId, strPrjId);

            foreach (clsvQxUserRoleRelationEN objInFor in objObjLst)
            {

                arrRoleIdList.Add(objInFor.RoleId);
            }
            objDT = null;
            return arrRoleIdList;

        }
        public static string GetQxRoleNameByRoleId(string strRoleId)
        {
            clsQxRolesEN objUserRoles = clsQxRolesWApi.GetObjByRoleId(strRoleId);
            if (objUserRoles == null)
            {
                return "";
            }
            return objUserRoles.RoleName;
        }

        /// <summary>
        /// 通过条件获取用户组权限
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        private static List<clsQxUserGroupPotenceEN> clsQxUserGroupPotence_GetQxUserGroupPotence(string strCondition)
        {

            List<clsQxUserGroupPotenceEN> objObjLst = clsQxUserGroupPotenceWApi.GetObjLst(strCondition);

            return objObjLst;

        }



        /// <summary>
        /// 获取角色权限列表
        /// </summary>
        /// <param name="strRoleId"></param>
        public static List<string> Get_QxUserRolePotence(string strRoleId, string strPrjId)
        {
            List<string> lstPotenceArr = new List<string>();
            List<clsQxUserGroupPotenceEN> objObjLst = clsQxUserGroupPotence_GetQxUserGroupPotence(" RoleId='" + strRoleId + "' and QxPrjId='" + strPrjId + "'");
            foreach (clsQxUserGroupPotenceEN objInFor in objObjLst)
            {
                string strTemp = objInFor.PotenceId;
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
        /// 获取角色权限列表
        /// </summary>
        /// <param name="strRoleId"></param>
        public static List<string> Get_PotenceByRoleId(string strRoleId)
        {
            List<string> lstPotenceArr = new List<string>();
            List<clsQxUserGroupPotenceEN> objObjLst = clsQxUserGroupPotence_GetQxUserGroupPotence(" RoleId='" + strRoleId + "'");
            foreach (clsQxUserGroupPotenceEN objInFor in objObjLst)
            {
                string strTemp = objInFor.PotenceId;
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
        /// 修改当前用户的系统口令
        /// </summary>
        /// <param name="strCurrUserId">当前用户</param>
        /// <param name="strOldPassword">用户当前的密码，用以验证</param>
        /// <param name="strNewPassword">用户需要修改的新密码</param>
        /// <returns>修改成功，返回true，失败返回false</returns>
        public static bool Change_CurrentUserPassword(string strCurrUserId, string strOldPassword, string strNewPassword)
        {
            clsQxUsersEN objUsersEN = clsQxUsersWApi.GetObjByUserId(strCurrUserId);
            if (objUsersEN == null)
            {
                string strMsg = string.Format("用户:{0}的不存在，请检查！", strCurrUserId);
                throw new Exception(strMsg);
            }
            if (objUsersEN.Password == strOldPassword)
            {
                objUsersEN.Password = strNewPassword;
                objUsersEN.UpdDate = clsDateTime.getTodayStr(0);
                clsQxUsersWApi.UpdateRecord(objUsersEN);
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
        public static bool Change_UserPassword(string strCurrUserId, string strUserId, string strUserNewPassword, string strCurrentUserPassword)
        {
            clsQxUsersEN objUsersEN = clsQxUsersWApi.GetObjByUserId(strCurrUserId);
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
                    clsQxUsersWApi.UpdateRecord(objUsersEN);
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
        public static bool Check_Login(string requestUserId, string requestUserStateId, string requestRoleId)
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
        public static bool IsExistUserId(string strUserId)
        {
            return clsQxUsersWApi.IsExist(strUserId);
        }
        public static string Get_UserPassword(string strUserId)
        {
            clsQxUsersEN objUsers = clsQxUsersWApi.GetObjByUserId(strUserId);
            return objUsers.Password;
        }



        /// <summary>
        /// 添加一个用户帐号,并设置角色
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        public static void Add_UserAndRoleIntoUsersForCurrPrj(string UserId, string UserName, string Password, string RoleId, string strPrjId)
        {

            AddaUserIntoUsers(UserId, UserName, Password);

            AddRoleIdForUser(UserId, RoleId, strPrjId);

        }


        /// <summary>
        /// 为帐号删除一个角色
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="RoleId"></param>
        public static void Delete_RoleForUser(string UserId, string RoleId, string strPrjId)
        {
            DelRoleIdForUser(UserId, RoleId, strPrjId);

        }


        /// <summary>
        /// 删除当前工程的一个用户帐号，只有当前用户帐号所有工程中均没有角色时，才能删除
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strResult"></param>
        public int DeleteUser(string strUserId, ref string strResult)
        {
            if (clsQxUserRoleRelationWApi.IsExistRecord("UserId = '" + strUserId + "'") == true)
            {
                strResult = "当前用户还存在角色，请该用户的角色删除后才能删除该用户!";
                return 0;
            }
            return clsQxUsersWApi.DelRecord(strUserId);

        }



        /// <summary>
        /// 为帐号添加一个当前项目中的角色
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="RoleId"></param>
        public static void Add_RoleForUser(string UserId, string RoleId, string strPrjId)
        {
            AddRoleIdForUser(UserId, RoleId, strPrjId);

        }


        #endregion


        /// <summary>
        /// 添加一个用户帐号
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strUserName"></param>
        /// <param name="strPassword"></param>
        /// <returns></returns>
        private static bool AddaUserIntoUsers(string strUserId, string strUserName, string strPassword)
        {
            clsQxUsersEN objUsers = new clsQxUsersEN();
            objUsers.UserId = strUserId;
            objUsers.UserName = strUserName;
            objUsers.Password = strPassword;
            objUsers.UserStateId = "01";
            return clsQxUsersWApi.AddNewRecord(objUsers);

        }
        private static bool IsExistRoleIdForPrj(string strRoleId, string strPrjId)
        {

            if (clsQxRolesWApi.IsExistRecord("RoleId=" + "'" + strRoleId + "' and QxPrjId='" + strPrjId + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// 为帐户增加一个角色
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strRoleId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        private static bool AddRoleIdForUser(string strUserId, string strRoleId, string strPrjId)
        {

            if (IsExistRoleIdForPrj(strRoleId, strPrjId))
            {
                DelRoleIdForUser(strUserId, strRoleId, strPrjId);
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

                if (clsQxPrjUserRelationWApi.IsExistRecord(sbCondition.ToString()) == false)
                {
                    clsQxPrjUserRelationWApi.AddNewRecord(objPrjUserRelation);
                }
                return clsQxUserRoleRelationWApi.AddNewRecord(objUsers);
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
        private static int DelRoleIdForUser(string strUserId, string strRoleId, string strPrjId)
        {
            string strSQL = string.Format(" UserId = '{0}' and RoleId = '{1}' and QxPrjId = '{2}'", strUserId, strRoleId, strPrjId);
            return clsQxUserRoleRelationWApi.DelQxUserRoleRelationsByCond(strSQL.ToString());
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
            return clsQxUserRoleRelationWApi.DelQxUserRoleRelationsByCond(strSQL.ToString());




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
            clsQxUsersEN objUsers = clsQxUsersWApi.GetObjByUserId(strUserId);
            return objUsers;
        }


        /// <summary>
        /// 获取系统的角色对象列表
        /// </summary>
        /// <param name=clsQxProjectsEN.con_QxPrjId>项目编号</param>
        /// <returns>数据表</returns>
        public List<clsQxRolesEN> Get_QxRoleObjListOfPrj(string strPrjId)
        {
            List<clsQxRolesEN> arrLst = clsQxRolesWApi.GetObjLst("QxPrjId='" + strPrjId + "'");
            return arrLst;

        }

        /// <summary>
        /// 获取系统的角色用户关系对象列表
        /// </summary>
        /// <param name=clsQxProjectsEN.con_QxPrjId>项目编号</param>
        /// <returns>数据表</returns>
        public List<clsQxUserRoleRelationEN> Get_QxRoleUserRelationObjListOfPrj(string strPrjId)
        {
            List<clsQxUserRoleRelationEN> arrLst = clsQxUserRoleRelationWApi.GetObjLst("QxPrjId='" + strPrjId + "'");
            return arrLst;

        }

        /// <summary>
        /// 获取系统的用户对象列表
        /// </summary>
        /// <param name=clsQxProjectsEN.con_QxPrjId>项目编号</param>
        /// <returns>对象列表</returns>
        public List<clsQxUsersEN> Get_QxUserObjListOfPrj(string strPrjId)
        {
            List<clsQxUsersEN> arrLst = clsQxUsersWApi.GetObjLst(" userid in (select userid from prjUserRelation where QxPrjId='" + strPrjId + "')");
            return arrLst;
        }


        /// <summary>
        /// 获取所有部门的对象列表
        /// </summary>
        /// <returns>对象列表</returns>
        public List<clsQxDepartmentInfoEN> Get_DepartMentObjList()
        {
            List<clsQxDepartmentInfoEN> arrLst = clsQxDepartmentInfoWApi.GetObjLst("1=1");
            return arrLst;

        }


        /// <summary>
        /// 获取用户状态对象列表
        /// </summary>
        /// <returns>对象列表</returns>
        public List<clsQxUserStateEN> Get_QxUserStateObjList()
        {
            List<clsQxUserStateEN> arrLst = clsQxUserStateWApi.GetObjLst("1=1");
            return arrLst;

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


    }
}

