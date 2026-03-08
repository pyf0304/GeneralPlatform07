using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using GeneralPlatform;
using System.Web.Security;
using System.Configuration;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;

using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// load 的摘要说明。
	/// </summary>
	public partial class Index : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{

			// 在此处放置用户代码以初始化页面

			if(!IsPostBack)
			{
                //Class1 obj = new Class1();
                //string str = Class1.ABC;
                clsSysParaEN.strCompanyName = clsTSysParaBLEx.getCompanyName(clsMyConfig.spSchool);

				Check_QxUserSession();
                lblApplicationName.Text = clsTSysParaBLEx.getApplicationName(clsMyConfig.spSchool);
                this.Title = string.Format("{0}--用户权限管理统一平台", lblApplicationName.Text);
			}
		}


		public string UserId
		{
			get
			{
				if(Session["UserId"] != null)
				{
					return Session["UserId"].ToString();
				}
				else
				{
					return "0";
				}
			}
			set
			{
				Session.Add("UserId",value);
					
			}

		}


		public string UserStateId
		{
			get
			{
				if(Session["UserStateId"] != null)
				{
					return Session["UserStateId"].ToString();
				}
				else
				{
					return "0";
				}
			}
			set
			{
				Session.Add("UserStateId",value);
				
					
			}
		}

		
		private void Set_QxUserInfoToSession()
		{
			Session.Clear();

			this.UserId = this.txtUserId.Text.Trim();
			this.UserStateId =  clsQxUsersBL.GetObjByUserIdCache(this.txtUserId.Text.Trim()).UserStateId;
			
			//System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(PasswordString, "MD5");

		}

		
		private void Check_QxUserSession()
		{
	
			if(this.UserId != "0" && this.UserStateId != "0")
			{
				Response.Redirect("wfmSelectUserPrjAndRole_GeneralPlatform.aspx");
		
			}
				

		}


		
		/// <summary>
		/// 功能：下载文件。从服务器下载文件到客户端浏览器
		/// </summary>
		/// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
		/// <returns></returns>
		private bool DownLoadFile(string strFileContent, string strFileName)
		{
			//			string path = "D:\\澳客网开发编码约定.doc";		//WORD文件可以直接下载
			///			string path = "D:\\1000010811.JPG";	//JPG文件必须先显示再右击下载
			Response.Clear(); 
			//			Response.AddHeader("Content-Disposition", "inline; filename=" + ); 
			Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(strFileName)); 
			//			Response.AddHeader("Content-Length", strFileContent.Length.ToString()); 
			Response.ContentType = "application/octet-stream"; 
			Response.Write(strFileContent); 
			Response.Write("\r\n");
			Response.End(); 
			return true;
		}
		/// <summary>
		/// 功能：下载文件。从服务器下载文件到客户端浏览器
		/// </summary>
		/// <param name="strDownLoadFileName">需要下载的文件名。该文件名为带目录的文件全名</param>
		/// <returns></returns>
		private bool DownLoadFile(string strDownLoadFileName)
		{
			//			string path = "D:\\澳客网开发编码约定.doc";		//WORD文件可以直接下载
			///			string path = "D:\\1000010811.JPG";	//JPG文件必须先显示再右击下载
			System.IO.FileInfo file = new System.IO.FileInfo(strDownLoadFileName); 
			Response.Clear(); 
			//Response.AddHeader("Content-Disposition", "inline; filename=" + HttpUtility.UrlEncode(file.Name)); 
			Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(file.Name)); 
			Response.AddHeader("Content-Length", file.Length.ToString()); 
			Response.ContentType = "application/octet-stream"; 
			Response.WriteFile(file.FullName); 
			Response.End(); 
			return true;
		}

		protected void LinkButton1_Click(object sender, System.EventArgs e)
		{
			string strPath = Server.MapPath("/General_Platform/downloadFiles/");
			this.DownLoadFile(@strPath + "General_Platform_Dll.dll");
		}

		protected void LinkButton3_Click(object sender, System.EventArgs e)
		{
			string strPath = Server.MapPath("/General_Platform/downloadFiles/");
		    this.DownLoadFile(@strPath + "wfmDispUserMenu_WebApplications.rar");
		}

		protected void LinkButton2_Click(object sender, System.EventArgs e)
		{
			string strPath = Server.MapPath("/General_Platform/downloadFiles/");
			 this.DownLoadFile(@strPath + "统一平台系统使用规范.doc");
		
		}


        protected void iBtnLogin_Click(object sender, ImageClickEventArgs e)
        {

            if (this.txtUserId.Text == "")
            {
                Response.Write("<script>alert('请输入用户名！')</script>");

            }

                string strUserId = this.txtUserId.Text.Trim();

            clsQxUsersEN objUsersEN = clsQxUsersBL.GetObjByUserIdCache(strUserId);
            if (objUsersEN == null)
            {
                Response.Write("<script>alert('用户名或密码错误！')</script>");
                return;
            }
            if (objUsersEN.Password != this.txtPassword.Text.Trim())
            {
                Response.Write("<script>alert('用户名或密码错误！')</script>");
                return;
            }
            ErrorInformationBL.AddInformation("Index", "ImageButton1_Click", "登录：UserId=" + strUserId, strUserId); 


            this.Set_QxUserInfoToSession();
            //Response.Redirect("wfmSelectRoles_WebApplications.aspx?UserPrjId=" + getUserPrjId);
            Response.Redirect("wfmSelectUserPrjAndRole_GeneralPlatform.aspx");
        
            //else if (clsQxUsersBL.funGetRecCountByCond(clsQxUsersEN._CurrTabName, " UserId='" + this.txtUserId.Text.Trim() + "' and Password='" + this.txtPassword.Text.Trim() + "'") > 0)
            //{

            //    this.Set_QxUserInfoToSession();

            //    Response.Redirect("wfmSelectUserPrjAndRole_GeneralPlatform.aspx");


            //}
            //else
            //{
            //    Response.Write("<script>alert('用户名或密码错误！')</script>");
            //}


			

        }
}
}
