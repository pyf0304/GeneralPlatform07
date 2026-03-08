using com.taishsoft.common;
using CommFunc4WebForm;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EduHigh.Webform.PersonalCenter
{
    public partial class top : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void lbQuit_Click(object sender, EventArgs e)
        {
            //new clsCommonSession().ClearSession();
            //string strUrl = ResolveUrl("~/Webform/pste.aspx");
            ////            string c1 = string.Format("<script language='javascript'>window.parent.open('{0}','_blank'); </script>", strUrl);
            //string c1 = string.Format("<script language='javascript'>window.parent.location.href='{0}'; </script>", strUrl);
            //this.ClientScript.RegisterClientScriptBlock(this.GetType(), "lbQuit_Click", c1);
            //Response.Redirect("~/Webform/Index.aspx");
           
            //ClearLogin();
            //LoginBefore();
        }
        #region 清空数据
        /// <summary>
        /// 清空数据
        /// </summary>
        private void ClearLogin()
        {
            //txtUserName.Text = "";
            //txtTPass_zword.Text = "";
            ////practicemanage.NavigateUrl = "#";
            //this.general.NavigateUrl = "#";
            ////this.SearchScore.NavigateUrl = "#";
            ////this.SearchScore.Target = "_self";
            ////this.practicemanage.Target = "_self";
            //this.general.Target = "_self";
        }
        #endregion

        protected void lbReturnIndex_Click(object sender, EventArgs e)
        {
            string strUrl = ResolveUrl("~/Webform/pste.aspx");
            //            string c1 = string.Format("<script language='javascript'>window.parent.open('{0}','_blank'); </script>", strUrl);
            string c1 = string.Format("<script language='javascript'>window.parent.location.href='{0}'; </script>", strUrl);
            this.ClientScript.RegisterClientScriptBlock(this.GetType(), "lbReturnIndex_Click", c1);
        }

       
    }
}