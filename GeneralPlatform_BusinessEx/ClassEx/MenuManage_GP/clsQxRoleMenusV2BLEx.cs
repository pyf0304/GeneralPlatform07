
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxRoleMenusV2BLEx
表名:QxRoleMenusV2(00140114)
* 版本:2023.05.10.1(服务器:WIN-SRV103-116)
日期:2023/05/14 01:45:31
生成者:pyf
生成服务器IP:
工程名称:统一平台(0014)
CM工程:统一平台Web(变量首字母不限定)-全部函数集
相关数据库:103.116.76.183,9433GeneralPlatformTz
PrjDataBaseId:0218
模块中文名:菜单管理(MenuManage)
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
using SpecData;
using com.taishsoft.datetime;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_QxRoleMenusV2Ex : RelatedActions_QxRoleMenusV2
    {
        public override bool UpdRelaTabDate(int intRId, int intMeId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsQxRoleMenusV2BLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objQxRoleMenusV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxRoleMenusV2EN:objQxRoleMenusV2ENT</returns>
        public static clsQxRoleMenusV2ENEx CopyToEx(this clsQxRoleMenusV2EN objQxRoleMenusV2ENS)
        {
            try
            {
                clsQxRoleMenusV2ENEx objQxRoleMenusV2ENT = new clsQxRoleMenusV2ENEx();
                clsQxRoleMenusV2BL.QxRoleMenusV2DA.CopyTo(objQxRoleMenusV2ENS, objQxRoleMenusV2ENT);
                return objQxRoleMenusV2ENT;
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
        /// <param name = "objQxRoleMenusV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxRoleMenusV2EN:objQxRoleMenusV2ENT</returns>
        public static clsQxRoleMenusV2EN CopyTo(this clsQxRoleMenusV2ENEx objQxRoleMenusV2ENS)
        {
            try
            {
                clsQxRoleMenusV2EN objQxRoleMenusV2ENT = new clsQxRoleMenusV2EN();
                clsQxRoleMenusV2BL.CopyTo(objQxRoleMenusV2ENS, objQxRoleMenusV2ENT);
                return objQxRoleMenusV2ENT;
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
    /// 角色菜单V2(QxRoleMenusV2)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsQxRoleMenusV2BLEx : clsQxRoleMenusV2BL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxRoleMenusV2DAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxRoleMenusV2DAEx QxRoleMenusV2DAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxRoleMenusV2DAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objQxRoleMenusV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxRoleMenusV2EN:objQxRoleMenusV2ENT</returns>
        public static clsQxRoleMenusV2ENEx CopyToEx(clsQxRoleMenusV2EN objQxRoleMenusV2ENS)
        {
            try
            {
                clsQxRoleMenusV2ENEx objQxRoleMenusV2ENT = new clsQxRoleMenusV2ENEx();
                clsQxRoleMenusV2BL.QxRoleMenusV2DA.CopyTo(objQxRoleMenusV2ENS, objQxRoleMenusV2ENT);
                return objQxRoleMenusV2ENT;
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
        public static List<clsQxRoleMenusV2ENEx> GetObjExLst(string strCondition)
        {
            List<clsQxRoleMenusV2EN> arrObjLst = clsQxRoleMenusV2BL.GetObjLst(strCondition);
            List<clsQxRoleMenusV2ENEx> arrObjExLst = new List<clsQxRoleMenusV2ENEx>();
            foreach (clsQxRoleMenusV2EN objInFor in arrObjLst)
            {
                clsQxRoleMenusV2ENEx objQxRoleMenusV2ENEx = new clsQxRoleMenusV2ENEx();
                clsQxRoleMenusV2BL.CopyTo(objInFor, objQxRoleMenusV2ENEx);
                arrObjExLst.Add(objQxRoleMenusV2ENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "intRId">表关键字</param>
        /// <param name = "intMeId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQxRoleMenusV2ENEx GetObjExByKeyLst(int intRId, int intMeId)
        {
            clsQxRoleMenusV2EN objQxRoleMenusV2EN = clsQxRoleMenusV2BL.GetObjByKeyLst(intRId, intMeId);
            clsQxRoleMenusV2ENEx objQxRoleMenusV2ENEx = new clsQxRoleMenusV2ENEx();
            clsQxRoleMenusV2BL.CopyTo(objQxRoleMenusV2EN, objQxRoleMenusV2ENEx);
            return objQxRoleMenusV2ENEx;
        }
        /// <summary>
        /// 获取当前角色的顶层菜单列表，以DATATABLE的形式返回
        /// </summary>
        /// <param name="strCondtion"></param>
        /// <returns>以DATATABLE形式表示的顶层菜单列表</returns>
        public static List<clsQxPrjMenusV2EN> GetObjLstByRIds(List<int> arrRId, string strQxPrjId)
        {
            var arrQxRoleMenusV2 = clsQxRoleMenusV2BL.GetObjLstCache(strQxPrjId);
            var arrMeId = arrQxRoleMenusV2.Where(x => arrRId.Contains(x.RId) == true)
                .Select(x => x.MeId);
            var arrQxPrjMenuV2 = clsQxPrjMenusV2BL.GetObjLstCache(strQxPrjId);
            var arrQxPrjMenuV2_Sel = arrQxPrjMenuV2.Where(x => arrMeId.Contains(x.id)).ToList();
            return arrQxPrjMenuV2_Sel;

        }

        public static bool CreateRoleMenus(string strPrjId, string strPrjMenuSetId)
        {
            string strCondition = $"{conQxPrjMenusV2.QxPrjId}='{strPrjId}' and {conQxPrjMenusV2.MenuSetId}='{strPrjMenuSetId}'";
            var arrQxPrjMenus = clsQxPrjMenusV2BL.GetObjLst(strCondition);
            foreach (var objInfo in arrQxPrjMenus)
            {

                clsQxRoleMenusV2EN objQxRoleMenusV2EN = new clsQxRoleMenusV2EN();
                
                objQxRoleMenusV2EN.RId = 1;
                objQxRoleMenusV2EN.MeId= objInfo.id;
                objQxRoleMenusV2EN.QxPrjId = objInfo.QxPrjId;
                objQxRoleMenusV2EN.IsDisp = true; 
                objQxRoleMenusV2EN.UpdUserId = "pyf";
                objQxRoleMenusV2EN.Memo = objInfo.Memo;
                objQxRoleMenusV2EN.UpdDate = clsDateTime.getTodayDateTimeStr(0);

                clsQxRoleMenusV2BL.CheckPropertyNew(objQxRoleMenusV2EN);
                var strCondition_Uni = $"{conQxRoleMenusV2.RId}={objQxRoleMenusV2EN.RId} and {conQxRoleMenusV2.MeId}={objQxRoleMenusV2EN.MeId}";
                if (clsQxRoleMenusV2BL.IsExistRecord(strCondition_Uni) == true)
                {
                    objQxRoleMenusV2EN.Update();
                }
                else
                {
                    clsQxRoleMenusV2BL.AddNewRecordBySql2(objQxRoleMenusV2EN);
                }
            }
            return true;
        }

    }
}