using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text;
using System.Data;
using GeneralPlatform.Entity;

namespace GeneralPlatform.WebSrv
{
    /// <summary>
    /// MenuAndPotence 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class MenuAndPotence : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        ///// <summary>
        ///// 获取用户在当前页面的使用等级
        ///// </summary>
        ///// <param name="ViewId">界面编号</param>
        ///// <returns>返回等级号，0表示没有权使用</returns>
        [WebMethod]
        public string Get_PotenceLevel(string ViewId, string strRoleId)
        {

            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" Viewid='{0}'", ViewId);
            sbCondition.AppendFormat("  and PotenceId in (Select PotenceId from {1} where roleid='{0}')", strRoleId,
                clsQxUserGroupPotenceEN._CurrTabName_S);
            sbCondition.AppendFormat("              order by level");
            //DataTable objDt = clsQxViewPotence_GetQxViewPotence(sbCondition.ToString());
            //foreach (DataRow dr in objDt.Rows)
            //{
            //    return dr["Level"].ToString();
            //}
            return "0";

        }
    }
}
