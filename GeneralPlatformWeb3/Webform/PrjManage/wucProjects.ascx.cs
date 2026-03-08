///生成与表相关的控件控制层代码
namespace  GeneralPlatform.Webform
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;
	using SpecData;
    using GeneralPlatform;
    using GeneralPlatform.BusinessLogic;

	/// <summary>
	///		wucProjects 的摘要说明。
	/// </summary>
	public partial class wucProjects : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面

		}
		public string QxPrjId
        {
			get
			{
				return txtPrjId.Text.Trim();
			}
			set
			{
				txtPrjId.Text = value.ToString();
			}
		}

		public string PrjName
		{
			get
			{
				return txtPrjName.Text.Trim();
			}
			set
			{
				txtPrjName.Text = value.ToString();
			}
		}
        public bool IsDefaultPrj
        {
            get
            {
                return chkIsDefaultPrj.Checked;
            }
            set
            {
                chkIsDefaultPrj.Checked = value;
            }
        }
		public string PrjDomain
		{
			get
			{
				return txtPrjDomain.Text.Trim();
			}
			set
			{
				txtPrjDomain.Text = value.ToString();
			}
		}

		public string PrjMainDataBase
		{
			get
			{
				return txtPrjMainDataBase.Text.Trim();
			}
			set
			{
				txtPrjMainDataBase.Text = value.ToString();
			}
		}

		public string IpAddress
		{
			get
			{
				return txtIpAddress.Text.Trim();
			}
			set
			{
				txtIpAddress.Text = value.ToString();
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
				txtDataBaseUserId.Text = value.ToString();
			}
		}

		public string DataBasePwd
		{
			get
			{
				return txtDataBasePwd.Text.Trim();
			}
			set
			{
				txtDataBasePwd.Text = value.ToString();
			}
		}

		public string UserID
		{
			get
			{
				return txtUserID.Text.Trim();
			}
			set
			{
				txtUserID.Text = value.ToString();
			}
		}

		public string UpdTime
		{
			get
			{
				return txtUpdTime.Text.Trim();
			}
			set
			{
				txtUpdTime.Text = value.ToString();
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
        /// <summary>
        /// 数据库ID
        /// </summary>
        public string PrjDataBaseId
        {
            get
            {
                if (ddlPrjDataBase.SelectedValue == "0")
                    return "";
                return ddlPrjDataBase.SelectedValue;
            }
            set
            {
                if (ddlPrjDataBase.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlPrjDataBase.SelectedValue = "0";
                    }
                    else
                    {
                        ddlPrjDataBase.SelectedValue = value;
                    }
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

		}
		#endregion

		public void SetKeyReadOnly(bool bolReadonly)
		{
			txtPrjId.ReadOnly = bolReadonly;
		}
		public void Clear()
		{
			txtPrjId.Text = "";
			txtPrjName.Text = "";
			txtPrjDomain.Text = "";
			txtPrjMainDataBase.Text = "";
			txtIpAddress.Text = "";
			txtDataBaseUserId.Text = "";
			txtDataBasePwd.Text = "";
			txtUserID.Text = "0";
			txtUpdTime.Text = "";
			txtMemo.Text = "";
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
			return true;
		}
		/// <summary>
		/// 设置该控件在插入状态下的缺省值
		/// 一般规则：
		///		1、如果是整型就默认为0；
		///		2、如果是浮点型不默认为0.0；
		///		3、如果是日期型就默认为当前的日期；
		///		4、如果是位(bit)型就默认为False;
		///		这些默认值可以再行修改
		/// </summary>
		public void SetDefaultValue()
		{
			txtPrjId.Text = "";
			txtPrjName.Text = "";
			txtPrjDomain.Text = "";
			txtPrjMainDataBase.Text = "";
			txtIpAddress.Text = "";
			txtDataBaseUserId.Text = "";
			txtDataBasePwd.Text = "";
			txtUserID.Text = "";
			txtUpdTime.Text = "";
			txtMemo.Text = "";
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
        ///
        public void SetDdl_QxPrjDataBaseId()
        {
            clsQxPrjDataBaseBL.BindDdl_QxPrjDataBaseIdCache(ddlPrjDataBase);
        }
	}
}