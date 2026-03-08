
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvSetFieldVisibilityBLEx
表名:vSetFieldVisibility
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:08:06
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

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// v设置字段可视性(vSetFieldVisibility)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvSetFieldVisibilityBLEx : clsvSetFieldVisibilityBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvSetFieldVisibilityDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvSetFieldVisibilityDAEx vSetFieldVisibilityDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvSetFieldVisibilityDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        public static bool IsVisible(string strSchoolId, string strFieldName)
        {
            var arrvSetFieldVisibilityObjLst_Cache = clsvSetFieldVisibilityBL.GetObjLstCache();
            foreach (clsvSetFieldVisibilityEN objSetFieldVisibilityEN in arrvSetFieldVisibilityObjLst_Cache)
            {
                if (objSetFieldVisibilityEN.SchoolId == strSchoolId && objSetFieldVisibilityEN.FieldName == strFieldName)
                {
                    return objSetFieldVisibilityEN.IsVisible;
                }
            }
            return true;
        }

        public static bool IsVisible(string strSchoolId, string strViewName, string strFieldName)
        {
            var arrvSetFieldVisibilityObjLst_Cache = clsvSetFieldVisibilityBL.GetObjLstCache();

            foreach (clsvSetFieldVisibilityEN objSetFieldVisibilityEN in arrvSetFieldVisibilityObjLst_Cache)
            {
                if (objSetFieldVisibilityEN.SchoolId == strSchoolId &&
                    objSetFieldVisibilityEN.ViewName == strViewName &&
                    objSetFieldVisibilityEN.FieldName == strFieldName)
                {
                    return objSetFieldVisibilityEN.IsVisible;
                }
            }
            return true;
        }
        public static clsvSetFieldVisibilityEN GetvSetFieldVisibilityObjByFieldNameCache(string strSchoolId, string strViewName, string strFieldName)
        {

            var arrvSetFieldVisibilityObjLst_Cache = clsvSetFieldVisibilityBL.GetObjLstCache();

            foreach (clsvSetFieldVisibilityEN objSetFieldVisibilityEN in arrvSetFieldVisibilityObjLst_Cache)
            {
                if (objSetFieldVisibilityEN.SchoolId == strSchoolId &&
                    objSetFieldVisibilityEN.ViewName == strViewName &&
                    objSetFieldVisibilityEN.FieldName == strFieldName)
                {
                    return objSetFieldVisibilityEN;
                }
            }
            return null;
        }
    }
}