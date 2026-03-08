using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferenceUsersEx;
using GeneralPlatform4WS.ServiceReferenceUsers;
using GeneralPlatform4WS.ServiceReferencePrjUserRelation;
using GeneralPlatform4WS.ServiceReferenceUserRoleRelation;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 
    /// </summary>
    public class clsUsersExWS
    {
        public static List<clsUsersEN> arrUsersObjLst = null;
        private static UsersServiceExSoapClient objUsersServiceExSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static UsersServiceExSoapClient GetUsersServiceExSoapClient()
        {
            if (objUsersServiceExSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "UsersServiceExSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);

                //EndpointAddress address = new EndpointAddress("http://202.121.63.10/CalcEngineWS/UsersServiceEx.asmx");

                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/UsersServiceEx.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/UsersServiceEx.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }


                //String strServiceUrl = String.Format("http://{0}/CalcEngineWS/UsersServiceEx.asmx", clsSysPara.strCurrIPAddress);
                EndpointAddress address = new EndpointAddress(strServiceUrl);

                return new UsersServiceExSoapClient(binding, address);
            }
            else
            {
                return objUsersServiceExSoapClient;
            }
        }


        /// <summary>
        /// 获取用户的所有子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<string> GetRoleIdLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
            List<string> arrRoleIdLst = objUsersServiceEx.GetRoleIdLstByUserId(strUserId, strPrjId) as List<string>;
            return arrRoleIdLst;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<string> GetRoleNameLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
            List<string> arrRoleIdLst = objUsersServiceEx.GetRoleNameLstByUserId(strUserId, strPrjId);
            return arrRoleIdLst;

        }


        /// <summary>
        /// 获取用户的所有子对象列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<string> GetPotenceIdLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }

            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
            List<string> arrPotenceIdLst = objUsersServiceEx.GetPotenceIdLstByUserId(strUserId, strPrjId);


            return arrPotenceIdLst;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strUserId"></param>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static List<string> GetPotenceNameLstByUserId(string strUserId, string strPrjId)
        {

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
            List<string> arrPotenceIdLst = objUsersServiceEx.GetPotenceNameLstByUserId(strUserId, strPrjId);

            return arrPotenceIdLst;
        }

        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        public static bool IsHavePotenceName(string strPrjId, string strUserId, string strPotenceName)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
            bool bolIsSuccess = objUsersServiceEx.IsHavePotenceName(strPrjId, strUserId, strPotenceName);
            return bolIsSuccess;

        }
        /// <summary>
        /// 是否包含某权限Id
        /// </summary>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPotenceId">给定的权限ID</param>
        /// <returns>是否包含？</returns>
        public static bool IsHavePotenceId(string strPrjId, string strUserId, string strPotenceId)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
            bool bolIsSuccess = objUsersServiceEx.IsHavePotenceId(strPrjId, strUserId, strPotenceId);
            return bolIsSuccess;

        }
        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        public static clsPrjPotenceEN GetPrjPotenceObjByPotenceName(string strPrjId, string strUserId, string strPotenceName)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
            clsPrjPotenceEN objPrjPotence = objUsersServiceEx.GetPrjPotenceObjByPotenceName(strPrjId, strUserId, strPotenceName);
            return objPrjPotence;
        }

        /// <summary>
        /// 获取当前角色中包含某权限名称的权限对象
        /// </summary>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strRoleId">角色ID</param>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <returns>是否包含？</returns>
        public static clsPrjPotenceEN GetPrjPotenceObjByPotenceName4CurrRole(string strPrjId, string strUserId, string strRoleId, string strPotenceName)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
            return objUsersServiceEx.GetPrjPotenceObjByPotenceName4CurrRole(strPrjId, strUserId, strRoleId, strPotenceName);
        }

       

        /// <summary>
        /// 获取用户的有关某权限的标志ID列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPotenceId">权限ID</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<string> GetSymbolIdLstByPotenceId(string strUserId, string strPotenceId, string strPrjId)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolId = objUsersServiceEx.GetSymbolIdLstByPotenceId(strUserId, strPotenceId, strPrjId);
            return lstSymbolId;
        }
        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPotenceId">权限ID</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        public static List<string> GetSymbolNameLstByPotenceId(string strUserId, string strPotenceId, string strPrjId)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolName = objUsersServiceEx.GetSymbolNameLstByPotenceId(strUserId, strPotenceId, strPrjId);
            return lstSymbolName;
        }

        /// <summary>
        /// 获取用户的有关某权限的标志ID列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPotenceName">权限名称</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<string> GetSymbolIdLstByPotenceName(string strUserId, string strPotenceName, string strPrjId)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolId = objUsersServiceEx.GetSymbolIdLstByPotenceName(strUserId, strPotenceName, strPrjId);
            return lstSymbolId;
        }
        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPotenceName">权限名称</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        public static List<string> GetSymbolNameLstByPotenceName(string strUserId, string strPotenceName, string strPrjId)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolName = objUsersServiceEx.GetSymbolNameLstByPotenceName(strUserId, strPotenceName, strPrjId);
            return lstSymbolName;
        }

        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strPotenceName">权限名称</param>
        /// <param name="strPrjId">当前工程</param>
        /// <param name="strRoleId">当前默认角色</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        public static List<string> GetSymbolNameLstByPotenceName4CurrRoleId(string strUserId, string strPotenceName, string strPrjId, string strRoleId)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();

            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolName = objUsersServiceEx.GetSymbolNameLstByPotenceName4CurrRoleId(strUserId, strPotenceName, strPrjId, strRoleId);
            return lstSymbolName;
        }
        /// <summary>
        /// 获取用户的有关某权限的标志名称列表
        /// </summary>
        /// <param name="strPotenceName">权限名称</param>
        /// <param name="strPrjId">当前工程</param>
        /// <param name="strRoleId">当前默认角色</param>
        /// <returns>标志名称列表,用List<string>表示</returns>
        public static List<string> GetSymbolNameLstByPotenceName4CurrRoleId2(string strPotenceName, string strPrjId, string strRoleId)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
            if (string.IsNullOrEmpty(strPrjId) == true)
            {
                return null;
            }
            List<string> lstSymbolName = objUsersServiceEx.GetSymbolNameLstByPotenceName4CurrRoleId2(strPotenceName, strPrjId, strRoleId);
            return lstSymbolName;
        }


        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <param name="strSymbolName">权限标志</param>
        /// <returns>是否包含？</returns>
        public static bool IsHavePotenceNameAndSymbol(string strPrjId, string strUserId, string strPotenceName, string strSymbolName)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
            bool bolIsSuccess = objUsersServiceEx.IsHavePotenceNameAndSymbol(strPrjId, strUserId, strPotenceName, strSymbolName);
            return bolIsSuccess;

        }

        /// <summary>
        /// 是否包含某权限名称
        /// </summary>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strRoleId">角色ID</param>
        /// <param name="strPotenceName">给定的权限名称</param>
        /// <param name="strSymbolName">权限标志</param>
        /// <returns>是否包含？</returns>
        public static bool IsHavePotenceNameAndSymbol4CurrRole(string strPrjId, string strUserId, string strRoleId, string strPotenceName, string strSymbolName)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
            bool bolIsSuccess = objUsersServiceEx.IsHavePotenceNameAndSymbol4CurrRole(strPrjId, strUserId, strRoleId, strPotenceName, strSymbolName);
            return bolIsSuccess;
        }
        /// <summary>
        /// 修改给定用户的系统口令
        /// </summary>
        /// <param name="strUserId">用户Id</param>
        /// <param name="strOldPassword">用户当前的密码，用以验证</param>
        /// <param name="strNewPassword">用户需要修改的新密码</param>
        /// <returns>修改成功，返回true，失败返回false</returns>
        public bool Change_UserPassword(string strUserId, string strNewPassword, string strOldPassword)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
            bool bolIsSuccess = objUsersServiceEx.Change_UserPassword(strUserId, strNewPassword, strOldPassword);
            return bolIsSuccess;
        }

        /// <summary>
        /// 修改给定用户的系统口令
        /// </summary>
        /// <param name="strUserId">用户Id</param>
        /// <param name="strNewPassword">用户需要修改的新密码</param>
        /// <returns>修改成功，返回true，失败返回false</returns>
        public bool Change_UserPassword(string strUserId, string strNewPassword)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
            bool bolIsSuccess = objUsersServiceEx.Change_UserPassword2(strUserId, strNewPassword);
            return bolIsSuccess;
        }

        /// <summary>
        /// 根据用户Id（UserId）获取入校年月
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>入校年月</returns>
        public static string GetEnterSchoolDateByUserId(string strUserId)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();

            string strEnterSchoolDate = objUsersServiceEx.GetEnterSchoolDateByUserId(strUserId);
            return strEnterSchoolDate;
        }
        /// <summary>
        /// 根据用户Id（UserId）获取入校年
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>入校年</returns>
        public static string GetEnterSchoolYearByUserId(string strUserId)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();

            string strEnterSchoolDate = objUsersServiceEx.GetEnterSchoolYearByUserId(strUserId);
            return strEnterSchoolDate;
        }
        /// <summary>
        /// 根据用户Id（UserId）获取用户名
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <returns>用户名</returns>
        public static string GetUserNameByUserId(string strUserId)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
            string strUserName = objUsersServiceEx.GetUserNameByUserId(strUserId);
            return strUserName;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strUserId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsUsersEN GetUsersObjByUserIdWithObjList(string strUserId)
        {
            if (arrUsersObjLst == null)
            {
                arrUsersObjLst = clsUsersWS.GetUsersObjList("1=1");
            }
            foreach (clsUsersEN objUsers in arrUsersObjLst)
            {
                if (objUsers.UserId == strUserId)
                {
                    return objUsers;
                }
            }
            return null;
        }
        /// <summary>
        /// 添加新的用户
        /// </summary>
        /// <param name="objUsers">用户对象</param>
        /// <param name="strPrjId">工程ID</param>
        /// <param name="strRoleId">角色ID</param>
        /// <returns>是否成功？</returns>
        public static bool AddNewUsers(clsUsersEN objUsers, string strPrjId, string strRoleId)
        {
            ///1、判断用户是否存在，如果存在就退出
            if (clsUsersWS.IsExistWs(objUsers.UserId) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("用户:{0}({1})已经存在,不能再添加！", objUsers.UserId, objUsers.UserName);
                //                throw new Exception("");

            }
            else
            {
                clsUsersWS.AddNewRecordBySql2Ws(objUsers);
            }
            AddPrjUserRelation(objUsers.UserId, strPrjId);
            AddUserRoleRelation(objUsers.UserId, strRoleId);

            return true;
        }
        /// <summary>
        /// 建立工程用户关系
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strPrjId">工程ID</param>
        /// <returns></returns>
        public static bool AddPrjUserRelation(string strUserId, string strPrjId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("PrjId='{0}' and UserId='{1}'", strPrjId, strUserId);
            if (clsPrjUserRelationWS.IsExistRecordWs(sbCondition.ToString()) == false)
            {
                clsPrjUserRelationEN objPrjUserRelation = new clsPrjUserRelationEN();
                objPrjUserRelation.PrjId = strPrjId;
                objPrjUserRelation.UserId = strUserId;
                objPrjUserRelation.Memo = "由WebService同步！";
                clsPrjUserRelationWS.AddNewRecordBySql2Ws(objPrjUserRelation);
            }
            return true;

        }
        /// <summary>
        /// 建立用户角色关系
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strRoleId">工程ID</param>
        /// <returns></returns>
        public static bool AddUserRoleRelation(string strUserId, string strRoleId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("RoleId='{0}' and UserId='{1}'", strRoleId, strUserId);
            if (clsUserRoleRelationWS.IsExistRecordWs(sbCondition.ToString()) == false)
            {
                clsUserRoleRelationEN objUserRoleRelation = new clsUserRoleRelationEN();
                objUserRoleRelation.RoleId = strRoleId;
                objUserRoleRelation.UserId = strUserId;
                objUserRoleRelation.PrjId = strRoleId.Substring(0,4);

                objUserRoleRelation.Memo = "由WebService同步！";
                clsUserRoleRelationWS.AddNewRecordBySql2Ws(objUserRoleRelation);
            }
            return true;

        }

        /// <summary>
        /// 为用户设置角色
        /// </summary>
        /// <param name="strUserId">当前用户</param>
        /// <param name="strRoleId">当前角色</param>
        /// <param name="strPrjId">当前工程</param>
        /// <returns>是否成功？</returns>
        public static bool CreateUserRoleRelation(string strUserId, string strRoleId, string strPrjId)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
            bool bolIsSuccess = objUsersServiceEx.CreateUserRoleRelation(strUserId, strRoleId, strPrjId);
            return bolIsSuccess;
        }
        /// <summary>
        /// 根据部门ID获取该部门的二级管理员ID
        /// </summary>
        /// <param name="strDepartmentId">部门ID</param>
        /// <returns>二级管理员ID？</returns>
    
        public static string GetManager2IdByDepartmentId(string strDepartmentId)
        {
            UsersServiceExSoapClient objUsersServiceEx = GetUsersServiceExSoapClient();
  
            string strUserId = objUsersServiceEx.GetManager2IdByDepartmentId(strDepartmentId);
            return strUserId;
        }
    }
}
