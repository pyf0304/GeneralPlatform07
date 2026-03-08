using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.taishsoft.web.treeview
{
    public class clsEventArgs4TreeView : EventArgs
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
        private string mstrNodeType;
        /// <summary>
        /// 结点类型
        /// </summary>
        public string NodeType
        {
            get { return mstrNodeType; }
            set { mstrNodeType = value; }
        }
            

    }
}