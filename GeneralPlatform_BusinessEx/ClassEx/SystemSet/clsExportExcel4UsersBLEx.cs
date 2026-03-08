
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsExportExcel4UsersBLEx
表名:ExportExcel4Users
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:04:56
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:系统设置
模块英文名:SystemSet
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
using com.taishsoft.datetime;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 导出Excel用户字段表(ExportExcel4Users)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsExportExcel4UsersBLEx : clsExportExcel4UsersBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsExportExcel4UsersDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsExportExcel4UsersDAEx ExportExcel4UsersDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsExportExcel4UsersDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        public static bool GoTop(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsExportExcel4UsersDAEx().GoTop(arrKeyId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }
        public static bool GoTop(List<string> arrKeyId, string strIdExportExcel4Users)
        {
            try
            {

                bool bolResult = new clsExportExcel4UsersDAEx().GoTop(arrKeyId);
                bolResult = new clsExportExcel4UsersDAEx().ReOrder(strIdExportExcel4Users);

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }
        public static bool GoTop(string strKeyId, string strIdExportExcel4Users)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsExportExcel4UsersDAEx().GoTop(arrKeyId);
                bolResult = new clsExportExcel4UsersDAEx().ReOrder(strIdExportExcel4Users);

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }
        public static bool GoBottom(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsExportExcel4UsersDAEx().GoBottom(arrKeyId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }
        public static bool GoBottom(string strKeyId, string strIdExportExcel4Users)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsExportExcel4UsersDAEx().GoBottom(arrKeyId);
                bolResult = new clsExportExcel4UsersDAEx().ReOrder(strIdExportExcel4Users);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }

        public static bool GoBottom(List<string> arrKeyId, string strIdExportExcel4Users)
        {
            try
            {

                bool bolResult = new clsExportExcel4UsersDAEx().GoBottom(arrKeyId);
                bolResult = new clsExportExcel4UsersDAEx().ReOrder(strIdExportExcel4Users);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strDirect"></param>
        /// <param name="lngmId"></param>
        /// <returns></returns>
        public static bool AdjustSequenceNumber(string strDirect, long lngmId)
        {
            try
            {
                bool bolResult = new clsExportExcel4UsersDAEx().AdjustSequenceNumber(strDirect, lngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错！\r\n" + objException.Message);
            }
        }
        public static bool ReOrder(string strIdExportExcel4Users)
        {
            try
            {
                bool bolResult = new clsExportExcel4UsersDAEx().ReOrder(strIdExportExcel4Users);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错！\r\n" + objException.Message);
            }

        }
        public static bool ChangeExportStatus(long lngMid, string strUserId)
        {
            clsExportExcel4UsersEN objExportExcel4UsersEN = clsExportExcel4UsersBL.GetObjBymId(lngMid);

            objExportExcel4UsersEN.IsExport = !objExportExcel4UsersEN.IsExport;
            objExportExcel4UsersEN.UpdUserId = strUserId;
            objExportExcel4UsersEN.UpdDate = clsDateTime.getTodayStr(0);
            return clsExportExcel4UsersBL.UpdateBySql2(objExportExcel4UsersEN);

        }
    }
}