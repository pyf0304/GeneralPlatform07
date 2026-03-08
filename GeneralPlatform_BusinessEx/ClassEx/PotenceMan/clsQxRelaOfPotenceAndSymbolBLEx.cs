
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxRelaOfPotenceAndSymbolBLEx
表名:QxRelaOfPotenceAndSymbol
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:05:44
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:权限管理
模块英文名:PotenceMan
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
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
    /// <summary>
    /// 权限编程标志关系表(QxRelaOfPotenceAndSymbol)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxRelaOfPotenceAndSymbolBLEx : clsQxRelaOfPotenceAndSymbolBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxRelaOfPotenceAndSymbolDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxRelaOfPotenceAndSymbolDAEx QxRelaOfPotenceAndSymbolDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxRelaOfPotenceAndSymbolDAEx();
                }
                return uniqueInstanceEx;
            }
        }


        public static bool IsHavePotenceAndSymbol(string strPotenceId, string strSymbol, List<clsQxRelaOfPotenceAndSymbolEN> arrPrjPotenceAndSymbolObjLst)
        {
            foreach (clsQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol in arrPrjPotenceAndSymbolObjLst)
            {
                if (objRelaOfPotenceAndSymbol.PotenceId == strPotenceId
                    && objRelaOfPotenceAndSymbol.SymbolForProgramme == strSymbol)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsHavePotenceId(string strPotenceId, string strSymbol, clsQxUsersENEx objUsersEx)
        {
            foreach (clsQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol in objUsersEx.arrPrjPotenceAndSymbolObjLst)
            {
                if (objRelaOfPotenceAndSymbol.PotenceId == strPotenceId
                    && objRelaOfPotenceAndSymbol.SymbolForProgramme == strSymbol)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="lngRelaMid">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsQxRelaOfPotenceAndSymbolEN GetQxRelaOfPotenceAndSymbolObjByRelaMid(long lngRelaMid, List<clsQxRelaOfPotenceAndSymbolEN> arrRelaOfPotenceAndSymbolObjLst)
        {
            foreach (clsQxRelaOfPotenceAndSymbolEN objRelaOfPotenceAndSymbol in arrRelaOfPotenceAndSymbolObjLst)
            {
                if (objRelaOfPotenceAndSymbol.RelaMid == lngRelaMid)
                {
                    return objRelaOfPotenceAndSymbol;
                }
            }
            return null;
        }
    }
}