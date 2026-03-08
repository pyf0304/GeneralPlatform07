using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using GeneralPlatform;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Webform;
using System.Collections.Generic;
using com.taishsoft.common;
using com.taishsoft.json;
using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.WebSrv
{
    /// <summary>
    /// LoginService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class LoginService : System.Web.Services.WebService
    {

        
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strUserPassword">口令</param>
        /// <returns>成功返回True，不成功返回False</returns>
        [WebMethod]
        public bool UserLogin(string strLoginName, string strUserPassword)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strLoginName", strLoginName);
            dictParam.Add("strUserPassword", "已经隐藏");
            clsPubFun.Log4Debug(this, strFunctionName, dictParam);

            string strUserId = clsQxUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);
            clsQxUsersEN objUsers = new clsQxUsersEN(strUserId);
            clsQxUsersBL.GetQxUsers(ref objUsers);
            if (objUsers == null)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return false;
            }
            if (objUsers.Password != strUserPassword)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return false;
            }
            return true;

        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strUserPassword">口令</param>
        /// <returns>成功返回True，不成功返回False</returns>
        [WebMethod]
        public string UserLogin2(string strLoginName, string strUserPassword)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strLoginName", strLoginName);
            dictParam.Add("strUserPassword", "已经隐藏");
            clsPubFun.Log4Debug(this, strFunctionName, dictParam);

            string strUserId = clsQxUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);
            clsQxUsersEN objUsers = null;
            try
            {
                objUsers = new clsQxUsersEN(strUserId);
                clsQxUsersBL.GetQxUsers(ref objUsers);
            }
            catch (Exception objException)
            {
                return objException.Message;
            }
            if (objUsers == null)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return "false";
            }
            if (objUsers.Password != strUserPassword)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return "false";
            }
            return "true";

        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strUserPassword">口令</param>
        /// <param name="strEffectiveDate">有效日期</param>
        /// <returns>成功返回"true"，不成功返回"false", 超过有效期返回"EffectiveDateError"</returns>
        [WebMethod]
        public string UserLoginWithEffectiveDate(string strLoginName, string strUserPassword, string strEffectiveDate)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strLoginName", strLoginName);
            dictParam.Add("strUserPassword", "已经隐藏");
            dictParam.Add("strEffectiveDate", strEffectiveDate);
            clsPubFun.Log4Debug(this, strFunctionName, dictParam);

            string strUserId = clsQxUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);
            clsQxUsersEN objUsers = null;
            try
            {
                objUsers = new clsQxUsersEN(strUserId);
                clsQxUsersBL.GetQxUsers(ref objUsers);
            }
            catch (Exception objException)
            {
                return objException.Message;
            }
            if (objUsers == null)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return "false";
            }
            if (objUsers.Password != strUserPassword)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return "false";
            }
            if (string.IsNullOrEmpty(objUsers.EffectiveDate) == true) return "true";
            if (objUsers.EffectiveDate.CompareTo(strEffectiveDate) < 0)
            {
                return "EffectiveDateError";
            }
            return "true";

        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="strUserId">用户ID</param>
        /// <param name="strUserPassword">口令</param>
        /// <returns>成功返回True，不成功返回False</returns>
        [WebMethod]
        public bool UserLoginByPrjId(string strLoginName, string strUserPassword, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strLoginName", strLoginName);
            dictParam.Add("strUserPassword", "已经隐藏");
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun.Log4Debug(this, strFunctionName, dictParam);

            string strUserId = clsQxUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);
            clsQxUsersEN objUsers = new clsQxUsersEN(strUserId);
            clsQxUsersBL.GetQxUsers(ref objUsers);

            string strCondition = string.Format("UserId='{0}' And {2}='{1}'", strUserId, strPrjId,
                conQxPrjUserRelation.QxPrjId);
            if (clsQxPrjUserRelationBL.IsExistRecord(strCondition) == false)
            {
                return false;
            }
            if (objUsers == null)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return false;
            }
            if (objUsers.Password != strUserPassword)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return false;
            }
            return true;

        }

        /// <summary>
        /// 根据用户名、口令、工程id，进行登录，最终获取用户关系视图对象列表
        /// </summary>
        /// <param name="strLoginName">登录名</param>
        /// <param name="strUserPassword">口令</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>获取用户关系视图对象列表，或不成功则返回空的对象列表</returns>
        [WebMethod]
        public List<clsvQxUserRoleRelationEN> GetvQxUserRoleRelationObjLstByUserLoginByPrjId(string strLoginName, string strUserPassword, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strLoginName", strLoginName);
            dictParam.Add("strUserPassword", "已经隐藏");
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun.Log4Debug(this, strFunctionName, dictParam);

            string strUserId = clsQxUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);
            clsQxUsersEN objUsers = new clsQxUsersEN(strUserId);
            clsQxUsersBL.GetQxUsers(ref objUsers);

            string strCondition = string.Format("UserId='{0}' And {2}='{1}'", strUserId, strPrjId,
                conQxPrjUserRelation.QxPrjId);
            if (clsQxPrjUserRelationBL.IsExistRecord(strCondition) == false)
            {
                return new List<clsvQxUserRoleRelationEN>();
            }
            if (objUsers == null)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return new List<clsvQxUserRoleRelationEN>();
            }
            if (objUsers.Password != strUserPassword)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return new List<clsvQxUserRoleRelationEN>();
            }
            strCondition = string.Format(" {0}='{1}' And {2}='{3}'",
                conQxUserRoleRelation.QxPrjId, strPrjId,
                conQxUserRoleRelation.UserId, strUserId);
            List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLst = clsvQxUserRoleRelationBL.GetObjLst(strCondition);
            return arrvQxUserRoleRelationObjLst;

        }

        /// <summary>
        /// 根据用户名、口令、工程id，进行登录，最终获取用户关系视图JSON对象列表
        /// </summary>
        /// <param name="strLoginName">登录名</param>
        /// <param name="strUserPassword">口令</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>获取用户关系视图JSON对象列表，或不成功则返回空的对象列表</returns>
        [WebMethod]
        public string GetvUserRoleRelationJSONObjLstByUserLoginByPrjId(string strLoginName, string strUserPassword, string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strLoginName", strLoginName);
            dictParam.Add("strUserPassword", "已经隐藏");
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun.Log4Debug(this, strFunctionName, dictParam);

            string strUserId = clsQxUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);
            clsQxUsersEN objUsers = new clsQxUsersEN(strUserId);
            clsQxUsersBL.GetQxUsers(ref objUsers);

            string strCondition = string.Format("UserId='{0}' And {2}='{1}'", strUserId, strPrjId,
                conQxPrjUserRelation.QxPrjId);
            if (clsQxPrjUserRelationBL.IsExistRecord(strCondition) == false)
            {
                return "";
            }
            if (objUsers == null)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return "";
            }
            if (objUsers.Password != strUserPassword)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return "";
            }
            strCondition = string.Format(" {0}='{1}' And {2}='{3}'",
                conQxUserRoleRelation.QxPrjId, strPrjId,
                conQxUserRoleRelation.UserId, strUserId);
            List<clsvQxUserRoleRelationEN> arrvQxUserRoleRelationObjLst = clsvQxUserRoleRelationBL.GetObjLst(strCondition);

            //List<clsvQxUserRoleRelationEN_Sim> arrvQxUserRoleRelationObj_SimLst = clsvQxUserRoleRelationBL.GetSimObjLstFromObjLst(arrvQxUserRoleRelationObjLst);
            string strJSON = clsJSON.GetJsonFromObjLst(arrvQxUserRoleRelationObjLst);
            return strJSON; 

        }

        /// <summary>
        /// 根据用户登录名获取用户Id
        /// </summary>
        /// <param name="strLoginName">用户登录名</param>        
        /// <returns>返回strUserId</returns>
        [WebMethod]
        public string GetUserIdByLoginName(string strLoginName)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strLoginName", strLoginName);
         
            clsPubFun.Log4Debug(this, strFunctionName, dictParam);

            string strUserId = clsQxUserLoginNameBLEx.GetUserIdByLoginName(strLoginName);

            return strUserId;

        }
    }
}
