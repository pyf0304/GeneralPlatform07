using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace GeneralPlatform.Webform
{
    /// <summary>
    /// error 的摘要说明。
    /// </summary>
    public partial class SysError : System.Web.UI.Page
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

            Exception objException = Server.GetLastError();
            Exception objExceptionLast = null;
            if (objException == null) return;
            if (objException.InnerException != null)
            {
                objExceptionLast = objException.InnerException;
            }
            else
            {
                objExceptionLast = objException;
            }
            string strOperate = "";
            if (objExceptionLast.Data["operate"] != null)
            {
                strOperate = objExceptionLast.Data["operate"].ToString();
            }

            if (strOperate == "attack")
            {
                Response.Clear();
                Response.Write("出错网络攻击！");
                Response.End();
            }

            lblErrMsg.Text = objExceptionLast.Message;

        }
        protected void Page_PreInit(object sender, EventArgs e)
        {

            //设置后台管理页面主题
            //clsPubFun.SetSkin4Manage(this);

        }
        protected void LinkButton1_Click(object sender, System.EventArgs e)
        {
            //Response.Redirect("load.aspx");
            string c1 = "<script language='javascript'>window.parent.location.href='../Webform/index.aspx'; </script>";
            Response.Write(c1);
        }

        protected void lbGoBack_Click(object sender, System.EventArgs e)
        {
            Response.Redirect(Page.Request.Url.AbsolutePath);
        }
    }
}
