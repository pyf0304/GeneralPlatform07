///生成与表相关的控件控制层代码
namespace GeneralPlatform.Webform
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Web;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;
    using com.taishsoft.common;
    using SpecData;
    using com.taishsoft.commdb;
    using Entity;
    using BusinessLogic;

    /// <summary>
    ///		wucDepartmentInfo 的摘要说明。
    /// </summary>
    public partial class wucDepartmentInfoBak : System.Web.UI.UserControl
	{
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
            tabHidden.Visible = false;

		}
		public string DepartmentId
		{
			get
			{
				return txtDepartmentId.Text.Trim();
			}
			set
			{
				txtDepartmentId.Text = value.ToString();
			}
		}

		public string UpDepartmentId
		{
			get
			{
				if (ddlUpDepartmentId.SelectedValue == "0")
					return "";
				return ddlUpDepartmentId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlUpDepartmentId.SelectedValue = "0";
				}
				else
				{
					ddlUpDepartmentId.SelectedValue = value;
				}
			}
		}

		public string DepartmentType
		{
			get
			{
				return txtDepartmentType.Text.Trim();
			}
			set
			{
				txtDepartmentType.Text = value.ToString();
			}
		}

		public string DepartmentName
		{
			get
			{
				return txtDepartmentName.Text.Trim();
			}
			set
			{
				txtDepartmentName.Text = value.ToString();
			}
		}

		public string DepartmentAbbrName
		{
			get
			{
				return txtDepartmentAbbrName.Text.Trim();
			}
			set
			{
				txtDepartmentAbbrName.Text = value.ToString();
			}
		}

		public string DepartMentId4Card
		{
			get
			{
				return txtDepartMentId4Card.Text.Trim();
			}
			set
			{
				txtDepartMentId4Card.Text = value.ToString();
			}
		}

		public string Memo
		{
			get
			{
				return txtMemo.Text.Trim();
			}
			set
			{
				txtMemo.Text = value.ToString();
			}
		}

		public int OrderNum
		{
			get
			{
				return int.Parse(txtOrderNum.Text.Trim());
			}
			set
			{
				txtOrderNum.Text = value.ToString();
			}
		}


		public bool IsAcademy
		{
			get
			{
				return chkIsAcademy.Checked;
			}
			set
			{
				chkIsAcademy.Checked = value;
			}
		}

		public bool IsExam
		{
			get
			{
				return chkIsExam.Checked;
			}
			set
			{
				chkIsExam.Checked = value;
			}
		}

		public string SubjectTypeId
		{
			get
			{
				if (ddlSubjectTypeId.SelectedValue == "0")
					return "";
				return ddlSubjectTypeId.SelectedValue;
			}
			set
			{
				if (value == "")
				{
					ddlSubjectTypeId.SelectedValue = "0";
				}
				else
				{
					ddlSubjectTypeId.SelectedValue = value;
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
		///		设计器支持所需的方法 - 不要使用代码编辑器
		///		修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		public void SetKeyReadOnly(bool bolReadonly)
		{
			txtDepartmentId.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			txtDepartmentId.Text = "";
			ddlUpDepartmentId.SelectedIndex = 0;
			txtDepartmentType.Text = "";
			txtDepartmentName.Text = "";
			txtDepartMentId4Card.Text = "";
			txtMemo.Text = "";
			chkIsAcademy.Checked = false;
			ddlSubjectTypeId.SelectedIndex = 0;
		}
		/// <summary>
		/// 校验自定义控件中自子控件的类型数值是否是合法正确的。
		/// 一般规则：
		///		1、首先校验类型：整型、浮点型、日期型等，
		///			这些代码由自动生成代码帮助生成
		///		2、校验最值，即最大值和最小值等
		///			这些代码由自动生成代码帮助生成
		///		这些生成内容可以修改
		/// </summary>
		/// <returns></returns>
		public bool IsValid()
		{
            if (clsString.IsNumeric(txtOrderNum.Text) == false)
            {
                return false;
            }
			return true;
		}
		/// <summary>
		/// 设置该控件在插入状态下的缺省值
		/// 一般规则：
		///		1、如果是整型就默认为0；
		///		2、如果是浮点型不默认为0.0；
		///		3、如果是日期型就默认为当前的日期；
		///		4、如果是位(bit)型就默认为false;
		///		这些默认值可以再行修改
		/// </summary>
		public void SetDefaultValue()
		{
			txtDepartmentId.Text = "";
			ddlUpDepartmentId.SelectedIndex = 0;
			txtDepartmentType.Text = "";
			txtDepartmentName.Text = "";
			txtDepartMentId4Card.Text = "";
			txtMemo.Text = "";
			chkIsAcademy.Checked = false;
			ddlSubjectTypeId.SelectedIndex = 0;
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
		public string getTodayStr(int intFormat)
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
		/// 功能：获取当前月的字符串
		/// 月的格式：
		///    月的字符串的格式有三种：
		///		1、YYYYMM。	例如200501
		///		2、YYYY-MM-DD	例如2005-01
		///		3、YYYY/MM/DD	例如2005/01
		/// </summary>
		/// <param name="intFormat">月的格式，共有3种，传入参数0,1，2
		///							参数不同，函数返回值就不同，
		///							参见上面的月的格式
		///	</param>
		/// <returns>返回当前月的字符串</returns>
		public string getCurrMonth(int intFormat)
		{
			string strCurrMonth;
			string strYear, strMonth;
			int intYear, intMonth;
			intYear = System.DateTime.Today.Year;
			intMonth = System.DateTime.Today.Month;
			strYear = intYear.ToString().Trim();
			if (intMonth>9) strMonth = intMonth.ToString().Trim();
			else strMonth = "0" + intMonth.ToString().Trim();
			strCurrMonth = strYear + strMonth;
			switch(intFormat)
			{
				case 0:
					strCurrMonth = strYear + strMonth;
					break;
				case 1:
					strCurrMonth =strYear + "-" + strMonth;
					break;
				case 2:
					strCurrMonth =strYear + "/" + strMonth;
					break;
			}
			return strCurrMonth;
		}
		///生成从界面层到逻辑层的数据传输函数代码
		
		public void BindDdl_UpDepartmentId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
            string strCondition = string.Format("{0}='1'", conQxDepartmentInfo.InUse);
            System.Data.DataTable objDT = clsQxDepartmentInfoBL.GetDataTable_QxDepartmentInfo(strCondition);
           objDDL.DataValueField="DepartmentId";
			objDDL.DataTextField="DepartmentName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public System.Data.DataTable GetSubjectTypeId()
		{
			//获取某学院所有专业信息
			string strSQL = "select SubjectTypeId, SubjectTypeName from SubjectType ";
			clsSpecSQLforSql mySql=new clsSpecSQLforSql();
			System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
			return objDT;
		}
		public void BindDdl_SubjectTypeId(System.Web.UI.WebControls.DropDownList objDDL)
		{
			//为数据源于表的下拉框设置内容
			ListItem li=new ListItem("请选择...","0");
			System.Data.DataTable objDT = GetSubjectTypeId();
			objDDL.DataValueField="SubjectTypeId";
			objDDL.DataTextField="SubjectTypeName";
			objDDL.DataSource = objDT;
			objDDL.DataBind();
			objDDL.Items.Insert(0, li);
			objDDL.SelectedIndex = 0;
		}
		public void SetDdl_UpDepartmentId()
		{
			BindDdl_UpDepartmentId(ddlUpDepartmentId);
		}
		public void SetDdl_SubjectTypeId()
		{
			BindDdl_SubjectTypeId(ddlSubjectTypeId);
		}
	}
}