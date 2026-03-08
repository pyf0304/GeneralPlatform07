using com.taishsoft.common;
using CommFunc4WebForm;


using ExamLib.Webform;
using GeneralPlatform.Webform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;
using System.Configuration;
using GeneralPlatform.Entity;

namespace ExamLib.Webform.Admin
{
    public partial class IndexMenu : CommWebBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strVirtualRoot = HttpContext.Current.Request.ApplicationPath;
            //clsPubFun4Web.SetSysPath(strVirtualRoot);
            //EduHigh.BusinessLogicEx.clsPubFun.SetSysPath(strVirtualRoot);

            string strFunName = Request.Form["FunName"] != null ? Request.Form["FunName"] : "";
            string strPrjId = Request.Form["hidPrjId"] != null ? Request.Form["hidPrjId"] : "";
            //根据传回来的值决定调用哪个函数
            switch (strFunName)
            {
                case "SwitchPrj_Click":
                    SwitchPrj_Click(strPrjId); //调用该函数
                    break;
                case "其他":
                    //调用其他函数

                    break;
                default:
                    //调用默认函数
                    //lblMsg.Text = "调用默认函数";
                    break;
            }

            if (!IsPostBack)
            {
                switch (clsMyConfig.spId_School)
                {
                    case "0004":
                        this.Title = "宁波大学统一平台";
                        lblTitle.Text = this.Title;
                        break;
                    case "0009":
                        this.Title = "控制中心-安全生产月知识竞赛统一平台";
                        lblTitle.Text = this.Title;
                        break;
                    case "0006":
                        this.Title = "上海泰泽在线教育平台";
                        lblTitle.Text = this.Title;
                        break;
                    case "0008":
                        this.Title = "上海师大二附中统一平台";
                        lblTitle.Text = this.Title;
                        break;
                    case "0007":
                        this.Title = "上海泰泽统一平台";
                        lblTitle.Text = this.Title;
                        break;
                    case "0001":
                        this.Title = "淮阴师范统一平台";
                        lblTitle.Text = this.Title;
                        break;
                    default:
                        clsXzSchoolEN objXzSchoolEN = clsXzSchoolBL.GetObjByIdSchoolCache(clsMyConfig.spId_School);
                        string strMsg = string.Format("当前学校：[{0}({1})]没有在相关函数中处理。({2})",
                            objXzSchoolEN.SchoolName,
                            objXzSchoolEN.SchoolId,
                            clsStackTrace.GetCurrClassFunction());
                        clsCommonJsFunc.Alert(this, strMsg);
                        return;
//                        break;
                }
                string strUserId = clsCommonSession.UserId; //"admin"; 
                string strCurrUserRoleId = clsCommonSession.RoleId;// clsPubVar. "00000001";

                //设置当前用户
                {
                    clsQxUsersEN objQxUsersEN = clsQxUsersBL.GetObjByUserIdCache(strUserId);
                    lblUserName.Text = objQxUsersEN.UserName;
                }
                //设置当前角色
                {
                    clsQxRolesEN objQxUserRolesEN = clsQxRolesBL.GetObjByRoleIdCache(strCurrUserRoleId);
                    lblRoleName.Text = objQxUserRolesEN.RoleName;
                }

                //设置当前所选项目名称：
                {
                    string strUserPrjId = clsCommonSession.UserPrjId;
                    clsQxProjectsEN objQxProjectsEN = clsQxProjectsBL.GetObjByQxPrjIdCache(strUserPrjId);
                    lblCurrProject.Text = objQxProjectsEN.PrjName;
                }

                string strCurrPrjId = "";// clsCommonSession.UserPrjId;// "0150";
                strCurrPrjId = this.CurrrntPrjId;
                       
                //BindUserCourse(strUserId);
                //SetUserState();
                string strHtml;     //需要插入的HTML代码
                if (string.IsNullOrEmpty(strCurrUserRoleId) == true)
                {
                    string strMsg = string.Format("当前用户:[{0}]的角色为空，请联系管理员！", strUserId);
                    clsCommonJsFunc.Alert(this, strMsg);
                    return;
                }
                new MenuAndPotence().Get_QxUserRolePotence(strCurrUserRoleId);
                string strMenuSetId = "";
                strHtml = clsGeneMenuBLEx.GetUserMenuHTML2(strCurrPrjId, strMenuSetId, strCurrUserRoleId,  strUserId);

                //6、把菜单HTML菜单串显示到界面上。						
                this.ulPARENT.InnerHtml = strHtml.ToString();
            }
        }

        //private void SetUserState()
        //{
        //    try
        //    {
        //        lblUserName.Text = clsCommonSession.UserName;
        //        lblRoleName.Text = clsCommonSession.RoleName;

        //    }
        //    catch (Exception objException)
        //    {
        //        //clsPubVar4Web.objErrorLog.WriteDebugLog(objException.Message);
        //    }
        //}

        protected void SwitchPrj_Click(string strPrjId)
        {
            ////string strMid = lbSwitchPrj.CommandArgument;// this.dgcc_Course.SelectedItem.Cells[0].Text;
            //sePrjId = strPrjId;
            //try
            //{
            //    clsUserDefaValueBLEx.SaveUserDefaValue(clsCommonSession.UserId, "缺省课程", sePrjId, clsCommonSession.UserId);
            //}
            //catch (Exception objException)
            //{
            //    clsCommonJsFunc.Alert(this, objException.Message);
            //}

  
            //SetUserState();
        }

        protected void lbLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            string strScript = "<script language='javascript'>window.parent.location.href='../../Index.htm'; </script>";
            this.ClientScript.RegisterClientScriptBlock(this.GetType(), "Logout", strScript);
        }
        public string CurrrntPrjId
        {
            get
            {
                if (ConfigurationSettings.AppSettings[conQxProjects.QxPrjId] != null)
                {
                    return ConfigurationSettings.AppSettings[conQxProjects.QxPrjId].ToString();
                }
                else
                {
                    return "0";
                }
            }
        }
    }
}