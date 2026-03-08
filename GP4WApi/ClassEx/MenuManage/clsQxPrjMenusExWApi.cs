
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxPrjMenusExWApi
表名:QxPrjMenus(00140004)
生成代码版本:2019.03.24.1
生成日期:2019/03/24 09:23:36
生成者:
生成服务器IP:101.251.68.133
工程名称:统一平台
工程ID:0014
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:菜单管理
模块英文名:MenuManage
框架-层名:WebApi访问扩展层(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Collections;
using com.taishsoft.common;
using System.ServiceModel;
using GeneralPlatform.Entity;
using System.Collections.Generic;
using com.taishsoft.json;
using GP4WApi;
using GeneralPlatform4WApi;

namespace GP4WApi
{
    /// <summary>
    /// 工程菜单(QxPrjMenus)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsQxPrjMenusExWApi
    {
        private static readonly string mstrApiControllerName = "QxPrjMenusExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsQxPrjMenusEN> arrQxPrjMenusObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;


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
            //sbCondition.Append("[Exclude]or [/Exclude]");

            try
            {
                arrUpMenuObjList = clsQxPrjMenusWApi.GetObjLst(sbCondition.ToString());
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
            //sbCondition.Append("[Exclude]or [/Exclude]");

            try
            {
                arrSubMenuObjList = clsQxPrjMenusWApi.GetObjLst(sbCondition.ToString());
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
