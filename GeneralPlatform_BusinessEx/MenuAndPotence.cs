///该类为统一平台客户端信息处理类，目标为方便各个应用系统编程，实现和统一平台的无缝结合
///本dll为web版
///目前版本：V0.31，
///定义时间：2005年8月15日
///最后修改：2005年8月28日
///最后修改者：鲍文俊
///
///修改日志：
///
///2005年8月15日：
///1。完成dll类的初步功能
///2。交付初步测试
///
///2005年8月22日
///1。添加了用户修改当前口令的接口函数
///2。修改并完善了权限等级的功能函数
///
///2005年8月28日
///1。添加用户登录的函数接口 便于每个系统自己制作登录页面
///2。添加返回用户系统角色列表的接口，便于用户自己制作登录页后查询并显示用户的多角色，供选择
///
///
///2005年8月31日
///1。修改了获取当前项目的属性方法，在取当前项目前判断Session中有项目号则取session中的，否则取config文件中的
///
///2005年11月21日
///1。增加函数，返回本项目的角色列表
///
///2005年11月22日
///1。增加函数，通过接口添加一个帐号和所属角色
///2。增加函数，通过接口删除一个帐号的角色
///3。增加函数，通过接口增加一个帐号的角的
///
///2005年12月21日
///1。增加函数，Get_PotenceSymbolForCurrentView 获取用户在当前页面的使用标志，配合新修改的数据库和view
///		优点：可以不需要在登陆以后加载权限列表，直接到view中查询，凡是修改好权限设置以后，不用重新登陆就立即生效
///


using System;
using System.Collections;
using System.Data;
using System.Configuration;
using System.Text;
using System.Web;
using com.taishsoft.commdb;
using SpecData;
using System.Collections.Generic;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
namespace GeneralPlatform.BusinessLogic
{
	/// <summary>
	/// Class1 的摘要说明。
	/// </summary>
	public class MenuAndPotence : System.Web.UI.Page
	{
		private ArrayList objPotenceArr =new ArrayList();
		private string mstrModuleName;
		private const string EXCEPTION_MSG = "there was an error in the method. please see the Application Log for details.";
//		private const string ConnectString = "server=202.121.51.61;uid=sa;pwd=xxb123;database=General_Platform";
        //		private const string ConnectString = "server=202.121.51.55;uid=pyf;pwd=a1b2c3;database=GeneralPlatform_GP";
        private string ConnectString = clsSpecSQL.strConnectString; // "server=59.78.151.121;uid=pyf;pwd=a1b2c3;database=GeneralPlatform_GP";

		

		public MenuAndPotence()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//

			if(Session["alUserPotences"]!=null)
			{
				this.objPotenceArr= (ArrayList)Session["alUserPotences"];
			}

			mstrModuleName=this.GetType().ToString();

		
		}



		/// <summary>
		/// 类属性
		/// </summary>
		#region "Properties"

		public ArrayList PotenceArr
		{
			get
			{
				return this.objPotenceArr;

			}
			
		}


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
		
		public string CurrentPrjId
		{
			get
			{
				if(Session[conQxProjects.QxPrjId]!=null)
				{
					return Session[conQxProjects.QxPrjId].ToString();
				}
				else
				{
					if(ConfigurationSettings.AppSettings[conQxProjects.QxPrjId]!=null)
					{
						return ConfigurationSettings.AppSettings[conQxProjects.QxPrjId].ToString();
					}
					else
					{
						return "0";
					}
				}
			}
			set
			{
				Session.Add(conQxProjects.QxPrjId,value);
			}
		}


	  
		#endregion 

		/// <summary>
		/// 公共方法
		/// </summary>
		#region "Public Methods"

		/// <summary>
		/// 用户登录接口函数
		/// </summary>
		/// <param name="strUserId">用户号</param>
		/// <param name="strUserPassword">用户口令</param>
		/// <returns>正确返回 true</returns>
		public bool UserLoginBak(string strUserId , string strUserPassword)
		{
			if(this.clsQxUsers_funGetRecCountByCond(" UserId='"+strUserId+"' and Password='"+strUserPassword+"'")>0)
			{
				return true;
			}
			else
			{
				return false;
			}

		}

