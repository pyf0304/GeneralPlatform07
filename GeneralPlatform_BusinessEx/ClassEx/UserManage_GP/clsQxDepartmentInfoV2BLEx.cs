
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxDepartmentInfoV2BLEx
表名:QxDepartmentInfoV2(00140111)
* 版本:2023.05.10.1(服务器:PYF-THINKPAD)
日期:2023/05/23 16:55:11
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

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_QxDepartmentInfoV2Ex : RelatedActions_QxDepartmentInfoV2
    {
        public override bool UpdRelaTabDate(int intDepartmentIdInt, string strOpUser)
        {
            return true;
        }
    }
    public static class clsQxDepartmentInfoV2BLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objQxDepartmentInfoV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxDepartmentInfoV2EN:objQxDepartmentInfoV2ENT</returns>
        public static clsQxDepartmentInfoV2ENEx CopyToEx(this clsQxDepartmentInfoV2EN objQxDepartmentInfoV2ENS)
        {
            try
            {
                clsQxDepartmentInfoV2ENEx objQxDepartmentInfoV2ENT = new clsQxDepartmentInfoV2ENEx();
                clsQxDepartmentInfoV2BL.QxDepartmentInfoV2DA.CopyTo(objQxDepartmentInfoV2ENS, objQxDepartmentInfoV2ENT);
                return objQxDepartmentInfoV2ENT;
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
        /// <param name = "objQxDepartmentInfoV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxDepartmentInfoV2EN:objQxDepartmentInfoV2ENT</returns>
        public static clsQxDepartmentInfoV2EN CopyTo(this clsQxDepartmentInfoV2ENEx objQxDepartmentInfoV2ENS)
        {
            try
            {
                clsQxDepartmentInfoV2EN objQxDepartmentInfoV2ENT = new clsQxDepartmentInfoV2EN();
                clsQxDepartmentInfoV2BL.CopyTo(objQxDepartmentInfoV2ENS, objQxDepartmentInfoV2ENT);
                return objQxDepartmentInfoV2ENT;
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
    /// 部门V2(QxDepartmentInfoV2)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsQxDepartmentInfoV2BLEx : clsQxDepartmentInfoV2BL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxDepartmentInfoV2DAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxDepartmentInfoV2DAEx QxDepartmentInfoV2DAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxDepartmentInfoV2DAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objQxDepartmentInfoV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxDepartmentInfoV2EN:objQxDepartmentInfoV2ENT</returns>
        public static clsQxDepartmentInfoV2ENEx CopyToEx(clsQxDepartmentInfoV2EN objQxDepartmentInfoV2ENS)
        {
            try
            {
                clsQxDepartmentInfoV2ENEx objQxDepartmentInfoV2ENT = new clsQxDepartmentInfoV2ENEx();
                clsQxDepartmentInfoV2BL.QxDepartmentInfoV2DA.CopyTo(objQxDepartmentInfoV2ENS, objQxDepartmentInfoV2ENT);
                return objQxDepartmentInfoV2ENT;
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
        public static List<clsQxDepartmentInfoV2ENEx> GetObjExLst(string strCondition)
        {
            List<clsQxDepartmentInfoV2EN> arrObjLst = clsQxDepartmentInfoV2BL.GetObjLst(strCondition);
            List<clsQxDepartmentInfoV2ENEx> arrObjExLst = new List<clsQxDepartmentInfoV2ENEx>();
            foreach (clsQxDepartmentInfoV2EN objInFor in arrObjLst)
            {
                clsQxDepartmentInfoV2ENEx objQxDepartmentInfoV2ENEx = new clsQxDepartmentInfoV2ENEx();
                clsQxDepartmentInfoV2BL.CopyTo(objInFor, objQxDepartmentInfoV2ENEx);
                arrObjExLst.Add(objQxDepartmentInfoV2ENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "intDepartmentIdInt">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQxDepartmentInfoV2ENEx GetObjExByDepartmentIdInt(int intDepartmentIdInt)
        {
            clsQxDepartmentInfoV2EN objQxDepartmentInfoV2EN = clsQxDepartmentInfoV2BL.GetObjByDepartmentIdInt(intDepartmentIdInt);
            clsQxDepartmentInfoV2ENEx objQxDepartmentInfoV2ENEx = new clsQxDepartmentInfoV2ENEx();
            clsQxDepartmentInfoV2BL.CopyTo(objQxDepartmentInfoV2EN, objQxDepartmentInfoV2ENEx);
            return objQxDepartmentInfoV2ENEx;
        }
    }
}