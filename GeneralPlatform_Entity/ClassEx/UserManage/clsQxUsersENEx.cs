
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUsersENEx
表名:QxUsers(00140015)
生成代码版本:2018.06.11.1
生成日期:2018/06/16 16:03:32
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:统一平台
工程ID:0014
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:用户管理
模块英文名:UserManage
框架-层名:实体扩展层(EntityLayerEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.05.31.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace GeneralPlatform.Entity
{
    /// <summary>
    /// 用户(QxUsers)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCodeEx)
    /// </summary>
    [Serializable]
    public class clsQxUsersENEx : clsQxUsersEN
    {
        private string mstrRoleId;
        /// <summary>
        /// 当前所选角色
        /// </summary>
        public string RoleId
        {
            get { return mstrRoleId; }
            set { mstrRoleId = value; }
        }
        /// <summary>
        /// 当前用户的角色对象列表
        /// </summary>
        public ArrayList arrUserRoleObjLst = null;
        /// <summary>
        /// 当前用户的所有权限对象
        /// </summary>
        public List<clsQxPrjPotenceEN> arrPrjPotenceObjLst = null;
        /// <summary>
        /// 当前用户的所有权限标志对象列表
        /// </summary>
        public List<clsQxRelaOfPotenceAndSymbolEN> arrPrjPotenceAndSymbolObjLst = null;

        /// <summary>
        /// 当前用户的当前所选角色的所有权限对象
        /// </summary>
        public ArrayList arrPrjPotenceObjLst4CurrRole = null;
        /// <summary>
        /// 当前用户的当前所选角色的所有权限标志对象列表
        /// </summary>
        public ArrayList arrPrjPotenceAndSymbolObjLst4CurrRole = null;

    }
}