        /// <summary>
        /// 用户登录接口函数
        /// </summary>
        /// <param name="strUserId">用户号</param>
        /// <param name="strUserPassword">用户口令</param>
        /// <returns>正确返回 true</returns>
        public bool UserLogin(string strUserId, string strUserPassword)
        {
            clsQxUsersEN objUsers = clsQxUsersBL.GetObjByUserId(strUserId);
            if (objUsers == null)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return false;
            }
            if (objUsers.Password != strUserPassword)
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                return false;
            }
            return true;
            //if(this.clsQxUsers_funGetRecCountByCond(" UserId='"+strUserId+"' and Password='"+strUserPassword+"'")>0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

        }

		/// <summary>
		/// 返回帐户当前状态号
		/// </summary>
		/// <param name="strUserId">帐户名</param>
		/// <returns>状态号：01表示正常，02表示暂停，0表示没有该用户</returns>
		public string Get_UserStateId(string strUserId)
		{
			if(this.clsQxUsers_IsExist(strUserId))
			{
				string strUserStateId = this.clsQxUsers_funGetFldValue("UserStateId"," UserId = '"+strUserId+"'")[0].ToString();
				return strUserStateId;

			}
			else
			{
				return "0";

			}
		}

		/// <summary>
		/// 获取该帐户在本系统中的角色列表，其中包含列：用户号 UserId ，姓名UserName， 角色号RoleId ，角色名称RoleName
		/// </summary>
		/// <param name="strUserId">用户号</param>
		/// <returns>数据表，其中包含列：用户号 UserId ，姓名UserName， 角色号RoleId ，角色名称RoleName </returns>
		public DataTable Get_QxRoles(string strUserId)
		{
			DataTable objDt = new DataTable();
             
			objDt = this.Get_QxUserRoleRelationByJoinUsers(strUserId ,this.CurrentPrjId);

			return objDt;

		}

		/// <summary>
		/// 获取角色权限列表
		/// </summary>
		/// <param name="strRoleId"></param>
		public void Get_QxUserRolePotence(string strRoleId)
		{

			DataTable objDt=this.clsQxUserGroupPotence_GetQxUserGroupPotence(" RoleId='"+this.RoleId+"' and QxPrjId='"+this.CurrentPrjId+"'");
				
			foreach(DataRow dr in objDt.Rows)
			{
				this.objPotenceArr.Add(dr["PotenceId"].ToString());

			}

			Session.Add("alUserPotences", objPotenceArr);

		}
		
		/// <summary>
		/// 获取用户在当前页面的使用等级
		/// </summary>
		/// <param name="ViewId">界面编号</param>
		/// <returns>返回等级号，0表示没有权使用</returns>
		public string Get_PotenceLevel(string ViewId)
		{
			if(this.objPotenceArr.Count!=0)
			{
				
				DataTable objDt = clsQxViewPotence_GetQxViewPotence(" Viewid='"+ViewId+"' order by level");

				foreach(DataRow dr in objDt.Rows)
				{
					if(objPotenceArr.Contains(dr["PotenceId"].ToString()))
					{
						return dr["Level"].ToString();
					}
					
					
				}

				return "0";

			}
			else
			{
				return "0";
			}
		

		}

		/// <summary>
		/// 获取用户在当前页面的使用标志
		/// </summary>
		/// <param name="ViewId">界面编号</param>
		/// <returns>返回等级号，0表示没有权使用</returns>
		public string Get_PotenceSymbolForCurrentView(string ViewId)
		{
			string strSymbol;
			clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
			List<string>  objArr = objSQL.GetFldDataOfTable("vPotenceSymbolForRole","SymbolForProgramme"," ViewId ='"+ViewId+"' and RoleId = '"+RoleId+"'");
			if(objArr.Count > 0)
			{
				strSymbol = objArr[0].ToString();
			}
			else
			{
				strSymbol = "";
			}

			return strSymbol;
		

		}

		/// <summary>
		/// 获取用户当前系统中的菜单
		/// </summary>
		/// <returns>以html形式返回的菜单</returns>
		public string Get_QxUserMenu4CurrentUser()
		{
			return 	this.GetQxUserMenuHTML(this.CurrentPrjId,this.RoleId,this.UserId);
		}
		
		
		/// <summary>
		/// 修改当前用户的系统口令
		/// </summary>
		/// <param name="strOldPassword">用户当前的密码，用以验证</param>
		/// <param name="strNewPassword">用户需要修改的新密码</param>
		/// <returns>修改成功，返回true，失败返回false</returns>
		public bool Change_CurrentUserPassword(string strOldPassword,string strNewPassword)
		{
			if(clsQxUsers_IsExistCondRec(" UserId = '"+this.UserId+"' and Password = '"+strOldPassword+"'"))
			{
				clsQxUsers_funSetFldValue("Password",strNewPassword," UserId='"+this.UserId+"'");
				return true;
			}
			else
			{
				return false;
			}

		}

		/// <summary>
		/// 修改给定用户的系统口令
		/// </summary>
		/// <param name="strOldPassword">用户当前的密码，用以验证</param>
		/// <param name="strNewPassword">用户需要修改的新密码</param>
		/// <returns>修改成功，返回true，失败返回false</returns>
		public bool Change_QxUserPassword(string strUserId,string strUserPassword,string strCurrentUserPassword)
		{
			if(clsQxUsers_IsExistCondRec(" UserId = '"+this.UserId+"' and Password = '"+strCurrentUserPassword+"'"))
			{
				if(clsQxUsers_IsExistCondRec(" UserId = '"+strUserId+"'"))
				{
					clsQxUsers_funSetFldValue("Password",strUserPassword," UserId='"+strUserId+"'");
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}

		}

		/// <summary>
		/// 检查用户当前登陆信息是否正确
		/// </summary>
		/// <returns></returns>
		public bool Check_Login(string requestUserId,string requestUserStateId,string requestRoleId)
		{
			if(requestUserId!="0" || requestUserStateId!="0" || requestRoleId != "0" )
			{
				Session.Add("UserId",requestUserId);
				Session.Add("UserStateId",requestUserStateId);
				Session.Add("RoleId",requestRoleId);
			
				return true;
			}
			else
			{
				return false;

			}

		}

		/// <summary>
		/// 获取当前项目的角色列表
		/// </summary>
		/// <returns></returns>
		public DataTable Get_CurrPrjRoles()
		{
			return this.Get_QxRolesOfPrj(this.CurrentPrjId);
		}


		/// <summary>
		/// 添加一个用户帐号,并设置角色
		/// </summary>
		/// <param name="UserId"></param>
		/// <param name="UserName"></param>
		/// <param name="Password"></param>
		public void Add_QxUserAndRoleIntoUsersForCurrPrj(string UserId ,string UserName,string Password,string RoleId)
		{
			
			this.AddaUserIntoUsers(UserId,UserName,Password);

			this.AddRoleIdForUser(UserId,RoleId,this.CurrentPrjId);

		}


		/// <summary>
		/// 为帐号删除一个角色
		/// </summary>
		/// <param name="UserId"></param>
		/// <param name="RoleId"></param>
		public void Delete_QxRoleForUser(string UserId ,string RoleId)
		{
			this.DelRoleIdForUser(UserId,RoleId,this.CurrentPrjId);

		}



		/// <summary>
		/// 为帐号添加一个当前项目中的角色
		/// </summary>
		/// <param name="UserId"></param>
		/// <param name="RoleId"></param>
		public void Add_QxRoleForUser(string UserId ,string RoleId)
		{
			this.AddRoleIdForUser(UserId,RoleId,this.CurrentPrjId);

		}








		
		#endregion 


		/// <summary>
		/// 私有方法
		/// </summary>
		#region "Private Methods"


		/// <summary>
		/// 获取用户角色关系表
		/// </summary>
		/// <param name="strUserId">帐号</param>
		/// <param name="strUserPrjId">项目号</param>
		/// <returns>数据表</returns>
		private DataTable Get_QxUserRoleRelationByJoinUsers(string strUserId,string strUserPrjId)
		{
			StringBuilder sb=new StringBuilder("");
			sb.AppendFormat(" select {0}.mId UserRoleRelationmId , ",
                clsQxUserRoleRelationEN._CurrTabName);
			sb.AppendFormat(" {0}.UserId UserId , ",
                clsQxUserRoleRelationEN._CurrTabName);
			sb.AppendFormat(" Users.UserName UserName , ");
			sb.AppendFormat(" {0}.QxPrjId UserRoleRelationPrjId , ",
                clsQxUserRoleRelationEN._CurrTabName);
			sb.AppendFormat(" QxProjects.PrjName ProjectsPrjName , ");
			sb.AppendFormat(" {0}.RoleId RoleId , ",
                clsQxUserRoleRelationEN._CurrTabName);
			sb.AppendFormat(" UserRoles.Role Role ,");
			sb.AppendFormat(" {0}.Memo UserRoleRelationMemo ",
                clsQxUserRoleRelationEN._CurrTabName);
			sb.AppendFormat(" from {0} left join Users on ({0}.UserId = Users.UserId) ",
                clsQxUserRoleRelationEN._CurrTabName);
			sb.AppendFormat(" left join UserRoles on ({0}.RoleId = UserRoles.RoleId) ",
                clsQxUserRoleRelationEN._CurrTabName);
			sb.AppendFormat(" left join QxProjects on ({0}.QxPrjId = QxProjects.QxPrjId) ",
                clsQxUserRoleRelationEN._CurrTabName);
			
			sb.AppendFormat(" where Users.UserId = '{0}'" ,strUserId);
			sb.AppendFormat(" and {0}.QxPrjId = '{0}'" ,strUserPrjId,
                clsQxUserRoleRelationEN._CurrTabName);

			clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
			
			DataTable objDt = objSQL.GetDataTable(sb.ToString());

			return objDt;

		}


		/// <summary>
		/// 功能：获取当前表中的符合条件的某字段的值，以列表返回
		/// </summary>
		/// <param name="strFldName">字段名</param>
		/// <param name="strCondition">条件串</param>
		/// <returns>获取的字段值列表</returns>
		private List<string>  clsQxUsers_funGetFldValue(string strFldName, string strCondition) 
		{
			clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
			List<string>  arrList = objSQL.GetFldDataOfTable(clsQxUsersEN._CurrTabName, strFldName, strCondition);
			return arrList;
		}



		/// <summary>
		/// 是否存在一个帐户
		/// </summary>
		/// <param name="strUserId"></param>
		/// <returns></returns>
		private bool clsQxUsers_IsExist(string strUserId)
		{
			clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
			if (objSQL.IsExistRecord(clsQxUsersEN._CurrTabName, "UserId=" + "'"+ strUserId + "'") )
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 系统是否存在一个角色
		/// </summary>
		/// <param name="strUserId"></param>
		/// <returns></returns>
		private bool IsExistRoleIdForPrj(string strRoleId,string strPrjId)
		{
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
			clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
			if (objSQL.IsExistRecord(clsQxRolesEN._CurrTabName, "RoleId=" + "'"+ strRoleId + "' and QxPrjId='"+strPrjId+"'") )
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 添加一个用户帐号
		/// </summary>
		/// <param name="strUserId"></param>
		/// <param name="strUserName"></param>
		/// <param name="strPassword"></param>
		/// <returns></returns>
		private bool AddaUserIntoUsers(string strUserId,string strUserName,string strPassword)
		{
			if(!this.clsQxUsers_IsExist(strUserId))
			{
				string strSQL = string.Format(" insert into users values ('{0}','{1}','00000001','01','{2}','{3}')",strUserId,strUserName,strPassword,this.getTodayStr(0));

				clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
				if (objSQL.ExecSql(strSQL))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 为帐户增加一个角色
		/// </summary>
		/// <param name="strUserId"></param>
		/// <param name="strRoleId"></param>
		/// <param name="strPrjId"></param>
		/// <returns></returns>
		private bool AddRoleIdForUser(string strUserId ,string strRoleId , string strPrjId)
		{
			if(this.IsExistRoleIdForPrj(strRoleId,strPrjId))
			{
				this.DelRoleIdForUser(strUserId,strRoleId,strPrjId);

				string strSQL = string.Format("insert into {4} values ('{0}','{1}','{2}','{3}')",
                    strUserId, strRoleId, strPrjId, this.getTodayStr(0),
                clsQxUserRoleRelationEN._CurrTabName);

                clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
				if (objSQL.ExecSql(strSQL))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}



		}


		/// <summary>
		/// 为帐户删除一个角色
		/// </summary>
		/// <param name="strUserId"></param>
		/// <param name="strRoleId"></param>
		/// <param name="strPrjId"></param>
		/// <returns></returns>
		private bool DelRoleIdForUser(string strUserId ,string strRoleId , string strPrjId)
		{

			string strSQL = string.Format("delete from {3} where UserId = '{0}' and RoleId = '{1}' and QxPrjId = '{2}'", 
                strUserId,strRoleId,strPrjId,
                clsQxUserRoleRelationEN._CurrTabName);

			clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
			if (objSQL.ExecSql(strSQL))
			{
				return true;
			}
			else
			{
				return false;
			}


		}

		/// <summary>
		/// 功能：获取当前日期的字符串
		/// 日期格式：
		///    日期的字符串的格式有三种：
		///		1、YYYYMMDD。	例如20050120
		///		2、YYYY-MM-DD	例如2005-01-20
		///		3、YYYY/MM/DD	例如2005/01/20
		/// </summary>
		/// <param name="intFormat">日期格式，共有3种，传入参数0,1，2
		///							参数不同，函数返回值就不同，
		///							参见上面的日期格式
		///	</param>
		/// <returns>返回当前日期的字符串</returns>
		private string getTodayStr(int intFormat)
		{
			string strToday;
			string strYear, strMonth, strDay;
			int intYear, intMonth, intDay;
			intYear = System.DateTime.Today.Year;
			intMonth = System.DateTime.Today.Month;
			intDay = System.DateTime.Today.Day;
			strYear = intYear.ToString().Trim();
			if (intMonth>9) strMonth = intMonth.ToString().Trim();
			else strMonth = "0" + intMonth.ToString().Trim();
			if (intDay>9) strDay = intDay.ToString().Trim();
			else strDay = "0" + intDay.ToString().Trim();
			strToday = strYear + strMonth + strDay;
			switch(intFormat)
			{
				case 0:
					strToday = strYear + strMonth + strDay;
					break;
				case 1:
					strToday =strYear + "-" + strMonth + "-" + strDay;
					break;
				case 2:
					strToday =strYear + "/" + strMonth + "/" + strDay;
					break;
			}
			return strToday;
		}


		/// <summary>
		/// 通过条件获取用户组权限
		/// </summary>
		/// <param name="strCondition"></param>
		/// <returns></returns>
		private  System.Data.DataTable clsQxUserGroupPotence_GetQxUserGroupPotence(string strCondition)
		{
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
			strSQL = string.Format("Select * from {0} where {1}", clsQxUserGroupPotenceEN._CurrTabName, strCondition);
			objDT = objSQL.GetDataTable(strSQL);
			return objDT;
		}



		/// <summary>
		/// 获取当前角色的顶层菜单列表，以DATATABLE的形式返回
		/// </summary>
		/// <param name="strCondtion"></param>
		/// <returns>以DATATABLE形式表示的顶层菜单列表</returns>
		private System.Data.DataTable clsQxRoleMenusEx_GetUpMenuTable(string strRoleId, string strPrjId)  
		{
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
			StringBuilder strSQL = new StringBuilder() ;
			System.Data.DataTable objDT ;
			clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
			strSQL.Append( "SELECT TOP 100 PERCENT dbo.QxRoleMenus.MenuId, dbo.QxPrjMenus.MenuName, ");
			strSQL.Append( " dbo.QxPrjMenus.UpMenuId, dbo.QxPrjMenus.LinkFile, dbo.QxPrjMenus.ImgFile, ");
			strSQL.Append( " dbo.QxPrjMenus.OrderNum, dbo.QxRoleMenus.QxPrjId, dbo.QxRoleMenus.RoleId ");
			strSQL.Append( " FROM dbo.QxPrjMenus RIGHT OUTER JOIN ");
			strSQL.Append( " dbo.QxRoleMenus ON dbo.QxPrjMenus.MenuId = dbo.QxRoleMenus.MenuId");
			strSQL.AppendFormat( " WHERE (dbo.QxRoleMenus.RoleId = '{0}') AND (dbo.QxPrjMenus.UpMenuId = '00000000') AND ", 
				strRoleId);
			strSQL.AppendFormat( "( dbo.QxRoleMenus.QxPrjId = '{0}')",
				strPrjId);
			strSQL.Append( " ORDER BY dbo.QxPrjMenus.OrderNum");
			try
			{
				objDT = objSQL.GetDataTable(strSQL.ToString());
			}
			catch (Exception objException )
			{
				LogError(objException);
				throw new Exception(EXCEPTION_MSG, objException);
			}
			finally
			{
			}
			return objDT;
		}


		/// <summary>
		/// 获取当前角色的顶层菜单列表，以DATATABLE的形式返回
		/// </summary>
		/// <param name="strCondtion"></param>
		/// <returns>以DATATABLE形式表示的顶层菜单列表</returns>
		private System.Data.DataTable clsQxRoleMenusEx_GetSubMenuTable(string strRoleId, string strPrjId)  
		{
            if (string.IsNullOrEmpty(strRoleId) == true)
            {
                string strMsg = string.Format("角色Id不能为空，可能登录不用时间过长，请重新登录后，再进行该操作！");
                throw new Exception(strMsg);
            }
			StringBuilder strSQL = new StringBuilder() ;
			System.Data.DataTable objDT ;
			clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
			strSQL.Append( "SELECT TOP 100 PERCENT dbo.QxRoleMenus.MenuId, dbo.QxPrjMenus.MenuName, ");
			strSQL.Append( " dbo.QxPrjMenus.UpMenuId, dbo.QxPrjMenus.LinkFile, dbo.QxPrjMenus.ImgFile, ");
			strSQL.Append( " dbo.QxPrjMenus.OrderNum, dbo.QxRoleMenus.QxPrjId, dbo.QxRoleMenus.RoleId ");
			strSQL.Append( " FROM dbo.QxPrjMenus RIGHT OUTER JOIN ");
			strSQL.Append( " dbo.QxRoleMenus ON dbo.QxPrjMenus.MenuId = dbo.QxRoleMenus.MenuId");
			strSQL.AppendFormat( " WHERE (dbo.QxRoleMenus.RoleId = '{0}') AND (dbo.QxPrjMenus.UpMenuId <> '00000000') AND ", 
				strRoleId);
			strSQL.AppendFormat( " (dbo.QxRoleMenus.QxPrjId = '{0}')",
				strPrjId);
			strSQL.Append( " ORDER BY dbo.QxPrjMenus.OrderNum");
			try
			{
				objDT = objSQL.GetDataTable(strSQL.ToString());
			}
			catch (Exception objException )
			{
				LogError(objException);
				throw new Exception(EXCEPTION_MSG, objException);
			}
			finally
			{
			}
			return objDT;
		}

		/// <summary>
		/// 功能：获取当前表中的符合条件的某字段的值，以列表返回
		/// </summary>
		/// <param name="strFldName">字段名</param>
		/// <param name="strCondition">条件串</param>
		/// <returns>获取的字段值列表</returns>
		private List<string>  clsQxUserMenus_funGetFldValue(string strFldName, string strCondition) 
		{
			clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
			List<string>  arrList = objSQL.GetFldDataOfTable("UserMenus", strFldName, strCondition);
			return arrList;
		}

		/// <summary>
		/// 功能：设置当前表中的符合条件的某字段的值
		/// </summary>
		/// <param name="strFldName">字段名</param>
		/// <param name="strValue">值</param>
		/// <param name="strCondition">条件串</param>
		/// <returns>影响的记录数</returns>
		private int clsQxUsers_funSetFldValue(string strFldName, string strValue, string strCondition) 
		{
			clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
			int intRecCount = objSQL.SetFldDataOfTable(clsQxUsersEN._CurrTabName, strFldName, strValue, strCondition);
			return intRecCount;
		}


		/// <summary>
		/// 功能：判断是否存在某一条件的记录
		/// </summary>
		/// <param name="strCondition">条件串</param>
		/// <returns>如果存在就返回TRUE，否则返回FALSE</returns>
		private bool clsQxUsers_IsExistCondRec(string strCondition)
		{
			clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
			if (objSQL.IsExistRecord(clsQxUsersEN._CurrTabName, strCondition))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private System.Data.DataTable clsQxViewPotence_GetQxViewPotence(string strCondition)
		{
			string strSQL; 
			System.Data.DataTable objDT; 
			clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
			strSQL = "Select * from QxViewPotence where " + strCondition;
			objDT = objSQL.GetDataTable(strSQL);
			return objDT;
		}

		/// <summary>
		/// 功能：获取当前表中满足条件的记录数
		/// </summary>
		/// <param name="strCondtion">所给定的记录条件</param>
		/// <returns>记录数，为整型</returns>
		public int clsQxUsers_funGetRecCountByCond(string strCondtion)
		{
			clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
			int intRecCount = objSQL.GetRecCount(clsQxUsersEN._CurrTabName, strCondtion);
			return intRecCount;
		}

		private string GetQxUserMenuHTML(string strCurrPrjId, string strCurrUserRoleId, string strUserId)
		{

			System.Data.DataTable objDTUpMenu=null, objDTSubMenu=null;
			
			///操作步骤：
			///1、从SESSION取出当前的用户ID(在每个界面上添加一个用户ID的属性，免除每次都必须操作SESSION)。
			///2、从用户表得出当前用户的角色ID。	
			///3、从Web.Config取出当前的工程ID			
			///4、根据用户ID到<用户菜单信息表>中获取<是否用角色菜单>，
			///   若为TRUE，则根据<角色ID>从<角色菜单表>和<工程菜单表>获取当前<用户ID>的菜单，
			///       并且按OrderNum排序；
			///   否则就到<用户菜单详细信息表>和<工程菜单表>获取当前用户的菜单列表。
			///   获取的表作为DATATABLE(objDT)返回。					
			///5、根据获取的用户菜单列表，组织成HTML菜单串。						
			///6、把菜单HTML菜单串显示到界面上。						
			///7、结束。

	
			List<string>  arrList = new List<string> ();
//			clsQxPrjMenusBLEx objPrjMenuEx = new clsQxPrjMenusBLEx();
			StringBuilder strCondition = new StringBuilder();
			StringBuilder strHtml=new StringBuilder();		//需要插入的HTML代码
			StringBuilder strMenuSubItem = new StringBuilder();
			string strMenuId, strUpMenuId;
			int intMainMenuRow, intSubMenuRow;
			string strMainMenuName, strSubMenuName, strLinkFile, strMainImgFile, strSubImgFile;
			bool bolIsUseRoleMenu;		//判断当前用户是否用角色菜单。

			///操作步骤CODE实现：
				
			///4、根据用户ID到<用户菜单信息表>中获取<是否用角色菜单>，
			///   若为TRUE，则根据<角色ID>从<角色菜单表>和<工程菜单表>获取当前<用户ID>的菜单，
			///       并且按OrderNum排序；
			///   否则就到<用户菜单详细信息表>和<工程菜单表>获取当前用户的菜单列表。
			///   获取的表作为DATATABLE(objDT)返回。	
			///   
			
			string strTemp="true";

			arrList = clsQxUserMenus_funGetFldValue("IsUseRoleMenu","UserId = '" + strUserId +"'");

			if(arrList.Count!=0)
			{
				strTemp = arrList[0].ToString();
			}
			
			bolIsUseRoleMenu = bool.Parse(strTemp);

			if (bolIsUseRoleMenu==true)		//如果使用角色菜单，即用户本身没有自定义菜单。
			{
				///获取顶层菜单
				objDTUpMenu = clsQxRoleMenusEx_GetUpMenuTable(strCurrUserRoleId, strCurrPrjId);
				///获取子菜单
				objDTSubMenu = clsQxRoleMenusEx_GetSubMenuTable(strCurrUserRoleId, strCurrPrjId);
			}
			else
			{
				return "";
			}
			///5、根据获取的用户菜单列表，组织成HTML菜单串。						
			intMainMenuRow = 1;
			foreach ( DataRow MainMenuRow in objDTUpMenu.Rows)
			{
				strMenuId = MainMenuRow["MenuId"].ToString();	//获取主菜单项ID
				strMainMenuName = MainMenuRow["MenuName"].ToString(); //获取主菜单项NAME
				strMainImgFile = MainMenuRow["ImgFile"].ToString();
				strHtml.Append("<DIV align=\"left\" class=\"style1\">");
				strHtml.AppendFormat("<TABLE width='94%' border='0' cellPadding='0' cellSpacing='0' borderColor='#2953c0' ID='Table{0}' class=\"style1\" >\n", 
					intMainMenuRow);
				strHtml.Append("<TBODY>\n");
				strHtml.Append("<TR>\n");
				strHtml.Append("<TD width='100%' align='left'>\n");
				strHtml.AppendFormat("<A title='单击展开！' onclick='showthis(\"menu{0}\");'>\n", 
					intMainMenuRow);
				strHtml.AppendFormat("&nbsp;<img src='{1}' width='12' height='12'>{0}\n",
					strMainMenuName, strMainImgFile);
				strHtml.Append("</A>\n");
				strHtml.Append("</TD>\n");
				strHtml.Append("</TR>\n");
				strHtml.Append("</TBODY>\n");
				//				div1.Attributes.Add("class","style1");
				strHtml.Append("</TABLE>\n");
				strHtml.Append("</DIV>");
				strHtml.AppendFormat("<table width=\"100%\" border=\"0\" id=\"menu{0}\" class=\"style2\" style=\"DISPLAY:none\">\n", 
					intMainMenuRow);
				intSubMenuRow=1;
				foreach ( DataRow SubMenuRow in objDTSubMenu.Rows)
				{
					strUpMenuId = SubMenuRow["UpMenuId"].ToString();

					if (strMenuId == strUpMenuId)
					{
						strSubMenuName = SubMenuRow["MenuName"].ToString(); //获取主菜单项NAME
						strSubImgFile = SubMenuRow["ImgFile"].ToString();
						strLinkFile = SubMenuRow["LinkFile"].ToString();

						strHtml.Append("<tr>\n");
						strHtml.Append("	<td align=\"left\">\n");
						strHtml.AppendFormat("	&nbsp;&nbsp;<img src=\"{0}\" width=\"12\" height=\"12\" border=\"0\">\n",
							strSubImgFile);
						strHtml.AppendFormat("<A href=\"{0}\" target=\"main\">{1}</A>\n",
							strLinkFile, strSubMenuName);
						strHtml.Append("</td>\n");
						strHtml.Append("</tr>\n");
					}

					intSubMenuRow ++;
				}
				strHtml.Append("</table>\n");
				intMainMenuRow ++;
			}

			///6、把菜单HTML菜单串显示到界面上。						
			return strHtml.ToString();
		}

		/// <summary>
		/// 获取系统的角色列表
		/// </summary>
		/// <param name=conQxProjects.QxPrjId>项目编号</param>
		/// <returns>数据表</returns>
		private DataTable Get_QxRolesOfPrj(string strPrjId)
		{
			string strSQL = string.Format("select RoleId,RoleName from {0} where QxPrjId='"+strPrjId+"'",
                clsQxRolesEN._CurrTabKeyFldName);
			clsSpecSQL objSQL = new clsSpecSQL(ConnectString);
			DataTable objDt = objSQL.GetDataTable(strSQL);
			return objDt;

		}

	


		private void LogError(Exception  objException  )
		{
			//Log the error information to the Application Log
			string strLogMsg ;
			try
			{
 
				strLogMsg = "An error occurred in the following module: "
					+ mstrModuleName +  "\nSource: " + objException.Source 

					+ "Message: " + objException.Message + "\n" 
					+ "Stack Trace:  " + objException.StackTrace 

					+ "Target Site:  " + objException.TargetSite.ToString();
        
				//Write error to event log
				System.Diagnostics.EventLog.WriteEntry(mstrModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
			}
			catch
			{
			}
		}



		#endregion 


	}
}

