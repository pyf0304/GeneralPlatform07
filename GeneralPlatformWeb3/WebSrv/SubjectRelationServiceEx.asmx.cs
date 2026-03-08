using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using GeneralPlatform.BusinessLogic;
using System.Collections;
using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.WebSrv
{
    /// <summary>
    /// SubjectRelationServiceEx 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class SubjectRelationServiceEx : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public List<string> GetUserIdLstByLeader(string strLeaderId)
        {

            List<string>  arrUserIdLst = clsSubjectRelationBLEx.GetUserIdLstByLeader(strLeaderId);
            List<string> lstUserIdLst = new List<string>();
            foreach (string strUserId in arrUserIdLst)
            {
                lstUserIdLst.Add(strUserId);
            }

            return lstUserIdLst;
        }
    }
}
