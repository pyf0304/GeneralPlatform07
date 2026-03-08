using com.taishsoft.common;
using GeneralPlatform4WS.ServiceReferenceQxPrjMenus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// clsQxPrjMenusWSEx
    /// </summary>
    public class clsQxPrjMenusWSEx: clsQxPrjMenusWS
    {

        /// <summary>
        /// 获取当前角色的顶层菜单列表，以List<clsvRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvRoleMenusEN>形式表示的顶层菜单列表</returns>
        public static List<clsQxPrjMenusEN> GetUpMenuObjListByMenuSetId(string strPrjId, string strMenuSetId)
        {
            List<clsQxPrjMenusEN> arrUpMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" UpMenuId = '00000000' AND ");
            sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId={1}",
                strPrjId, strMenuSetId);
            sbCondition.Append(" ORDER BY OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

            try
            {
                arrUpMenuObjList = GetObjLst(sbCondition.ToString());
            }
            catch (Exception objException)
            {
                clsLog.LogErrorS(objException, "clsQxPrjMenusWSEx");
                throw objException;
            }
            finally
            {
            }
            return arrUpMenuObjList;
        }
        /// <summary>
        /// 获取当前角色的子层菜单列表，以List<clsvRoleMenusEN>的形式返回
        /// </summary>
        /// <param name="strRoleId">角色Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strMenuSetId">菜单集Id</param>
        /// <returns>以List<clsvRoleMenusEN>形式表示的子层菜单列表</returns>
        public static List<clsQxPrjMenusEN> GetSubMenuObjListByMenuSetId(string strPrjId, string strMenuSetId)
        {
            List<clsQxPrjMenusEN> arrSubMenuObjList = null;
            StringBuilder sbCondition = new StringBuilder();

            sbCondition.AppendFormat(" UpMenuId <> '00000000' and ");
            sbCondition.AppendFormat(" QxPrjId = '{0}' And MenuSetId={1}", strPrjId, strMenuSetId);
            sbCondition.Append(" Order By OrderNum");
            sbCondition.Append("[Exclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = GetObjLst(sbCondition.ToString());
            }
            catch (Exception objException)
            {
                clsLog.LogErrorS(objException, "clsQxPrjMenusWSEx");
                throw objException;
            }
            finally
            {
            }
            return arrSubMenuObjList;
        }
    }
}
