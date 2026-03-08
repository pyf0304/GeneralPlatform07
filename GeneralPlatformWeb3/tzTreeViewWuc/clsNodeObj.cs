using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.taishsoft.web.treeview
{
    /// <summary>
    /// clsNodeObj 的摘要说明。
    /// </summary>
    public class clsNodeObj
    {
        private System.Collections.Hashtable htAttributes = new System.Collections.Hashtable();
        /// <summary>
        /// 结点对象类
        /// </summary>
		public clsNodeObj()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        /// <summary>
        /// 添加属性
        /// </summary>
        /// <param name="strKeyName">关键字名</param>
        /// <param name="strValue">关键字值</param>
		public void AddAttribute(string strKeyName, string strValue)
        {
            htAttributes.Add(strKeyName, strValue);
        }
        /// <summary>
        /// 获取、设置结点对象的值
        /// </summary>
        /// <param name="strAttributeName">属性名</param>
        /// <returns>属性值</returns>
		public object this[string strAttributeName]
        {
            get
            {
                if (htAttributes.Contains(strAttributeName) == false)
                {
                    return null;
                }
                return htAttributes[strAttributeName];
            }
            set
            {
                htAttributes.Add(strAttributeName, value.ToString());
            }
        }
    }
}