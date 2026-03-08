using com.taishsoft.common;
using EduHigh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EduHighWeb.Webform.HomeWork
{
    public partial class wfmUserMan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strLinkPageName = string.Format("{3}/Webform/JumpPage.aspx?UserId={0}&FunctionName={1}&MajorId=&UserPrjId={2}",
                 clsCommonSession.UserId,
                 qsFunctionName,
               clsMyConfig.spUserPrjId,
                 clsMyConfig.spSPJumpWebSite);
            string strMsg = string.Format("{0} in ({1});", strLinkPageName, clsStackTrace.GetCurrClassFunction());
            clsPubVar.objLog.WriteDebugLog(strMsg);
            Response.Redirect(strLinkPageName);
        }
        public string seUserPrjId
        {
            get
            {
                string strUserPrjId = clsCommonSession.UserPrjId;
                return strUserPrjId;
            }
            set
            {
                clsCommonSession.UserPrjId = value;
            }
        }
        /// <summary>
        /// 功能名称。例如：“视频资源库-显示”、“视频资源库-后台编辑”、“教学案例资源库-显示”、“教学案例资源库-后台编辑”等
        ///         根据不同的功能名称，可能调用不同的页面
        /// 作者：潘以锋
        /// 建立日期：2014-08-30
        /// </summary>
        public string qsFunctionName
        {
            get
            {
                if (Request.QueryString["FunctionName"] != null)
                {
                    return Request.QueryString["FunctionName"].ToString().Trim();
                }
                return "";
            }
        }
    }
}