using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GeneralPlatform4WS;
using System.Collections;
using GeneralPlatform4WS.ServiceReferencevQxRoleMenus;
using System.Data;

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

        protected void btnGetmenu_Click(object sender, EventArgs e)
        {
            List<clsvQxRoleMenusEN> arrPrjUpMenu = clsvQxRoleMenusWS.GetUpMenuObjList("01030001", "0103", "0024");
    
            ///获取子菜单
            List<clsvQxRoleMenusEN> arrPrjSubMenu = clsvQxRoleMenusWS.GetSubMenuObjList("01030001", "0103", "0024");
            ///5、根据获取的用户菜单列表，组织成HTML菜单串。	
        }

        protected void btnTestGet_PotenceLevel_Click(object sender, EventArgs e)
        {
            MenuAndPotence objMenuAndPotence = new MenuAndPotence();
            string ss = objMenuAndPotence.Get_PotenceLevel("00260001", "00260010");
        }

        protected void btnTestWebConnect_Click(object sender, EventArgs e)
        {
            string strMsg = "";
            bool bolResult = clsSysPara4WS.TestConnect(ref strMsg);
            if (bolResult == true)
            {
                lblTestResult.Text = "测试主连接成功！";
            }
            else
            {
                lblTestResult.Text = "测试主连接失败！" + strMsg;
                clsSysPara4WS.bolIsUseBackupIpAddressAndCurrPrx = true;
            }
        }

        protected void btnTestWebConnect2_Click(object sender, EventArgs e)
        {
            string strMsg = "";
            bool bolResult = clsSysPara4WS.TestConnect2(ref strMsg);
            if (bolResult == true)
            {
                lblTestResult.Text = "测试备用连接成功！";
            }
            else
            {
                lblTestResult.Text = "测试备用连接失败！" + strMsg;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //            string strWhere = "UserId = 'zcr123' and QxPrjId='0106' order by RoleId desc";
            //           string strWhere = "UserId = 'zcr123' and QxPrjId='0106'";
            //                  string strWhere = "UserId = 'zcr123'";//不出错
            //  string strWhere = "UserId = 'zcr123'  order by RoleId desc";//不出错
              string strWhere = "QxPrjId='0150' And UserId = 'lyl'  order by RoleId desc";
            DataTable objDT = clsQxUserRoleRelationWS.GetDataTable_QxUserRoleRelationVWs(strWhere);
            GridView1.DataSource = objDT;
            GridView1.DataBind();
        }

        protected void btnUpdPassword_Click(object sender, EventArgs e)
        {
            string strPwd = "mm012345@";
            string strNewPwd1 = "pyf012345@";
            string strNewPwd2 = "pyf012345@";
            string strUserId = "00701";
            if (clsLoginWS.UserLogin(strUserId, strPwd))
            {
                GeneralPlatform4WS.ServiceReferenceUsers.clsQxUsersEN obj = new GeneralPlatform4WS.ServiceReferenceUsers.clsQxUsersEN();
                obj.UserId = strUserId;
                obj.Password = strNewPwd1;
                //obj.StuIdTeacherId = "lf";
                if (clsQxUsersWS.UpdateBySql2Ws(obj))
                {
                    //txtPwd.Text = "";
                    //txtNewPwd1.Text = "";
                    //txtNewPwd2.Text = "";
                    ClientScript.RegisterStartupScript(this.GetType(), "error", "<script>alert('密码修改成功！')</script>");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "error", "<script>alert('密码修改失败！')</script>");
                }

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "error", "<script>alert('当前密码错误！')</script>");
            }
        }
    }
}
