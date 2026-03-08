
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxRolePotenceV2BLEx
表名:QxRolePotenceV2(00140117)
* 版本:2023.05.10.1(服务器:WIN-SRV103-116)
日期:2023/05/14 00:35:13
生成者:pyf
生成服务器IP:
工程名称:统一平台(0014)
CM工程:统一平台Web(变量首字母不限定)-全部函数集
相关数据库:103.116.76.183,9433GeneralPlatformTz
PrjDataBaseId:0218
模块中文名:用户权限管理(UserPotenceMan)
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

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_QxRolePotenceV2Ex : RelatedActions_QxRolePotenceV2
    {
        public override bool UpdRelaTabDate(int intRId, int intPId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsQxRolePotenceV2BLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objQxRolePotenceV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxRolePotenceV2EN:objQxRolePotenceV2ENT</returns>
        public static clsQxRolePotenceV2ENEx CopyToEx(this clsQxRolePotenceV2EN objQxRolePotenceV2ENS)
        {
            try
            {
                clsQxRolePotenceV2ENEx objQxRolePotenceV2ENT = new clsQxRolePotenceV2ENEx();
                clsQxRolePotenceV2BL.QxRolePotenceV2DA.CopyTo(objQxRolePotenceV2ENS, objQxRolePotenceV2ENT);
                return objQxRolePotenceV2ENT;
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
        /// <param name = "objQxRolePotenceV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxRolePotenceV2EN:objQxRolePotenceV2ENT</returns>
        public static clsQxRolePotenceV2EN CopyTo(this clsQxRolePotenceV2ENEx objQxRolePotenceV2ENS)
        {
            try
            {
                clsQxRolePotenceV2EN objQxRolePotenceV2ENT = new clsQxRolePotenceV2EN();
                clsQxRolePotenceV2BL.CopyTo(objQxRolePotenceV2ENS, objQxRolePotenceV2ENT);
                return objQxRolePotenceV2ENT;
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
    /// 角色权限关系V2(QxRolePotenceV2)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsQxRolePotenceV2BLEx : clsQxRolePotenceV2BL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxRolePotenceV2DAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxRolePotenceV2DAEx QxRolePotenceV2DAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxRolePotenceV2DAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objQxRolePotenceV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxRolePotenceV2EN:objQxRolePotenceV2ENT</returns>
        public static clsQxRolePotenceV2ENEx CopyToEx(clsQxRolePotenceV2EN objQxRolePotenceV2ENS)
        {
            try
            {
                clsQxRolePotenceV2ENEx objQxRolePotenceV2ENT = new clsQxRolePotenceV2ENEx();
                clsQxRolePotenceV2BL.QxRolePotenceV2DA.CopyTo(objQxRolePotenceV2ENS, objQxRolePotenceV2ENT);
                return objQxRolePotenceV2ENT;
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
        public static List<clsQxRolePotenceV2ENEx> GetObjExLst(string strCondition)
        {
            List<clsQxRolePotenceV2EN> arrObjLst = clsQxRolePotenceV2BL.GetObjLst(strCondition);
            List<clsQxRolePotenceV2ENEx> arrObjExLst = new List<clsQxRolePotenceV2ENEx>();
            foreach (clsQxRolePotenceV2EN objInFor in arrObjLst)
            {
                clsQxRolePotenceV2ENEx objQxRolePotenceV2ENEx = new clsQxRolePotenceV2ENEx();
                clsQxRolePotenceV2BL.CopyTo(objInFor, objQxRolePotenceV2ENEx);
                arrObjExLst.Add(objQxRolePotenceV2ENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "intRId">表关键字</param>
        /// <param name = "intPId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQxRolePotenceV2ENEx GetObjExByKeyLst(int intRId, int intPId)
        {
            clsQxRolePotenceV2EN objQxRolePotenceV2EN = clsQxRolePotenceV2BL.GetObjByKeyLst(intRId, intPId);
            clsQxRolePotenceV2ENEx objQxRolePotenceV2ENEx = new clsQxRolePotenceV2ENEx();
            clsQxRolePotenceV2BL.CopyTo(objQxRolePotenceV2EN, objQxRolePotenceV2ENEx);
            return objQxRolePotenceV2ENEx;
        }

        /// <summary>
        /// 获取当前角色的顶层菜单列表，以DATATABLE的形式返回
        /// </summary>
        /// <param name="strCondtion"></param>
        /// <returns>以DATATABLE形式表示的顶层菜单列表</returns>
        public static List<string> GetPotenceNameLstByRIds(List<int> arrRId, string strQxPrjId)
        {
            var arrQxRolePotenceV2 = clsQxRolePotenceV2BL.GetObjLstCache(strQxPrjId);
            var arrPId = arrQxRolePotenceV2.Where(x => arrRId.Contains(x.RId) == true)
                .Select(x => x.PId);
            var arrQxPrjPotenceV2 = clsQxPrjPotenceV2BL.GetObjLstCache(strQxPrjId);
            var arrPotenceName = arrQxPrjPotenceV2.Where(x => arrPId.Contains(x.PId)).Select(x=>x.PotenceName).ToList();
            return arrPotenceName;

        }
    }
}