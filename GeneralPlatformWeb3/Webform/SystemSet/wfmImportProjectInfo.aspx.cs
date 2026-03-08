//clsDBServer objDBServer = (clsDBServer)Session["objDBServer"];
//clsDBServer objDBServer = new clsDBServer();
//			Session.Add("objDBServer", objDBServer);
using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using CommFunc4WebForm;
using com.taishsoft.commdb;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
using System.Collections.Generic;
using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
    /// <summary>
    /// WebForm1 的摘要说明。
    /// </summary>
    public partial class wfmImportViewInfoFromSQL2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面


            if (!IsPostBack)
            {
                wucDataBaseConnect1.ServerIP = "202.121.63.17,9433";
                wucDataBaseConnect1.DataBaseName = "GeneralPlatformTZ";
                wucDataBaseConnect1.DataBaseUserId = "sa_GPTZ";
                wucDataBaseConnect1.DataBasePassword = "a1b2c3";


            }
        }

       



        private void ReturnLoginView()
        {
            Session.Clear();
            string strMsg;
            strMsg = "对不起你的权限不够，请重新登录!";
            Response.Write("<script>alert('" + strMsg + "')</script>");
            string ss = "<script language='javascript'> parent.window.location.href='Index.aspx'</script>";
            //			string ss = "<script language='javascript'> parent.main.location.href='index.htm'</script>";
            //			string ss = "<script language='javascript'> parent.window.location.href='main1.aspx' target='main';</script>";
            Response.Write(ss);
        }


        protected void btnGetProjectInfo_Click(object sender, EventArgs e)
        {
            string strConnectString = wucDataBaseConnect1.GetConnectString();
            GeneralPlatform.Entity.clsQxProjectsEN._ConnectString = strConnectString;
            List<clsQxProjectsEN> arrProjectsObjLst = clsQxProjectsBL.GetObjLst("1=1");
            clsDropDownList.BindDdl_Projects(ddlProjects, strConnectString);
            GeneralPlatform.Entity.clsQxProjectsEN._ConnectString = "";
        }

        protected void btnImport_Click(object sender, EventArgs e)
        {
            if (ddlProjects.SelectedIndex > 0)
            {
                string strPrjId_S = ddlProjects.SelectedValue.ToString();
                GeneralPlatform.Entity.clsQxProjectsENEx objProjectsEx = new GeneralPlatform.Entity.clsQxProjectsENEx(strPrjId_S);
                objProjectsEx.QxPrjId = strPrjId_S;
                string strConnectString = wucDataBaseConnect1.GetConnectString();
                GeneralPlatform.Entity.clsQxProjectsEN._ConnectString = strConnectString;
                objProjectsEx.ConnectStringS = strConnectString;
                clsQxProjectsBLEx.GetProjectsEx(ref objProjectsEx);
                clsQxProjectsBLEx.GetSubUserRolesLst(objProjectsEx);
                GeneralPlatform.Entity.clsQxProjectsEN._ConnectString = "";
                clsQxProjectsBLEx.CopyProjectsEx(objProjectsEx);
                
            }
        }
    }
}
