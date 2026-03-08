using com.taishsoft.common;
using CommFunc4WebForm;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamLib.Webform.Admin
{
    public partial class home : CommWebBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            divJT.Visible = false;
            divNBU.Visible = false;
            divTzJsie.Visible = false;
            string strVirtualRoot = HttpContext.Current.Request.ApplicationPath;
            //clsPubFun4Web.SetSysPath(strVirtualRoot);
            //EduHigh.BusinessLogicEx.clsPubFun.SetSysPath(strVirtualRoot);
            switch (clsMyConfig.spId_School)
            {
                case "0004":
                    this.Title = "宁波大学统一平台";
                    divNBU.Visible = true;
                    break;
                case "0009":
                    this.Title = "安全生产月知识竞赛统一平台";
                    divJT.Visible = true;
                    break;
                case "0006":
                    this.Title = "上海泰泽在线教育统一平台";
                    divTzJsie.Visible = true;
                    break;
                case "0008":
                    this.Title = "上海师大二附中统一平台";
                    divNBU.Visible = true;
                    break;
                case "0007":
                    this.Title = "上海泰泽统一平台";
                    divTzJsie.Visible = true;
                    break;
                case "0001":
                    this.Title = "淮阴师范统一平台";
                    divTzJsie.Visible = true;
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
        }
    }
}