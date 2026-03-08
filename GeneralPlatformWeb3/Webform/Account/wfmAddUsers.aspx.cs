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
using GeneralPlatform;
using CommFunc4WebForm;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
namespace GeneralPlatform.Webform
{
	/// <summary>
	/// addacount 的摘要说明。
	/// </summary>
	public partial class wfmAddUsers : System.Web.UI.Page
	{
		private const string ViewId="00010101";
		private string level;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
            //检查用户Session是否存在，如果不存在就返回到主页； 
            clsPubVar.CheckUserSession();

			//获取当前用户的权限等级编号
			level=new MenuAndPotence().Get_PotenceLevel(ViewId);	

			if(!IsPostBack)
			{
				
				
				//根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
				switch (level)
				{
					case "0":

						Response.Redirect("../error.aspx");
						break;
					
					case "1":

						
						break;
					case "2":
						
						this.ddlPrj.Enabled = false;
						
						break;

					case "3":

						Response.Redirect("../error.aspx");

						break;
					case "4":

						Response.Redirect("../error.aspx");

						break;

					default:

						Response.Redirect("../error.aspx");

						break;
				}


				this.DIV1.Visible =false;

				clsQxProjectsBL.BindDdl_QxPrjIdCache(this.ddlPrj);
                this.ddlPrj.SelectedValue = getUserPrjId; 

                clsDropDownList.BindDdl_QxRoles(this.ddlRole, this.ddlPrj.SelectedValue);
                clsDropDownList.BindDdl_Departments(this.ddlDepartment);
                clsDropDownList.BindDdl_QxUserState(this.ddlUserState);
			}
			
			//获取当前用户的权限等级编号
//			level=new GeneralPlatform.clsCommForWebForm().Get_PotenceLevel(ViewId);

//			//if(Session.Count==0)		Response.Redirect("welcome.html");
//			if(Session[1].ToString()!="校级")	Response.Redirect("welcome.html");
			
//			if(!Page.IsPostBack)
//			{
//				//根据等级权限编号来确定用户可以使用什么功能，等级编号方式：1为最大2其次，依此类推
//				switch (level)
//				{
//					case "0":
//
//						Response.Redirect("../error.aspx");
//						break;
//					case "1":
//
//						
//					
//						break;
//					case "2":
//						
//						Response.Redirect("../error.aspx");
//						break;
//					case "3":
//
//						Response.Redirect("../error.aspx");
//
//						break;
//
//					default:
//						Response.Redirect("../error.aspx");
//						break;
//				}



				//				clsSpecSQLforSql mySql = new clsSpecSQLforSql();
				//				ddlXy.DataSource = mySql.GetDataTable("select * from College");
				//				ddlXy.DataValueField = "XYDM";
				//				ddlXy.DataTextField = "XYMC";
				//				ddlXy.DataBind();
				//				ddlXy.Enabled=false;

				//				fun.AddRank(this.ddlRank);



				
//			}
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
			

		protected void btnSubmit_Click(object sender, System.EventArgs e)
		{
			if(this.txtUserId.Text.Trim()=="" || clsQxUsersBL.IsExist(this.txtUserId.Text.Trim()))
			{
				Response.Write("<script>alert('帐号不正确！')</script>");
				return;
			}

			if(this.ddlPrj.SelectedValue == "0")
			{
				Response.Write("<script>alert('项目不能为空！')</script>");
				return;
			}

			if(this.ddlRole.SelectedValue=="0")
			{
				Response.Write("<script>alert('角色不能为空！')</script>");
				return;
			}

			if(this.ddlDepartment.SelectedValue =="0")
			{
				Response.Write("<script>alert('部门不能为空！')</script>");
				return;

			}

			if(this.ddlUserState.SelectedValue=="0")
			{
				Response.Write("<script>alert('状态不能为空！')</script>");
				return;
			}
		    
			if(txtPwd.Text=="")
			{
				Response.Write("<script>alert('密码不能为空！')</script>");
				return;
			}

			if(txtPwd.Text!=txtPwd2.Text)
			{
				Response.Write("<script>alert('确认密码不符！')</script>");
				return;
			}

			clsQxUsersEN objUsersEN=new clsQxUsersEN();
			objUsersEN.UserId=this.txtUserId.Text.Trim();
			objUsersEN.UserName=this.txtName.Text.Trim();
			objUsersEN.DepartmentId = this.ddlDepartment.SelectedValue;
			objUsersEN.UserStateId=this.ddlUserState.SelectedValue;
			objUsersEN.Password=this.txtPwd2.Text;
			objUsersEN.Memo = clsCommForWebForm.getTodayStr(0);
		
			clsQxUsersBL.AddNewRecordBySql2(objUsersEN);

			clsQxUserRoleRelationBL.DelQxUserRoleRelationsByCond(" UserId = '"+objUsersEN.UserId+"'");
            clsQxUserRoleRelationEN objUserRoleRelation = new clsQxUserRoleRelationEN();
			objUserRoleRelation.UserId = objUsersEN.UserId;
			objUserRoleRelation.RoleId = this.ddlRole.SelectedValue;
			objUserRoleRelation.QxPrjId = this.ddlPrj.SelectedValue;
			objUserRoleRelation.Memo = clsCommForWebForm.getTodayStr(0);
            clsQxUserRoleRelationBL.AddNewRecordBySql2(objUserRoleRelation);
			

            Response.Write("<script>alert('添加帐号成功！')</script>");


			
			
		}

//		private void PutDataToCAccount(cAccount act)
//		{
//			act.m_sUid=txtUid.Text;
//			act.m_sPwd=txtPwd.Text;
//			act.m_sRank=ddlRank.SelectedValue;
//			if(ddlXy.Enabled)
//			{
//				act.m_sSpec=ddlXy.SelectedValue;
//			}
//		}

//		protected void ddlRank_SelectedIndexChanged(object sender, System.EventArgs e)
//		{
//			if(ddlRank.SelectedValue=="学生" || ddlRank.SelectedValue=="教师" || ddlRank.SelectedValue=="导师" || ddlRank.SelectedValue=="院级")
//				ddlXy.Enabled=true;
//			else
//				ddlXy.Enabled=false;
//		}

