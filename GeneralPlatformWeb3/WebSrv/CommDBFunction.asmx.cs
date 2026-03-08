using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Collections.Generic;
using GeneralPlatform.BusinessLogic;

namespace GeneralPlatform.WebSrv
{
    /// <summary>
    /// CommDBFunction 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class CommDBFunction : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int funGetRecCountByCond(string strTabName, string strCondtion)
        {
            return clsCommDBFunction.funGetRecCountByCond(strTabName, strCondtion);
        }
        [WebMethod]
        public List<String> funGetFldValue(string strTableName, string strFieldName, string WhereConditionString)
        {
            List<String> lst = new List<string>();
            List<string>  arr = clsCommDBFunction.funGetFldValue(strTableName, strFieldName, WhereConditionString);
            foreach (string ss in arr)
            {
                lst.Add(ss);
            }
            return lst;
        }

        [WebMethod]
        public int funSetFldValue(string strTabName, string strFldName, string strValue, string strCondition)
        {
            return clsCommDBFunction.funSetFldValue( strTabName, strFldName, strValue, strCondition);
        }
        [WebMethod]
        public bool IsExistRecord(string strTable, string strCondition)
        {
            return clsCommDBFunction.IsExistRecord(strTable, strCondition);
        }
    }
}
