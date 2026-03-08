using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using GeneralPlatform;

using System.Security.Cryptography;
using GeneralPlatform.Webform;
using GeneralPlatform.Entity;


public partial class Webform_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //string strid = ""; //"1000000000shnuneusoft";
        //string strmudol = "";//"ky_kyxt";
        //string strurl = "Index_quick.aspx?userid=t01&key=0a3597ba2700b5abe3ec0d0ba2c2b9c1";
        //Response.Redirect(strurl);


        string c1 = string.Empty;
        clsCommonSession.UserId = "pyf";
        if (string.IsNullOrEmpty(clsCommonSession.UserId) == false)
        {
            c1 = clsPubVar.GetGPLoginScript(clsCommonSession.UserId);
        }
        else
        {
            clsCommonSession.ErrMessage = "请登录后再使用该功能！";
            new clsCommonSession().IsQuitSystem = "true";
            //BackErrPageLinkStr = "\" Page.Request.Url.AbsolutePath;
            Response.Redirect(clsSysParaEN.ErrorPage);
            //            c1 = clsPubVar.GetBBLoginScript("fk");
        }
        Response.Write(c1);
    }
    /// <summary>
    /// MD5加密函数
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public string MD5(String str)
    {
        MD5 md5 = new MD5CryptoServiceProvider();
        byte[] data = System.Text.Encoding.Default.GetBytes(str);
        byte[] result = md5.ComputeHash(data);
        String ret = "";
        for (int i = 0; i < result.Length; i++)
            ret += result[i].ToString("x").PadLeft(2, '0');
        return ret;
    } 
    /// <summary>
    /// 获取登录BB的脚本代码
    /// </summary>
    /// <param name="strUserId">用户ID</param>
    /// <returns></returns>
    public string GetGPLoginScript(string strUserId)
    {
        string c1 = string.Empty;
        string strKey = MD5(strUserId + "gpintegration");
        strKey = strKey.ToUpper();
        //http://202.121.49.7/webapps/login/
        //            c1 = "<script language='javascript'>window.open('http://202.121.63.10/GeneralPlatformTZ/quick_index.aspx?userid=" + strUserId + "&key=" + strKey + "'); </script>";
        c1 = "<script language='javascript'>window.open('index_quick.aspx?userid=" + strUserId + "&key=" + strKey + "'); </script>";
        return c1;
    }
}
