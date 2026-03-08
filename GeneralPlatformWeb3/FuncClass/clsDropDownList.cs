using System;
using System.Data;
using System.Web.UI.WebControls;
//using SqlSv; 
using SpecData;
using System.Collections;
using com.taishsoft.commdb;
using GeneralPlatform;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;

namespace GeneralPlatform.Webform
{
	/// <summary>
	/// clsCommForWebForm 的摘要说明。
	/// </summary>
	public class clsDropDownList
	{
		public	static string  SystemStatus = "NDEBUG";		///主要存贮当前系统的状态

		public clsDropDownList()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		public static System.Data.DataTable GetCollege()
		{
			//获取学院所有信息
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable("select Name, clgId from college");
			return objDT;
		}

		public static System.Data.DataTable GetCtlTypeId()
		{
			//获取某学院所有专业信息
			string strSQL = "select CtlTypeId, CtlTypeName from CtlTypeAbbr";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public static System.Data.DataTable GetQueryOptionId()
		{
			//获取某学院所有专业信息
			string strSQL = "select QueryOptionId, QueryOption from QueryOption";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}

		public static System.Data.DataTable GetDDLItemsOption()
		{
			//获取某学院所有专业信息
			string strSQL = "select DDLItemsOptionId, DDLItemsOption from DDLItemsOption";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}



		//public static System.Data.DataTable GetMajor(string strClgId)
		//{
		//	//获取某学院所有专业信息
		//	string strSQL = "select Name, MajorId from Major where ClgId='" + strClgId + "'";
		//	clsSpecSQLforSql mySql=new clsSpecSQLforSql();
		//	System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
		//	return objDT;
		//}
		public static System.Data.DataTable GetTaskTypeId()
		{
			//获取某学院所有专业信息
			string strSQL = "select TaskTypeId, RWLBMC from RWLBB ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public static void BindDdl_TaskTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetTaskTypeId();
			objDDL.DataValueField="TaskTypeId";
			objDDL.DataTextField="RWLBMC";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}

		public static void BindDdl_College(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为下拉框学院设置内容
			ListItem li=new ListItem("请选择...","请选择...");
			System.Data.DataTable objDT = GetCollege();
			objDDL.DataValueField="ClgId";
			objDDL.DataTextField="Name";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}

		///生成从界面层到逻辑层的数据传输函数代码
        public static System.Data.DataTable GetViewTypeCode(string strApplicationTypeId)
		{
			//获取某学院所有专业信息
            string strSQL = "select ViewTypeCode, ViewTypeName from ViewTypeCodeTab where ApplicationTypeId = '" + strApplicationTypeId + "'";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public static void BindDdl_QxViewTypeCode(System.Web.UI.WebControls.DropDownList objDDL, string strApplicationTypeId)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
            System.Data.DataTable objDT = GetViewTypeCode(strApplicationTypeId);
			objDDL.DataValueField="ViewTypeCode";
			objDDL.DataTextField="ViewTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public static System.Data.DataTable GetQxRelaTabId(string strSqlDsTypeId, string strPrjId)
		{
			//获取某学院所有专业信息
			string strSQL = "select TabId, TabName from PrjTab where SqlDsTypeId = '" + strSqlDsTypeId + "' and QxPrjId = '" + strPrjId + "' order by tabName";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public static  void BindDdl_QxRelaTabId(System.Web.UI.WebControls.DropDownList objDDL, string strSqlDsTypeId, string strPrjId)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetQxRelaTabId(strSqlDsTypeId, strPrjId);
			objDDL.DataValueField="TabId";
			objDDL.DataTextField="TabName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public static void SetDdlValue(System.Web.UI.WebControls.DropDownList objDDL, string strValue)
		{
			for (int i = 0; i<objDDL.Items.Count; i++)
			{
				if (objDDL.Items[i].Value == strValue)
				{
					objDDL.SelectedIndex = i;
				}
			}
		}
		///生成从界面层到逻辑层的数据传输函数代码
		public static System.Data.DataTable GetApplicationTypeId()
		{
			//获取某学院所有专业信息
			string strSQL = "select ApplicationTypeId, ApplicationTypeName from ApplicationType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public static void BindDdl_ApplicationTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetApplicationTypeId();
			objDDL.DataValueField="ApplicationTypeId";
			objDDL.DataTextField="ApplicationTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
        public static void BindDdl_TrueOrFalse(System.Web.UI.WebControls.DropDownList objDDL)
        {
            ListItem li = new ListItem("请选择...", "0");
            ListItem li1 = new ListItem("是", "01");
            ListItem li2 = new ListItem("否", "00");

            objDDL.Items.Insert(0, li);
            objDDL.Items.Add(li1);
            objDDL.Items.Add(li2);
            objDDL.SelectedIndex = 0;
            //为下拉框设置内容的样例，该下拉框的列表项是直接添加的
            ///objDDL.Items.Add("男");
            ///objDDL.Items.Add("女");
        }
        ///生成从界面层到逻辑层的数据传输函数代码
        public static System.Data.DataTable GetSchoolYear()
        {
            //获取某学院所有专业信息
            string strSQL = "select SchoolYear, SchoolYear from SchoolYear ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_SchoolYear(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetSchoolYear();
            objDDL.DataValueField = "SchoolYear";
            objDDL.DataTextField = "SchoolYear";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static System.Data.DataTable GetExamineYear()
        {
            //获取某学院所有专业信息
            string strSQL = "select ExamYear, ExamYear from ExamYear ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_ExamineYear(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetExamineYear();
            objDDL.DataValueField = "ExamYear";
            objDDL.DataTextField = "ExamYear";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
     
        public static void BindDdl_DepartmentId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            string strCondition = string.Format("{0}='1'", conQxDepartmentInfo.InUse);
            DataTable objDT = clsQxDepartmentInfoBL.GetDataTable_QxDepartmentInfo(strCondition);
            objDDL.DataValueField = "DepartmentId";
            objDDL.DataTextField = "DepartmentName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static System.Data.DataTable GetDepartmentId4InUse()
        {
            //获取某学院所有专业信息
            string strSQL = string.Format("select DepartmentId, DepartmentName+'('+DepartmentId+')' as DepartmentName from {0} where InUse='1' order by OrderNum ", clsQxDepartmentInfoEN._CurrTabName);
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_DepartmentId4InUse(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDepartmentId4InUse();
            objDDL.DataValueField = "DepartmentId";
            objDDL.DataTextField = "DepartmentName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static System.Data.DataTable GetDutyId()
        {
            //获取某学院所有专业信息
            string strSQL = "select DutyId, DutyName from Duty ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_DutyId(System.Web.UI.WebControls.DropDownList objDDL)
        {//2005-11-28添加
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetDutyId();
            objDDL.DataValueField = "DutyId";
            objDDL.DataTextField = "DutyName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///生成从界面层到逻辑层的数据传输函数代码
        public static System.Data.DataTable GetSubDepartmentId(string strDepartmentId)
        {
            //获取某学院所有专业信息
            string strSQL = "select SubDepartmentId, SubDepartmentName from SubDepartment where DepartmentId = '" + strDepartmentId + "'";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_SubDepartmentId(System.Web.UI.WebControls.DropDownList objDDL, string strDepartmentId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetSubDepartmentId(strDepartmentId);
            objDDL.DataValueField = "SubDepartmentId";
            objDDL.DataTextField = "SubDepartmentName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static System.Data.DataTable GetModuleId(string strPrjId)
        {
            //获取某学院所有专业信息
            string strSQL = "select ModuleId, ModuleName from QxPrjModule where QxPrjId = '" + strPrjId + "'";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_ModuleId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetModuleId(strPrjId);
            objDDL.DataValueField = "ModuleId";
            objDDL.DataTextField = "ModuleName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static System.Data.DataTable GetPotenceId(string strPrjId)
        {
            //获取某学院所有专业信息
            string strSQL = "select PotenceId, PotenceName from QxPrjPotence where QxPrjId = '" + strPrjId + "'";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_PotenceId(
            System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetPotenceId(strPrjId);
            objDDL.DataValueField = "PotenceId";
            objDDL.DataTextField = "PotenceName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static System.Data.DataTable GetPotenceId(string strPrjId, string strPotenceTypeId)
        {
            //获取某学院所有专业信息
            string strSQL = string .Format("select PotenceId, PotenceName from {2} where QxPrjId = '{0}' and PotenceTypeId='{1}'", 
                strPrjId, strPotenceTypeId,
                clsQxPrjPotenceEN._CurrTabName);
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static System.Data.DataTable GetPotenceIdByType(string strPotenceTypeId)
        {
            //获取某学院所有专业信息
            string strSQL = string.Format("select PotenceId, PotenceName from {1} where PotenceTypeId='{0}'", 
                strPotenceTypeId,
                clsQxPrjPotenceEN._CurrTabName);
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_PotenceId(
            System.Web.UI.WebControls.DropDownList objDDL, string strPrjId, string strPotenceTypeId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetPotenceId(strPrjId, strPotenceTypeId);
            objDDL.DataValueField = "PotenceId";
            objDDL.DataTextField = "PotenceName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static void BindDdl_PotenceIdByType(
           System.Web.UI.WebControls.DropDownList objDDL, string strPotenceTypeId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetPotenceIdByType(strPotenceTypeId);
            objDDL.DataValueField = "PotenceId";
            objDDL.DataTextField = "PotenceName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
       

        public static void BindDdl_Projects(DropDownList objDdl, string strConnectString)
        {
            clsQxProjectsEN._ConnectString = strConnectString;
            DataTable objDt = clsQxProjectsBL.GetDataTable_QxProjects("1=1");
            clsQxProjectsEN._ConnectString = "";
            objDdl.DataSource = objDt;
            objDdl.DataTextField = "PrjName";
            objDdl.DataValueField = conQxProjects.QxPrjId;
            objDdl.DataBind();

            objDdl.Items.Insert(0, new ListItem("请选择...", "0"));
            objDdl.SelectedValue = "0";
        }
        public static void BindDdl_QxRoles(DropDownList objDdl, string strPrj)
        {
            string strSQL = string.Format("select * from {0} where QxPrjId = '{1}'",
                clsQxRolesEN._CurrTabName,
                strPrj);
            DataTable objDt = new clsSpecSQLforSql().GetDataTable(strSQL);
            objDdl.DataSource = objDt;
            objDdl.DataTextField = "RoleName";
            objDdl.DataValueField = "RoleId";
            objDdl.DataBind();

            objDdl.Items.Insert(0, new ListItem("请选择...", "0"));
            objDdl.SelectedValue = "0";
        }

        public static void BindDdl_Departments(DropDownList objDdl)
        {
            string strCondition = string.Format("{0}='1'", conQxDepartmentInfo.InUse);
            DataTable objDt = clsQxDepartmentInfoBL.GetDataTable_QxDepartmentInfo(strCondition);
            objDdl.DataSource = objDt;
            objDdl.DataTextField = "DepartmentName";
            objDdl.DataValueField = "DepartmentId";
            objDdl.DataBind();

            objDdl.Items.Insert(0, new ListItem("请选择...", "0"));
            objDdl.SelectedValue = "0";
        }


        public static void BindDdl_QxUserState(DropDownList objDdl)
        {

            DataTable objDt = clsQxUserStateBL.GetDataTable_QxUserState("1=1");
            objDdl.DataSource = objDt;
            objDdl.DataTextField = "UserStateName";
            objDdl.DataValueField = "UserStateId";
            objDdl.DataBind();

            objDdl.Items.Insert(0, new ListItem("请选择...", "0"));
            objDdl.SelectedValue = "0";
        }

  

        public static DataTable GetQxUser()
        {
            clsSpecSQLforSql SQL = new clsSpecSQLforSql();
            return SQL.GetDataTable("select UserId,UserName+'(' + UserId + ')' as UserName from QxUsers where UserStateId = '01' order by UserName");
        }
        public static void BindDDL_UserId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetQxUser();
            objDDL.DataValueField = "UserId";
            objDDL.DataTextField = "UserName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static DataTable GetQxUserByPrjId(string strPrjId)
        {
            clsSpecSQLforSql SQL = new clsSpecSQLforSql();
            string strSQL = string.Format("select UserId,UserName+'(' + UserId + ')' as UserName from QxUsers where UserStateId = '01' And UserId in (Select UserId From QxPrjUserRelation where QxPrjId='{0}') order by UserName", strPrjId);
            return SQL.GetDataTable(strSQL);
        }
        public static void BindDdl_UserIdByPrjId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetQxUserByPrjId(strPrjId);
            objDDL.DataValueField = "UserId";
            objDDL.DataTextField = "UserName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static System.Data.DataTable GetUpMenuId(string strPrjId)
        {
            //string strPrjId = getUserPrjId;
            //获取某学院所有专业信息
            string strSQL = "select MenuId, MenuName from QxPrjMenus where UpMenuId = '00000000' and QxPrjId = '" + strPrjId + "' union select MenuId, MenuName from QxPrjMenus where MenuId = '00000000'";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_UpMenuId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetUpMenuId(strPrjId);
            objDDL.DataValueField = "MenuId";
            objDDL.DataTextField = "MenuName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static System.Data.DataTable GetPrjSiteId(string strPrjId)
        {
            //获取某学院所有专业信息
            string strSQL = string.Format( "select PrjSiteId, PrjSiteName from QxPrjSite4DownLoad  where QxPrjId='{0}'", strPrjId);
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_PrjSiteId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetPrjSiteId(strPrjId);
            objDDL.DataValueField = "PrjSiteId";
            objDDL.DataTextField = "PrjSiteName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
	}
}
