using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.taishsoft.web.menu
{
    public class clsEventArgs4Menu : EventArgs
    {

        private string mstrKeyId;
        /// <summary>
        /// 关键字Id
        /// </summary>
        public string KeyId
        {
            get { return mstrKeyId; }
            set { mstrKeyId = value; }
        }
        private string mstrMenuItemType;
        /// <summary>
        /// 菜单项类型
        /// </summary>
        public string MenuItemType
        {
            get { return mstrMenuItemType; }
            set { mstrMenuItemType = value; }
        }
            

    }
}