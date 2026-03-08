using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Configuration;
using GeneralPlatform;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogicEx;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// wfmTestMenu 的摘要说明。
	/// </summary>
	public partial class wfmDispUserMenu : System.Web.UI.Page
	{
		
		protected void Page_Load(object sender, System.EventArgs e)
		{
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

			//获取当前用户的权限等级编号
//			level=new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId);	

			// 在此处放置用户代码以初始化页面
			
			if (!IsPostBack)
			{
				//根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
//				switch (level)
//				{
//					case "0":
//
//						Response.Redirect("../error.aspx");
//						break;
//					
//					case "1":
//						
//						break;
//					case "2":
//						
//						break;
//
//					case "3":
//						Response.Redirect("../error.aspx");
//
//						break;
//					case "4":
//
//						Response.Redirect("../error.aspx");
//
//						break;
//
//					default:
//
//						Response.Redirect("../error.aspx");
//
//						break;
//				}


				///以下代码专为DEBUG用，在正式发布时，应该被注释-----------------------
				///
//				Session.Add("UserId", "pyf");
//				Session.Add(conQxProjects.QxPrjId, "0001");
				///以下代码专为DEBUG用，在正式发布时，应该被注释=======================
			
				//操作步骤：
				//1、从SESSION取出当前的用户ID(在每个界面上添加一个用户ID的属性，免除每次都必须操作SESSION)。
				//2、从用户表得出当前用户的角色ID。	
				//3、从Web.Config取出当前的工程ID			
				//4、根据用户ID到<用户菜单信息表>中获取<是否用角色菜单>，
				///   若为TRUE，则根据<角色ID>从<角色菜单表>和<工程菜单表>获取当前<用户ID>的菜单，
				///       并且按OrderNum排序；
				///   否则就到<用户菜单详细信息表>和<工程菜单表>获取当前用户的菜单列表。
				///   获取的表作为DATATABLE(objDT)返回。					
				//5、根据获取的用户菜单列表，组织成HTML菜单串。						
				//6、把菜单HTML菜单串显示到界面上。						
				//7、结束。

	
				ArrayList arrList = new ArrayList();
				clsQxPrjMenusBLEx objPrjMenuEx = new clsQxPrjMenusBLEx();
				StringBuilder strCondition = new StringBuilder();
				string strHtml;		//需要插入的HTML代码
				StringBuilder strMenuSubItem = new StringBuilder();
				string strUserId="0";	//当前用户ID
				string strCurrUserRoleId="0";	//当前用户的角色ID
				string strCurrPrjId="0";
//				bool bolIsUseRoleMenu;		//判断当前用户是否用角色菜单。

				//操作步骤CODE实现：
				//1、从SESSION取出当前的用户ID(在每个界面上添加一个用户ID的属性，免除每次都必须操作SESSION)。
//				clsQxUsersEN objUser;
//				objUser = (clsQxUsersEN)Session["objUser"];
//				if (objUser == null) 
//				{
//					ReturnLoginView();
//					return ;
//				}
//				if (objUser.QXDJ <= 0) 
//				{
//					ReturnLoginView();
//					return ;
//				}

				if(this.UserId=="0" || this.UserStateId!="01" || this.RoleId == "0" || getUserPrjId == "0")
				{
					this.ReturnLoginView();

				}
				else
				{
					new MenuAndPotence().Get_QxUserRolePotence(this.RoleId);


					strUserId =this.UserId;

					//2、从用户表得出当前用户的角色ID。						
					//				arrList = (new clsQxUsersEN().funGetFldValue("RoleId","UserId = '" + strUserId +"'"));
					//				strCurrUserRoleId = (string) arrList[0];
				
					
					strCurrUserRoleId =this.RoleId;
					//3、从Web.Config取出当前的工程ID		
					strCurrPrjId = this.CurrrntPrjId;
                    string strMenuSetId = "";
                    strHtml = clsGeneMenuBLEx.GetQxUserMenuHTML2(strCurrPrjId, strMenuSetId, strCurrUserRoleId , strUserId);

                    //6、把菜单HTML菜单串显示到界面上。						
                    spanMenu.InnerHtml = strHtml.ToString();
					//7、结束。
				}
				
			}
		}


		
		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    

		}
		#endregion
		public string RoleId
		{
			get
			{
				if(Session["RoleId"] != null)
				{
					return Session["RoleId"].ToString();
				}
				else
				{
					return "0";
				}
			}
			set
			{
				Session.Add("RoleId",value);
				
					
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


		public string  CurrrntPrjId
		{
			get
			{
				if(ConfigurationSettings.AppSettings[conQxProjects.QxPrjId] != null)
				{
					return ConfigurationSettings.AppSettings[conQxProjects.QxPrjId].ToString();
				}
				else
				{
					return "0";
				}
			}
		}		

		private void ReturnLoginView()
		{
			Session.Clear();
			string strMsg;
			strMsg = "对不起你的帐号状态不正确，请重新登录!";
			Response.Write("<script>alert('" + strMsg + "')</script>");
			string ss = "<script language='javascript'> parent.window.location.href='Index.aspx'</script>";
			//			string ss = "<script language='javascript'> parent.main.location.href='index.htm'</script>";
			//			string ss = "<script language='javascript'> parent.window.location.href='main1.aspx' target='main';</script>";
			Response.Write(ss);
		}
        /// <summary>
        /// 根据传递参数和选择参数决定的用户工程Id
        /// 功能：如果选择参数不为空，就返回选择参数用户工程Id，
        ///       否则就返回传递参数用户工程Id
        /// </summary>
        protected string getUserPrjId
        {
            get
            {
                if (string.IsNullOrEmpty(clsCommonSession.UserPrjId4get) == false) return clsCommonSession.UserPrjId4get;
                if (string.IsNullOrEmpty(qsUserPrjId) == false) return qsUserPrjId;
                return "";
            }
            set
            {
                clsCommonSession.UserPrjId4get = value;
            }
        }

        /// <summary>
        /// 用户选择的工程Id。例如：“0150”等
        /// 作者：潘以锋
        /// 建立日期：2016-07-01
        /// </summary>
        public string qsUserPrjId
        {
            get
            {
                if (Request.QueryString["UserPrjId"] != null)
                {
                    return Request.QueryString["UserPrjId"].ToString().Trim();
                }
                return "";
            }
        }
    }
}
