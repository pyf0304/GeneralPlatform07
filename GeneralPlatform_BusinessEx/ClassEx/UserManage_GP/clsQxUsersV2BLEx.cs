
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUsersV2BLEx
表名:QxUsersV2(00140110)
* 版本:2023.05.10.1(服务器:WIN-SRV103-116)
日期:2023/05/12 00:18:40
生成者:pyf
生成服务器IP:
工程名称:统一平台(0014)
CM工程:统一平台Web(变量首字母不限定)-全部函数集
相关数据库:103.116.76.183,9433GeneralPlatformTz
PrjDataBaseId:0218
模块中文名:用户管理(UserManage)
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_QxUsersV2Ex : RelatedActions_QxUsersV2
    {
        public override bool UpdRelaTabDate(int intid, string strOpUser)
        {
            return true;
        }
    }
    public static class clsQxUsersV2BLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objQxUsersV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxUsersV2EN:objQxUsersV2ENT</returns>
        public static clsQxUsersV2ENEx CopyToEx(this clsQxUsersV2EN objQxUsersV2ENS)
        {
            try
            {
                clsQxUsersV2ENEx objQxUsersV2ENT = new clsQxUsersV2ENEx();
                clsQxUsersV2BL.QxUsersV2DA.CopyTo(objQxUsersV2ENS, objQxUsersV2ENT);
                return objQxUsersV2ENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objQxUsersV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxUsersV2EN:objQxUsersV2ENT</returns>
        public static clsQxUsersV2EN CopyTo(this clsQxUsersV2ENEx objQxUsersV2ENS)
        {
            try
            {
                clsQxUsersV2EN objQxUsersV2ENT = new clsQxUsersV2EN();
                clsQxUsersV2BL.CopyTo(objQxUsersV2ENS, objQxUsersV2ENT);
                return objQxUsersV2ENT;
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
    /// 用户V2(QxUsersV2)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsQxUsersV2BLEx : clsQxUsersV2BL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxUsersV2DAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxUsersV2DAEx QxUsersV2DAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxUsersV2DAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objQxUsersV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxUsersV2EN:objQxUsersV2ENT</returns>
        public static clsQxUsersV2ENEx CopyToEx(clsQxUsersV2EN objQxUsersV2ENS)
        {
            try
            {
                clsQxUsersV2ENEx objQxUsersV2ENT = new clsQxUsersV2ENEx();
                clsQxUsersV2BL.QxUsersV2DA.CopyTo(objQxUsersV2ENS, objQxUsersV2ENT);
                return objQxUsersV2ENT;
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
        public static List<clsQxUsersV2ENEx> GetObjExLst(string strCondition)
        {
            List<clsQxUsersV2EN> arrObjLst = clsQxUsersV2BL.GetObjLst(strCondition);
            List<clsQxUsersV2ENEx> arrObjExLst = new List<clsQxUsersV2ENEx>();
            foreach (clsQxUsersV2EN objInFor in arrObjLst)
            {
                clsQxUsersV2ENEx objQxUsersV2ENEx = new clsQxUsersV2ENEx();
                clsQxUsersV2BL.CopyTo(objInFor, objQxUsersV2ENEx);
                arrObjExLst.Add(objQxUsersV2ENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "intid">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQxUsersV2ENEx GetObjExByid(int intid)
        {
            clsQxUsersV2EN objQxUsersV2EN = clsQxUsersV2BL.GetObjByid(intid);
            clsQxUsersV2ENEx objQxUsersV2ENEx = new clsQxUsersV2ENEx();
            clsQxUsersV2BL.CopyTo(objQxUsersV2EN, objQxUsersV2ENEx);
            return objQxUsersV2ENEx;
        }
        public static int GetUIdLstByUserName(string strUserName)
        {
            string strCondition = string.Format("{0}='{1}'", conQxUsersV2.UserName, strUserName);
            var objQxUsersV2 = clsQxUsersV2BL.GetFirstObj_S(strCondition);
            if (objQxUsersV2 == null)
            {
                return 0;
            }
            return objQxUsersV2.id;
        }
    }
}