
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxRolePotenceRelaBLEx
表名:QxRolePotenceRela(00140123)
* 版本:2024.01.20.1(服务器:WIN-SRV103-116)
日期:2024/01/20 22:41:15
生成者:pyf
生成服务器IP:
工程名称:统一平台(0014)
CM工程:统一平台Web(变量首字母不限定)-全部函数集
相关数据库:103.116.76.183,9433GeneralPlatformTz
PrjDataBaseId:0218
模块中文名:用户管理(UserManage_GP)
框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
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
    /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_QxRolePotenceRelaEx : RelatedActions_QxRolePotenceRela
    {
        public override bool UpdRelaTabDate(string strRoleId, string strPotenceId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsQxRolePotenceRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objQxRolePotenceRelaENS">源对象</param>
        /// <returns>目标对象=>clsQxRolePotenceRelaEN:objQxRolePotenceRelaENT</returns>
        public static clsQxRolePotenceRelaENEx CopyToEx(this clsQxRolePotenceRelaEN objQxRolePotenceRelaENS)
        {
            try
            {
                clsQxRolePotenceRelaENEx objQxRolePotenceRelaENT = new clsQxRolePotenceRelaENEx();
                clsQxRolePotenceRelaBL.QxRolePotenceRelaDA.CopyTo(objQxRolePotenceRelaENS, objQxRolePotenceRelaENT);
                return objQxRolePotenceRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:000)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objQxRolePotenceRelaENS">源对象</param>
        /// <returns>目标对象=>clsQxRolePotenceRelaEN:objQxRolePotenceRelaENT</returns>
        public static clsQxRolePotenceRelaEN CopyTo(this clsQxRolePotenceRelaENEx objQxRolePotenceRelaENS)
        {
            try
            {
                clsQxRolePotenceRelaEN objQxRolePotenceRelaENT = new clsQxRolePotenceRelaEN();
                clsQxRolePotenceRelaBL.CopyTo(objQxRolePotenceRelaENS, objQxRolePotenceRelaENT);
                return objQxRolePotenceRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 角色权限关系(QxRolePotenceRela)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsQxRolePotenceRelaBLEx : clsQxRolePotenceRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxRolePotenceRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式,使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxRolePotenceRelaDAEx QxRolePotenceRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxRolePotenceRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objQxRolePotenceRelaENS">源对象</param>
        /// <returns>目标对象=>clsQxRolePotenceRelaEN:objQxRolePotenceRelaENT</returns>
        public static clsQxRolePotenceRelaENEx CopyToEx(clsQxRolePotenceRelaEN objQxRolePotenceRelaENS)
        {
            try
            {
                clsQxRolePotenceRelaENEx objQxRolePotenceRelaENT = new clsQxRolePotenceRelaENEx();
                clsQxRolePotenceRelaBL.QxRolePotenceRelaDA.CopyTo(objQxRolePotenceRelaENS, objQxRolePotenceRelaENT);
                return objQxRolePotenceRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsQxRolePotenceRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsQxRolePotenceRelaEN> arrObjLst = clsQxRolePotenceRelaBL.GetObjLst(strCondition);
            List<clsQxRolePotenceRelaENEx> arrObjExLst = new List<clsQxRolePotenceRelaENEx>();
            foreach (clsQxRolePotenceRelaEN objInFor in arrObjLst)
            {
                clsQxRolePotenceRelaENEx objQxRolePotenceRelaENEx = new clsQxRolePotenceRelaENEx();
                clsQxRolePotenceRelaBL.CopyTo(objInFor, objQxRolePotenceRelaENEx);
                arrObjExLst.Add(objQxRolePotenceRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strRoleId">表关键字</param>
        /// <param name = "strPotenceId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQxRolePotenceRelaENEx GetObjExByKeyLst(string strRoleId, string strPotenceId)
        {
            clsQxRolePotenceRelaEN objQxRolePotenceRelaEN = clsQxRolePotenceRelaBL.GetObjByKeyLst(strRoleId, strPotenceId);
            clsQxRolePotenceRelaENEx objQxRolePotenceRelaENEx = new clsQxRolePotenceRelaENEx();
            clsQxRolePotenceRelaBL.CopyTo(objQxRolePotenceRelaEN, objQxRolePotenceRelaENEx);
            return objQxRolePotenceRelaENEx;
        }
        public static bool SetRolePotence(string strPrjId, string strRoleId, string strPotenceId, string strOpUserId)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            string strCurrDate14 = clsDateTime.getTodayDateTimeStr(0);
            string strCondition = $" RoleId='{strRoleId}' and PotenceId = '{strPotenceId}' ";
            if (clsQxRolePotenceRelaBL.IsExistRecord(strCondition) == false)
            {
                clsQxRolePotenceRelaEN objQxRolePotenceRela = new clsQxRolePotenceRelaEN();
                objQxRolePotenceRela.QxPrjId = strPrjId;

                objQxRolePotenceRela.RoleId = strRoleId;
                objQxRolePotenceRela.PotenceId = strPotenceId;
                objQxRolePotenceRela.UpdDate = strCurrDate14;
                objQxRolePotenceRela.UpdUser = strOpUserId;
                clsQxRolePotenceRelaBL.AddNewRecordBySql2(objQxRolePotenceRela);
            }

            return true;
        }

        public static bool Delete(string strRoleId,  string strPotenceId)
        {
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
            StringBuilder strCondition = new StringBuilder();
            strCondition.Append($" {conQxRolePotenceRela.RoleId}='{strRoleId}' and {conQxRolePotenceRela.PotenceId} = '{strPotenceId}'");
            if (clsQxRolePotenceRelaBL.DelQxRolePotenceRelasByCond(strCondition.ToString()) > 0) return true;
            return false;
        }

    }
}