		protected void btnPlAdd_Click(object sender, System.EventArgs e)
		{
			long xh1,xh2;
			int len,i;
			string zeros;
			try
			{
				for(i=0;i<txtXh1.Text.Length;i++)
					if(txtXh1.Text[i]!='0')  break;
				len=i;
				for(i=0;i<txtXh2.Text.Length;i++)
					if(txtXh2.Text[i]!='0')  break;
				if(len!=i)
				{
					Response.Write("<script>alert('请确保前置0的个数一致！')</script>");
					return;
				}
				zeros=txtXh1.Text.Substring(0,len);
				xh1=long.Parse(txtXh1.Text);
				xh2=long.Parse(txtXh2.Text);
			}
			catch
			{
				Response.Write("<script>alert('请正确填写学号范围！')</script>");
				return;
			}
			if(xh1>xh2)
			{
				long temp=xh1;
				xh1=xh2;
				xh2=temp;
			}

			if(txtCspwd.Text=="")
			{
				Response.Write("<script>alert('密码不能为空！')</script>");
				return;

			}
			if(txtCspwd.Text!=txtCspwd2.Text)
			{
				Response.Write("<script>alert('确认密码不符！')</script>");
				return;
			}

//			cAccount act = new cAccount();
//			act.PAddNewAccount(xh1,xh2,txtCspwd.Text,zeros);

			for (long j=xh1;j<=xh2;j++)
			{
				if(!clsQxUsersBL.IsExist(zeros+j.ToString()))
				{
                    clsQxUsersEN objUsersEN = new clsQxUsersEN();
					objUsersEN.UserId=zeros+j.ToString();
					objUsersEN.UserName="Default";
					objUsersEN.Password=this.txtCspwd2.Text;
					objUsersEN.UserStateId="01";
					clsQxUsersBL.AddNewRecordBySql2(objUsersEN);

					clsQxUserRoleRelationEN objUserRoleRelation;
					if( clsQxUserRoleRelationBL.IsExistRecord(" UserId='"+zeros+j.ToString()+"'"))
					{
						long lngMid=clsQxUserRoleRelationBL.GetFirstID_S(" UserId='"+zeros+j.ToString()+"'");
                        objUserRoleRelation = clsQxUserRoleRelationBL.GetObjBymId(lngMid);
						objUserRoleRelation.RoleId="00010005";
                        clsQxUserRoleRelationBL.UpdateBySql2(objUserRoleRelation);

					}
					else
					{
						objUserRoleRelation=new clsQxUserRoleRelationEN();
						objUserRoleRelation.UserId=zeros+j.ToString();
						objUserRoleRelation.RoleId="00010005";
						objUserRoleRelation.QxPrjId="0001";
                        clsQxUserRoleRelationBL.AddNewRecordBySql2(objUserRoleRelation);

					}

				}


			}
			
			
			Response.Write("<script>alert('帐号成批添加成功！')</script>");
		}

		protected void ddlPrj_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			clsDropDownList.BindDdl_QxRoles(this.ddlRole,this.ddlPrj.SelectedValue);
		
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
