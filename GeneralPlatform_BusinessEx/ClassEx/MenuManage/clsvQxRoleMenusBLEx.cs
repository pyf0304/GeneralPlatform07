
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvQxRoleMenusBLEx
表名:vQxRoleMenus
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:07:33
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:菜单管理
模块英文名:MenuManage
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
    /// v角色菜单(vQxRoleMenus)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvQxRoleMenusBLEx : clsvQxRoleMenusBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvQxRoleMenusDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvQxRoleMenusDAEx vQxRoleMenusDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvQxRoleMenusDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        public static IEnumerable<clsvQxRoleMenusEN> GetUpMenuObjListByRoleIds(List<string> arrRoleId, 
            string strCurrPrjId, string strMenuSetId)
        {
            var arrRoleMenus = clsvQxRoleMenusBL.GetObjLstCache();

            IEnumerable<clsvQxRoleMenusEN> arrPrjUpMenu4Role = arrRoleMenus.Where(x => arrRoleId.Contains(x.RoleId) && x.QxPrjId == strCurrPrjId);
                        
            bool bolIsUpMenuId = true;

            if (bolIsUpMenuId == true)
            {
                arrPrjUpMenu4Role = arrPrjUpMenu4Role.Where(x => x.UpMenuId == "00000000");
                //sbCondition.AppendFormat("  AND UpMenuId = '00000000' ");
            }
            else
            {
                arrPrjUpMenu4Role = arrPrjUpMenu4Role.Where(x => x.UpMenuId != "00000000");
                //sbCondition.AppendFormat("  AND UpMenuId <> '00000000' ");
            }
     
            if (string.IsNullOrEmpty(strMenuSetId) == false)
            {
                //sbCondition.AppendFormat(" And MenuSetId='{0}'",
                //    strMenuSetId);
                arrPrjUpMenu4Role = arrPrjUpMenu4Role.Where(x => x.MenuSetId == strMenuSetId);
            }
            arrPrjUpMenu4Role = arrPrjUpMenu4Role.OrderBy(x => x.OrderNum);
            //sbCondition.Append("[Exclude]or [/Exclude]");

            //clsPubVar.objLog.WriteDebugLog(sbCondition.ToString());
            //arrPrjUpMenu4Role = clsvQxRoleMenusBL.GetObjLst(sbCondition.ToString());
            
            return arrPrjUpMenu4Role;
        }

        public static IEnumerable<clsvQxRoleMenusEN> GetSubMenuObjListByRoleIds(List<string> arrRoleId,
         string strCurrPrjId, string strMenuSetId)
        {
            var arrRoleMenus = clsvQxRoleMenusBL.GetObjLstCache();
            //sbCondition.AppendFormat(" AND QxPrjId = '{0}' ",
            // strCurrPrjId);
            IEnumerable<clsvQxRoleMenusEN> arrPrjUpMenu4Role = arrRoleMenus.Where(x=>arrRoleId.Contains( x.RoleId) && x.QxPrjId == strCurrPrjId);

         
            bool bolIsUpMenuId = false;
     
            if (bolIsUpMenuId == true)
            {
                arrPrjUpMenu4Role = arrPrjUpMenu4Role.Where(x => x.UpMenuId == "00000000");
                //sbCondition.AppendFormat("  AND UpMenuId = '00000000' ");
            }
            else
            {
                arrPrjUpMenu4Role = arrPrjUpMenu4Role.Where(x => x.UpMenuId != "00000000");
                //sbCondition.AppendFormat("  AND UpMenuId <> '00000000' ");
            }
         
            if (string.IsNullOrEmpty(strMenuSetId) == false)
            {
                //sbCondition.AppendFormat(" And MenuSetId='{0}'",
                //    strMenuSetId);
                arrPrjUpMenu4Role = arrPrjUpMenu4Role.Where(x => x.MenuSetId == strMenuSetId);
            }
            arrPrjUpMenu4Role = arrPrjUpMenu4Role.OrderBy(x => x.OrderNum);
           //sbCondition.Append(" ORDER BY OrderNum");
            //sbCondition.Append("[Exclude]or [/Exclude]");

            //clsPubVar.objLog.WriteDebugLog(sbCondition.ToString());
            //arrPrjUpMenu4Role = clsvQxRoleMenusBL.GetObjLst(sbCondition.ToString());

            return arrPrjUpMenu4Role;
        }
    }
}