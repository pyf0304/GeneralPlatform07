using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace GeneralPlatform.WebSrv
{
    /// <summary>
    /// Test 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class Test : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string strUserName)
        {
            return "Hello！" + strUserName;
        }
        [WebMethod]
        public string HelloWorld2(string strUserName, ref string strReturnValue)
        {
            strReturnValue = "ReturnValue:Hello！" + strUserName;
            return "Hello！" + strUserName;
        }
        [WebMethod]
        public int myAdd(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
}
