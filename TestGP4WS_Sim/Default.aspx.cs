using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GeneralPlatform4WS;
using System.Collections;
using GeneralPlatform4WS.ServiceReferencevQxRoleMenus;

namespace TestGP4WS
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string strUserId = txtUserName.Text;
            string strPassword = txtPassword.Text;
            if (strUserId == "")
            {
                Response.Write("<script>alert('请输入用户名！')</script>");
            }
            else 
            {
                try
                {
                    if (clsLoginWS.UserLogin(strUserId, strPassword))
                    {
                        Response.Write("<script>alert('用户名登录成功！')</script>");
                        lblLoginResult.Text = "用户名登录成功!";
                    }
                    else
                    {
                        Response.Write("<script>alert('用户名或密码错误！')</script>");
                        lblLoginResult.Text = "用户名或密码错误!";
                    }
                }
                catch (Exception objException)
                {
                    lblLoginResult.Text = objException.Message;
                }
            }
        }

      

      
    }
}
