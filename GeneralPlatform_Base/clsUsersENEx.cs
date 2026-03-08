using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace GeneralPlatform.Entity
{
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
