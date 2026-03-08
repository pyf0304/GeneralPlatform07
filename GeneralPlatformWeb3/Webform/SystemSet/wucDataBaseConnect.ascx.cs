using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.taishsoft.commdb;
using GeneralPlatform;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;

public partial class Webform_SystemSet_wucDataBaseConnect : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public string ServerIP
    {
        get
        {
            return txtServer.Text.Trim();
        }
        set
        {
            txtServer.Text = value;
        }
    }


    public string DataBaseName
    {
        get
        {
            return txtDataBaseName.Text.Trim();
        }
        set
        {
            txtDataBaseName.Text = value;
        }
    }
    public string DataBaseUserId
    {
        get
        {
            return txtDataBaseUserId.Text.Trim();
        }
        set
        {
            txtDataBaseUserId.Text = value;
        }
    }

    public string DataBasePassword
    {
        get
        {
            if (string.IsNullOrEmpty(txtDataBasePassword.Text.Trim()) == false)
            {
                return txtDataBasePassword.Text.Trim();
            }
            else
            {
                return Password;
            }
        }
        set
        {
            txtDataBasePassword.Text = value;
        }
    }
    //测试连接
    private bool TestConnect()
    {
        clsQxPrjDataBaseEN objPrjDataBaseEN = null;
        objPrjDataBaseEN = new clsQxPrjDataBaseEN();
        PutDataToPrjDataBaseClass(objPrjDataBaseEN);

        bool bolResult = false;
        try
        {
            bolResult = clsSpecSQLforSql.TestConnect(clsQxPrjDataBaseBLEx.GetConnectString(objPrjDataBaseEN));
        }
        catch (Exception objException)
        {
            lblMsg.Text = objException.Message;
        }
        return bolResult;
    }
    ///生成从界面层到逻辑层的数据传输函数代码
    private void PutDataToPrjDataBaseClass(clsQxPrjDataBaseEN pobjPrjDataBase)
    {
        pobjPrjDataBase.PrjDataBaseName = this.DataBaseName;
        pobjPrjDataBase.DataBaseName = this.DataBaseName;
        pobjPrjDataBase.IpAddress = this.ServerIP;
        pobjPrjDataBase.DataBaseUserId = this.DataBaseUserId;
        
        pobjPrjDataBase.DataBasePwd = this.DataBasePassword;
        pobjPrjDataBase.DataBaseTypeId = "01";

    }


    protected void btnTestConnect_Click(object sender, EventArgs e)
    {
        bool bolResult = TestConnect();
        if (bolResult)
        {
            lblMsg.Text = "测试连接成功！";
        }
        else
        {
            lblMsg.Text = "测试连接失败！";
        }
    }

    public string GetConnectString()
    {
        string strConnectString = "";
        clsQxPrjDataBaseEN objPrjDataBaseEN = null;
        objPrjDataBaseEN = new clsQxPrjDataBaseEN();
        PutDataToPrjDataBaseClass(objPrjDataBaseEN);


        try
        {
            strConnectString = clsQxPrjDataBaseBLEx.GetConnectString(objPrjDataBaseEN);
        }
        catch (Exception objException)
        {
            lblMsg.Text = objException.Message;
        }
        return strConnectString;
    }
    private string Password
    {
        get
        {
            string strPassword;
            strPassword = (string)ViewState["Password"];
            if (strPassword == null)
            {
                strPassword = "";
            }
            return strPassword;
        }
        set
        {
            string strPassword = value;
            ViewState.Add("Password", strPassword);
        }
    }

    protected void txtDataBasePassword_TextChanged(object sender, EventArgs e)
    {
        Password = txtDataBasePassword.Text.Trim();
    }
}
