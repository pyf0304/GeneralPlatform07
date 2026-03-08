using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Text;
using System.Collections;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;

namespace GeneralPlatformWS
{
    /// <summary>
    /// UsersServiceEx 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class UsersServiceEx : System.Web.Services.WebService
    {

        
        /// <summary>
        /// 获取用户的所有子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        [WebMethod]
        public ArrayList GetRoleIdLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("PrjId = '{0}'", strPrjId);
            sbCondition.AppendFormat(" and RoleId in (Select RoleId from UserRoleRelation where userid = '{0}')",
                strUserId);
            ArrayList arrUserRoleObjLst = clsUserRolesBL.GetUserRolesObjList(sbCondition.ToString());
            ArrayList arrRoleIdLst = new ArrayList();
            foreach (clsUserRoles objUserRoles in arrUserRoleObjLst)
            {
                arrRoleIdLst.Add(objUserRoles.RoleId);
            }

            return arrRoleIdLst;
        }

        [WebMethod]
        public ArrayList GetRoleNameLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("PrjId = '{0}'", strPrjId);
            sbCondition.AppendFormat(" and RoleId in (Select RoleId from UserRoleRelation where userid = '{0}')",
                strUserId);
            ArrayList arrUserRoleObjLst = clsUserRolesBL.GetUserRolesObjList(sbCondition.ToString());
            ArrayList arrRoleIdLst = new ArrayList();
            foreach (clsUserRoles objUserRoles in arrUserRoleObjLst)
            {
                arrRoleIdLst.Add(objUserRoles.RoleName);
            }

