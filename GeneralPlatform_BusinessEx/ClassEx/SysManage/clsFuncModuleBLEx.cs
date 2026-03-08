
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFuncModuleBLEx
表名:FuncModule(00140104)
生成代码版本:2020.05.27.2
生成日期:2020/05/28 01:06:15
生成者:
生成服务器IP:192.168.1.10
工程名称:统一平台
工程ID:0014
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:系统管理
模块英文名:SysManage
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
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
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;


using GeneralPlatform.Entity;
using System.Data;
using System.Data.SqlClient;
using GeneralPlatform.DAL;
using GeneralPlatform.BusinessLogic;


namespace GeneralPlatform.BusinessLogicEx
{
    public static class clsFuncModuleBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objFuncModuleENS">源对象</param>
        /// <returns>目标对象=>clsFuncModuleEN:objFuncModuleENT</returns>
        public static clsFuncModuleENEx CopyToEx(this clsFuncModuleEN objFuncModuleENS)
        {
            try
            {
                clsFuncModuleENEx objFuncModuleENT = new clsFuncModuleENEx();
                clsFuncModuleBL.FuncModuleDA.CopyTo(objFuncModuleENS, objFuncModuleENT);
                return objFuncModuleENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objFuncModuleENS">源对象</param>
        /// <returns>目标对象=>clsFuncModuleEN:objFuncModuleENT</returns>
        public static clsFuncModuleEN CopyTo(this clsFuncModuleENEx objFuncModuleENS)
        {
            try
            {
                clsFuncModuleEN objFuncModuleENT = new clsFuncModuleEN();
                clsFuncModuleBL.CopyTo(objFuncModuleENS, objFuncModuleENT);
                return objFuncModuleENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 功能模块(FuncModule)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsFuncModuleBLEx : clsFuncModuleBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsFuncModuleDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsFuncModuleDAEx FuncModuleDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsFuncModuleDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objFuncModuleENS">源对象</param>
        /// <returns>目标对象=>clsFuncModuleEN:objFuncModuleENT</returns>
        public static clsFuncModuleENEx CopyToEx(clsFuncModuleEN objFuncModuleENS)
        {
            try
            {
                clsFuncModuleENEx objFuncModuleENT = new clsFuncModuleENEx();
                clsFuncModuleBL.FuncModuleDA.CopyTo(objFuncModuleENS, objFuncModuleENT);
                return objFuncModuleENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
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
        public static List<clsFuncModuleENEx> GetObjExLst(string strCondition)
        {
            List<clsFuncModuleEN> arrObjLst = clsFuncModuleBL.GetObjLst(strCondition);
            List<clsFuncModuleENEx> arrObjExLst = new List<clsFuncModuleENEx>();
            foreach (clsFuncModuleEN objInFor in arrObjLst)
            {
                clsFuncModuleENEx objFuncModuleENEx = new clsFuncModuleENEx();
                clsFuncModuleBL.CopyTo(objInFor, objFuncModuleENEx);
                arrObjExLst.Add(objFuncModuleENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strFuncModuleId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsFuncModuleENEx GetObjExByFuncModuleId(string strFuncModuleId)
        {
            clsFuncModuleEN objFuncModuleEN = clsFuncModuleBL.GetObjByFuncModuleId(strFuncModuleId);
            clsFuncModuleENEx objFuncModuleENEx = new clsFuncModuleENEx();
            clsFuncModuleBL.CopyTo(objFuncModuleEN, objFuncModuleENEx);
            return objFuncModuleENEx;
        }

        //public static bool ChangeVisibleFuncModule(string strFuncModuleId)
        //{
        //    clsFuncModuleEN objFuncModuleEN = new clsFuncModuleEN(strFuncModuleId);
        //    clsFuncModuleBL.GetFuncModule(ref objFuncModuleEN);
        //    if (objFuncModuleEN.IsVisible == true)
        //    {
        //        objFuncModuleEN.IsVisible = false;
        //    }
        //    else
        //    {
        //        objFuncModuleEN.IsVisible = true;
        //    }
        //    objFuncModuleEN.ModifyDate = clsDateTime_Db.GetDataBaseDateTime14();
        //    objFuncModuleEN.ModifyUser = clsSysParaEN.strUserId;
        //    return clsFuncModuleBL.UpdateBySql2(objFuncModuleEN);

        //}

        public static bool GoTop(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsFuncModuleDAEx().GoTop(arrKeyId);
                bolResult = ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }
        //public static bool GoTop(List<string> arrKeyId, string strid_Stu, string strStuTypeName, int intScrTermSeq)
        //{
        //    try
        //    {

        //        bool bolResult = new clsFuncModuleDAEx().GoTop(arrKeyId);
        //        bolResult = new clsFuncModuleDAEx().ReOrder(strid_Stu, strStuTypeName, intScrTermSeq);

        //        return bolResult;
        //    }
        //    catch (Exception objException)
        //    {
        //        throw new Exception("置顶出错！\r\n" + objException.Message);
        //    }
        //}
        //public static bool GoTop(string strKeyId, string strid_Stu, string strStuTypeName, int intScrTermSeq)
        //{
        //    try
        //    {
        //        List<string> arrKeyId = new List<string>();
        //        arrKeyId.Add(strKeyId);
        //        bool bolResult = new clsFuncModuleDAEx().GoTop(arrKeyId);
        //        bolResult = new clsFuncModuleDAEx().ReOrder();

        //        return bolResult;
        //    }
        //    catch (Exception objException)
        //    {
        //        throw new Exception("置顶出错！\r\n" + objException.Message);
        //    }
        //}
        //public static bool GoBottom(List<string> arrKeyId)
        //{
        //    try
        //    {
        //        bool bolResult = new clsFuncModuleDAEx().GoBottom(arrKeyId);
        //        return bolResult;
        //    }
        //    catch (Exception objException)
        //    {
        //        throw new Exception("置底出错！\r\n" + objException.Message);
        //    }
        //}
        //public static bool GoBottom(string strKeyId)
        //{
        //    try
        //    {
        //        List<string> arrKeyId = new List<string>();
        //        arrKeyId.Add(strKeyId);
        //        bool bolResult = new clsFuncModuleDAEx().GoBottom(arrKeyId);
        //        bolResult = new clsFuncModuleDAEx().ReOrder();
        //        return bolResult;
        //    }
        //    catch (Exception objException)
        //    {
        //        throw new Exception("置底出错！\r\n" + objException.Message);
        //    }
        //}

        public static bool GoBottom(List<string> arrKeyId)
        {
            try
            {

                bool bolResult = new clsFuncModuleDAEx().GoBottom(arrKeyId);
                bolResult = new clsFuncModuleDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }

        public static bool AdjustSequenceNumber(string strDirect, string strFuncModuleId)
        {
            try
            {
                bool bolResult = new clsFuncModuleDAEx().AdjustSequenceNumber(strDirect, strFuncModuleId);
                bolResult = ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错！\r\n" + objException.Message);
            }
        }
        public static bool ReOrder()
        {
            try
            {
                bool bolResult = new clsFuncModuleDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错！\r\n" + objException.Message);
            }

        }

    }
}