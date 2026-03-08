
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvQxPrjTabBLEx
表名:vQxPrjTab(00140097)
生成代码版本:2019.08.02.1
生成日期:2019/08/05 00:04:18
生成者:
生成服务器IP:101.251.68.133
工程名称:统一平台
工程ID:0014
相关数据库:101.251.68.133,9433GeneralPlatformTz
PrjDataBaseId:0184
模块中文名:字段、表维护
模块英文名:Table_Field
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
    public static class clsvQxPrjTabBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvQxPrjTabENS">源对象</param>
        /// <returns>目标对象=>clsvQxPrjTabEN:objvQxPrjTabENT</returns>
        public static clsvQxPrjTabENEx CopyToEx(this clsvQxPrjTabEN objvQxPrjTabENS)
        {
            try
            {
                clsvQxPrjTabENEx objvQxPrjTabENT = new clsvQxPrjTabENEx();
                clsvQxPrjTabBL.vQxPrjTabDA.CopyTo(objvQxPrjTabENS, objvQxPrjTabENT);
                return objvQxPrjTabENT;
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
        /// <param name = "objvQxPrjTabENS">源对象</param>
        /// <returns>目标对象=>clsvQxPrjTabEN:objvQxPrjTabENT</returns>
        public static clsvQxPrjTabEN CopyTo(this clsvQxPrjTabENEx objvQxPrjTabENS)
        {
            try
            {
                clsvQxPrjTabEN objvQxPrjTabENT = new clsvQxPrjTabEN();
                clsvQxPrjTabBL.vQxPrjTabDA.CopyTo(objvQxPrjTabENS, objvQxPrjTabENT);
                return objvQxPrjTabENT;
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
    /// v工程表(vQxPrjTab)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvQxPrjTabBLEx : clsvQxPrjTabBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvQxPrjTabDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvQxPrjTabDAEx vQxPrjTabDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvQxPrjTabDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvQxPrjTabENEx> GetObjExLst(string strCondition)
        {
            List<clsvQxPrjTabEN> arrObjLst = clsvQxPrjTabBL.GetObjLst(strCondition);
            List<clsvQxPrjTabENEx> arrObjExLst = new List<clsvQxPrjTabENEx>();
            foreach (clsvQxPrjTabEN objInFor in arrObjLst)
            {
                clsvQxPrjTabENEx objvQxPrjTabENEx = new clsvQxPrjTabENEx();
                clsvQxPrjTabBL.CopyTo(objInFor, objvQxPrjTabENEx);
                arrObjExLst.Add(objvQxPrjTabENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strTabId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvQxPrjTabENEx GetObjExByTabId(string strTabId)
        {
            clsvQxPrjTabEN objvQxPrjTabEN = clsvQxPrjTabBL.GetObjByTabId(strTabId);
            clsvQxPrjTabENEx objvQxPrjTabENEx = new clsvQxPrjTabENEx();
            clsvQxPrjTabBL.CopyTo(objvQxPrjTabEN, objvQxPrjTabENEx);
            return objvQxPrjTabENEx;
        }
    }
}