            return arrRoleIdLst;
        }


        /// <summary>
        /// 获取用户的所有子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        [WebMethod]
        public ArrayList GetPotenceIdLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }


            //        select * from prjpotence
            //where prjid = '0072'
            //    and potenceid in 
            //    (select potenceid from userGroupPotence
            //            where RoleId in 
            //                (select RoleId from userRoleRelation where UserId= 'pyf01' and prjid = '0072')
            //    )
            StringBuilder sbCondition4Potence2 = new StringBuilder();
            sbCondition4Potence2.AppendFormat("PrjId = '{0}'", strPrjId);
            sbCondition4Potence2.AppendFormat(" and potenceid in ");
            sbCondition4Potence2.AppendFormat(" (select potenceid from userGroupPotence where RoleId in  ");
            sbCondition4Potence2.AppendFormat("(select RoleId from userRoleRelation where UserId= '{0}' and prjid = '{1}')",
                strUserId, strPrjId);
            sbCondition4Potence2.Append(")");
            ArrayList arrPrjPotenceObjLst = clsPrjPotenceBL.GetPrjPotenceObjList(sbCondition4Potence2.ToString());
            ArrayList arrPotenceIdLst = new ArrayList();
            foreach (clsPrjPotence objPrjPotence in arrPrjPotenceObjLst)
            {
                arrPotenceIdLst.Add(objPrjPotence.PotenceId);
            }

            return arrPotenceIdLst;
        }

        [WebMethod]
        public ArrayList GetPotenceNameLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }


            //        select * from prjpotence
            //where prjid = '0072'
            //    and potenceid in 
            //    (select potenceid from userGroupPotence
            //            where RoleId in 
            //                (select RoleId from userRoleRelation where UserId= 'pyf01' and prjid = '0072')
            //    )
            StringBuilder sbCondition4Potence2 = new StringBuilder();
            sbCondition4Potence2.AppendFormat("PrjId = '{0}'", strPrjId);
            sbCondition4Potence2.AppendFormat(" and potenceid in ");
            sbCondition4Potence2.AppendFormat(" (select potenceid from userGroupPotence where RoleId in  ");
            sbCondition4Potence2.AppendFormat("(select RoleId from userRoleRelation where UserId= '{0}' and prjid = '{1}')",
                strUserId, strPrjId);
            sbCondition4Potence2.Append(")");
            ArrayList arrPrjPotenceObjLst = clsPrjPotenceBL.GetPrjPotenceObjList(sbCondition4Potence2.ToString());
            ArrayList arrPotenceIdLst = new ArrayList();
            foreach (clsPrjPotence objPrjPotence in arrPrjPotenceObjLst)
            {
                arrPotenceIdLst.Add(objPrjPotence.PotenceName);
            }

            return arrPotenceIdLst;
        }

        ///// <summary>
        ///// 获取用户的所有子对象列表
        ///// </summary>
        ///// <param name="strUserId">当前用户</param>
        ///// <param name="strPrjId">当前工程</param>
        ///// <returns>扩展用户对象，包括子对象列表</returns>
        //[WebMethod]
        //public static clsUsersEx GetUsersAllSubObj(string strUserId, string strPrjId)
        //{

        //    if (string.IsNullOrEmpty(strPrjId) == true)
        //    {
        //        strPrjId = clsProjectsBLEx.GetDefaultPrj();
        //    }
        //    GeneralPlatform.Entity.clsUsersEx objUsersEx = new GeneralPlatform.Entity.clsUsersEx();
        //    objUsersEx.UserId = strUserId;
        //    clsUsersBLEx.GetUsers(ref objUsersEx);
        //    StringBuilder sbCondition = new StringBuilder();
        //    sbCondition.AppendFormat("PrjId = '{0}'", strPrjId);
        //    sbCondition.AppendFormat(" and RoleId in (Select RoleId from UserRoleRelation where userid = '{0}')",
        //        objUsersEx.UserId);
        //    objUsersEx.arrUserRoleObjLst = clsUserRolesBLEx.GetUserRolesObjListEx(sbCondition.ToString());
        //    foreach (clsUserRolesEx objUserRoles in objUsersEx.arrUserRoleObjLst)
        //    {
        //        StringBuilder sbCondition4Potence = new StringBuilder();
        //        sbCondition4Potence.AppendFormat("  potenceid in ");
        //        sbCondition4Potence.AppendFormat(" (select potenceid from userGroupPotence where RoleId = '{0}')  ",
        //            objUserRoles.RoleId);
        //        objUserRoles.arrPrjPotenceObjLst = clsPrjPotenceBLEx.GetPrjPotenceObjList(sbCondition4Potence.ToString());
        //    }

        //    //        select * from prjpotence
        //    //where prjid = '0072'
        //    //    and potenceid in 
        //    //    (select potenceid from userGroupPotence
        //    //            where RoleId in 
        //    //                (select RoleId from userRoleRelation where UserId= 'pyf01' and prjid = '0072')
        //    //    )
        //    StringBuilder sbCondition4Potence2 = new StringBuilder();
        //    sbCondition4Potence2.AppendFormat("PrjId = '{0}'", strPrjId);
        //    sbCondition4Potence2.AppendFormat(" and potenceid in ");
        //    sbCondition4Potence2.AppendFormat(" (select potenceid from userGroupPotence where RoleId in  ");
        //    sbCondition4Potence2.AppendFormat("(select RoleId from userRoleRelation where UserId= '{0}' and prjid = '{1}')",
        //        objUsersEx.UserId, strPrjId);
        //    sbCondition4Potence2.Append(")");
        //    objUsersEx.arrPrjPotenceObjLst = clsPrjPotenceBLEx.GetPrjPotenceObjList(sbCondition4Potence2.ToString());


        //    //        select * from RelaOfPotenceAndSymbol
        //    //where prjid = '0072'
        //    //    and RelaMid in 
        //    //    (select RelaMid from userGroupPotence
        //    //            where RoleId in 
        //    //                (select RoleId from userRoleRelation where UserId= 'pyf01' and prjid = '0072')
        //    //    )

        //    StringBuilder sbCondition4Potence3 = new StringBuilder();
        //    sbCondition4Potence3.AppendFormat("PrjId = '{0}'", strPrjId);
        //    sbCondition4Potence3.AppendFormat(" and RelaMid in ");
        //    sbCondition4Potence3.AppendFormat(" (select RelaMid from userGroupPotence where RoleId in  ");
        //    sbCondition4Potence3.AppendFormat("(select RoleId from userRoleRelation where UserId= '{0}' and prjid = '{1}')",
        //        objUsersEx.UserId, strPrjId);
        //    sbCondition4Potence3.Append(")");
        //    objUsersEx.arrPrjPotenceAndSymbolObjLst = clsRelaOfPotenceAndSymbolBL.GetRelaOfPotenceAndSymbolObjList(sbCondition4Potence3.ToString());

        //    return objUsersEx;
        //}

        ///// <summary>
        ///// 获取用户的当前所选角色的所有子对象列表
        ///// </summary>
        ///// <param name="strUserId">当前用户</param>
        ///// <param name="strRoleId">当前角色</param>
        ///// <param name="strPrjId">当前工程</param>
        ///// <returns>扩展用户对象，包括子对象列表</returns>
        //public static bool GetUsersAllSubObj4CurrRole(GeneralPlatform.Entity.clsUsersEx objUsersEx, string strUserId, string strRoleId, string strPrjId)
        //{

        //    if (string.IsNullOrEmpty(strPrjId) == true)
        //    {
        //        strPrjId = clsProjectsBLEx.GetDefaultPrj();
        //    }
        //    objUsersEx.UserId = strUserId;
        //    clsUsersBLEx.GetUsers(ref objUsersEx);
        //    objUsersEx.RoleId = strRoleId;

        //    StringBuilder sbCondition4Potence2 = new StringBuilder();
        //    sbCondition4Potence2.AppendFormat("PrjId = '{0}'", strPrjId);
        //    sbCondition4Potence2.AppendFormat(" and potenceid in ");
        //    sbCondition4Potence2.AppendFormat(" (select potenceid from userGroupPotence where RoleId ='{0}')",
        //        strRoleId);
        //    objUsersEx.arrPrjPotenceObjLst4CurrRole = clsPrjPotenceBLEx.GetPrjPotenceObjList(sbCondition4Potence2.ToString());



        //    StringBuilder sbCondition4Potence3 = new StringBuilder();
        //    sbCondition4Potence3.AppendFormat("PrjId = '{0}'", strPrjId);
        //    sbCondition4Potence3.AppendFormat(" and RelaMid in ");
        //    sbCondition4Potence3.AppendFormat(" (select RelaMid from userGroupPotence where RoleId ='{0}')",
        //         strRoleId);
        //    objUsersEx.arrPrjPotenceAndSymbolObjLst4CurrRole = clsRelaOfPotenceAndSymbolBL.GetRelaOfPotenceAndSymbolObjList(sbCondition4Potence3.ToString());

        //    return true;
        //}

        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [WebMethod]
        public bool IsHavePotenceName(string strPrjId, string strUserId, string strPotenceName)
        {
            return clsUsersBLEx.IsHavePotenceName(strPrjId, strUserId, strPotenceName);
        }
        /// <summary>
        /// 是否包含某权限Id
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [WebMethod]
        public bool IsHavePotenceId(string strPrjId, string strUserId, string strPotenceId)
        {
            return clsUsersBLEx.IsHavePotenceId(strPrjId, strUserId, strPotenceId);
        }
        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [WebMethod]
        public clsPrjPotence GetPrjPotenceObjByPotenceName(string strPrjId, string strUserId, string strPotenceName)
        {
            return clsUsersBLEx.GetPrjPotenceObjByPotenceName(strPrjId, strUserId, strPotenceName);
        }

        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [WebMethod]
        public clsPrjPotence GetPrjPotenceObjByPotenceName4CurrRole(string strPrjId, string strUserId, string strRoleId, string strPotenceName)
        {
            return clsUsersBLEx.GetPrjPotenceObjByPotenceName4CurrRole(strPrjId, strUserId, strRoleId, strPotenceName);
        }
        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [WebMethod]
        public bool IsHavePotenceNameAndSymbol(string strPrjId, string strUserId, string strPotenceName, string strSymbolName)
        {
            return clsUsersBLEx.IsHavePotenceNameAndSymbol(strPrjId, strUserId, strPotenceName, strSymbolName);
        }

        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        [WebMethod]
        public bool IsHavePotenceNameAndSymbol4CurrRole1(string strPrjId, string strUserId, string strRoleId, string strPotenceName, string strSymbolName)
        {
            return clsUsersBLEx.IsHavePotenceNameAndSymbol4CurrRole1(strPrjId, strUserId, strRoleId, strPotenceName, strSymbolName);
        }

    }
}
