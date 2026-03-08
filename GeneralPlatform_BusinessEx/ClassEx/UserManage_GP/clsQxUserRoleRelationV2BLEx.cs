
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUserRoleRelationV2BLEx
表名:QxUserRoleRelationV2(00140113)
* 版本:2023.05.10.1(服务器:WIN-SRV103-116)
日期:2023/05/14 00:45:35
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
    public class RelatedActions_QxUserRoleRelationV2Ex : RelatedActions_QxUserRoleRelationV2
    {
        public override bool UpdRelaTabDate(int intUId, int intRId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsQxUserRoleRelationV2BLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objQxUserRoleRelationV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxUserRoleRelationV2EN:objQxUserRoleRelationV2ENT</returns>
        public static clsQxUserRoleRelationV2ENEx CopyToEx(this clsQxUserRoleRelationV2EN objQxUserRoleRelationV2ENS)
        {
            try
            {
                clsQxUserRoleRelationV2ENEx objQxUserRoleRelationV2ENT = new clsQxUserRoleRelationV2ENEx();
                clsQxUserRoleRelationV2BL.QxUserRoleRelationV2DA.CopyTo(objQxUserRoleRelationV2ENS, objQxUserRoleRelationV2ENT);
                return objQxUserRoleRelationV2ENT;
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
        /// <param name = "objQxUserRoleRelationV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxUserRoleRelationV2EN:objQxUserRoleRelationV2ENT</returns>
        public static clsQxUserRoleRelationV2EN CopyTo(this clsQxUserRoleRelationV2ENEx objQxUserRoleRelationV2ENS)
        {
            try
            {
                clsQxUserRoleRelationV2EN objQxUserRoleRelationV2ENT = new clsQxUserRoleRelationV2EN();
                clsQxUserRoleRelationV2BL.CopyTo(objQxUserRoleRelationV2ENS, objQxUserRoleRelationV2ENT);
                return objQxUserRoleRelationV2ENT;
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
    /// 用户角色关系V2(QxUserRoleRelationV2)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsQxUserRoleRelationV2BLEx : clsQxUserRoleRelationV2BL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxUserRoleRelationV2DAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxUserRoleRelationV2DAEx QxUserRoleRelationV2DAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxUserRoleRelationV2DAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objQxUserRoleRelationV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxUserRoleRelationV2EN:objQxUserRoleRelationV2ENT</returns>
        public static clsQxUserRoleRelationV2ENEx CopyToEx(clsQxUserRoleRelationV2EN objQxUserRoleRelationV2ENS)
        {
            try
            {
                clsQxUserRoleRelationV2ENEx objQxUserRoleRelationV2ENT = new clsQxUserRoleRelationV2ENEx();
                clsQxUserRoleRelationV2BL.QxUserRoleRelationV2DA.CopyTo(objQxUserRoleRelationV2ENS, objQxUserRoleRelationV2ENT);
                return objQxUserRoleRelationV2ENT;
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
        public static List<clsQxUserRoleRelationV2ENEx> GetObjExLst(string strCondition)
        {
            List<clsQxUserRoleRelationV2EN> arrObjLst = clsQxUserRoleRelationV2BL.GetObjLst(strCondition);
            List<clsQxUserRoleRelationV2ENEx> arrObjExLst = new List<clsQxUserRoleRelationV2ENEx>();
            foreach (clsQxUserRoleRelationV2EN objInFor in arrObjLst)
            {
                clsQxUserRoleRelationV2ENEx objQxUserRoleRelationV2ENEx = new clsQxUserRoleRelationV2ENEx();
                clsQxUserRoleRelationV2BL.CopyTo(objInFor, objQxUserRoleRelationV2ENEx);
                arrObjExLst.Add(objQxUserRoleRelationV2ENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "intUId">表关键字</param>
        /// <param name = "intRId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQxUserRoleRelationV2ENEx GetObjExByKeyLst(int intUId, int intRId)
        {
            clsQxUserRoleRelationV2EN objQxUserRoleRelationV2EN = clsQxUserRoleRelationV2BL.GetObjByKeyLst(intUId, intRId);
            clsQxUserRoleRelationV2ENEx objQxUserRoleRelationV2ENEx = new clsQxUserRoleRelationV2ENEx();
            clsQxUserRoleRelationV2BL.CopyTo(objQxUserRoleRelationV2EN, objQxUserRoleRelationV2ENEx);
            return objQxUserRoleRelationV2ENEx;
        }

        public static List<int> GetRIdLstByUserName(string strUserName)
        {
            int intUId = clsQxUsersV2BLEx.GetUIdLstByUserName(strUserName);
            string strCondition = string.Format("{0}='{1}'", conQxUserRoleRelationV2.UId, intUId);
            List<string> arr = clsQxUserRoleRelationV2BL.GetFldValue(conQxUserRoleRelationV2.RId, strCondition);
            List<int> arrRId = arr.Select(x => int.Parse(x) ).ToList();
            return arrRId;
        }
    }
}