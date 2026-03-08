///生成与表相关的控件控制层代码
namespace GeneralPlatform.Webform
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Web;
    using System.Web.UI.WebControls;

    using System.Web.UI.HtmlControls;
    using SpecData;
    using GeneralPlatform.BusinessLogic;
    using com.taishsoft.commdb;
    using Entity;
    using BusinessLogicEx;


    /// <summary>
    ///		wucQxPrjMenus 的摘要说明。
    /// </summary>
    public partial class wucQxPrjMenus : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {

            // 在此处放置用户代码以初始化页面
            //			DateTime dtNow = DateTime.Now;
            //			int intYear, intMonth, intDay,intHour,intMinite, intSecond;
            //			intYear = dtNow.Year;
            //			intMonth = dtNow.Month;
            //			intDay = dtNow.Day;
            //			DateTime dt1 = new DateTime(intYear, intMonth, intDay, 9,5,0);
            //			System.TimeSpan ts = dtNow - dt1;
            //			if (ts.Ticks>0) 
            //				"迟到";



        }

        public string MenuId
        {
            get
            {
                return txtMenuId.Text.Trim();
            }
            set
            {
                txtMenuId.Text = value.ToString();
            }
        }

        public string MenuName
        {
            get
            {
                return txtMenuName.Text.Trim();
            }
            set
            {
                txtMenuName.Text = value.ToString();
            }
        }

        public int OrderNum
        {
            get
            {
                if (txtOrderNum.Text.Trim() == "")
                {
                    return 0;
                }
                return int.Parse(txtOrderNum.Text.Trim());
            }
            set
            {
                txtOrderNum.Text = value.ToString();
            }
        }

        public string QxPrjId
        {
            get
            {
                if (ddlPrjId.SelectedValue == "0")
                    return "";
                return ddlPrjId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlPrjId.SelectedValue = "0";
                }
                else
                {
                    ddlPrjId.SelectedValue = value;
                }
            }
        }
        /// <summary>
        /// 菜单集Id
        /// </summary>
        public string MenuSetId
        {
            get
            {
                if (ddlMenuSetId.SelectedValue == "0")
                    return "";
                return ddlMenuSetId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlMenuSetId.SelectedValue = "0";
                }
                else
                {
                    try
                    {
                        ddlMenuSetId.SelectedValue = value;
                    }
                    catch (Exception objException)
                    {
                        string ss = objException.Message;
                    }
                }
            }
        }


        /// <summary>
        /// 页面显示方式Id
        /// </summary>
        public string PageDispModeId
        {
            get
            {
                if (ddlPageDispModeId.SelectedValue == "0")
                    return "";
                return ddlPageDispModeId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlPageDispModeId.SelectedValue = "0";
                }
                else
                {
                    ddlPageDispModeId.SelectedValue = value;
                }
            }
        }
        public string UpMenuId
        {
            get
            {
                //				if (ddlUpMenuId.SelectedValue == "0")
                //					return "";
                return ddlUpMenuId.SelectedValue;
            }
            set
            {
                if (value == "")
                {
                    ddlUpMenuId.SelectedValue = "0";
                }
                else
                {
                    try
                    {
                        ddlUpMenuId.SelectedValue = value;
                    }
                    catch (Exception objException)
                    {
                        string ss = objException.Message;
                    }
                }
            }
        }

        public bool IsLeafNode
        {
            get
            {
                if (ddlIsLeafNode.SelectedValue == "0")
                {
                    return false;
                }
                else if (ddlIsLeafNode.SelectedValue == "01")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    ddlIsLeafNode.SelectedValue = "01";
                }
                else
                {
                    ddlIsLeafNode.SelectedValue = "00";
                }
            }
        }
        public bool InUse
        {
            get
            {
                if (ddlInUse.SelectedValue == "0")
                {
                    return false;
                }
                else if (ddlInUse.SelectedValue == "01")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    ddlInUse.SelectedValue = "01";
                }
                else
                {
                    ddlInUse.SelectedValue = "00";
                }
            }
        }
        public string LinkFile
        {
            get
            {
                string strFileName;
                strFileName = txtLinkFile.Text;
                return strFileName;
            }
            set
            {
                txtLinkFile.Text = value;
            }
        }

        /// <summary>
        /// qs参数
        /// </summary>
        public string qsParameters
        {
            get
            {
                string strqsParameters;
                strqsParameters = txtqsParameters.Text;
                return strqsParameters;
            }
            set
            {
                txtqsParameters.Text = value;
            }
        }
        public string ImgFile
        {
            get
            {
                string strImgFileName;
                strImgFileName = txtImgFile.Text.Trim();
                return strImgFileName;
            }
            set
            {
                txtImgFile.Text = value.ToString();
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
            txtMenuId.ReadOnly = bolReadonly;
        }
        public void Clear()
        {
            txtMenuId.Text = "";
            txtMenuName.Text = "";
            ddlPrjId.SelectedIndex = 0;
            ddlUpMenuId.SelectedIndex = 0;
            txtqsParameters.Text = "";

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
            txtMenuId.Text = "";
            txtMenuName.Text = "";
            ddlPrjId.SelectedIndex = 0;
            ddlUpMenuId.SelectedIndex = 0;
            txtImgFile.Text = "";
            txtLinkFile.Text = "";
            txtqsParameters.Text = "";

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
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strToday = strYear + strMonth + strDay;
            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay;
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
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            strCurrMonth = strYear + strMonth;
            switch (intFormat)
            {
                case 0:
                    strCurrMonth = strYear + strMonth;
                    break;
                case 1:
                    strCurrMonth = strYear + "-" + strMonth;
                    break;
                case 2:
                    strCurrMonth = strYear + "/" + strMonth;
                    break;
            }
            return strCurrMonth;
        }
       
        public System.Data.DataTable GetUpMenuId(string strMenuSetId)
        {
            string strPrjId = getUserPrjId;
            //获取某学院所有专业信息
            string strSQL = string.Format("select MenuId, MenuName from QxPrjMenus where (UpMenuId = '00000000' and QxPrjId = '{0}' And MenuSetId='{1}') or MenuId = '00000000' Order By OrderNum",
                strPrjId,
                strMenuSetId);
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public System.Data.DataTable GetLevelMenuId(string strMenuSetId)
        {
            string strPrjId = getUserPrjId;
            //获取某学院所有专业信息
            //            string strSQL = string.Format( "select MenuId, MenuName from QxPrjMenus where IsLeafNode <> '1' and QxPrjId = '{0}' union select MenuId, MenuName from QxPrjMenus where MenuId = '00000000'", QxPrjId);
            string strSQL = string.Format("select MenuId, MenuName from QxPrjMenus where IsLeafNode <> '1' and QxPrjId = '{0}' And MenuSetId='{1}' Order by OrderNum",
                 strPrjId,
                 strMenuSetId);
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_UpMenuId(System.Web.UI.WebControls.DropDownList objDDL, string strMenuSetId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetUpMenuId(strMenuSetId);
            objDDL.DataValueField = "MenuId";
            objDDL.DataTextField = "MenuName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 绑定层菜单
        /// </summary>
        /// <param name="objDDL"></param>
        public void BindDdl_LevelMenuId(System.Web.UI.WebControls.DropDownList objDDL, string strMenuSetId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetLevelMenuId(strMenuSetId);
            objDDL.DataValueField = "MenuId";
            objDDL.DataTextField = "MenuName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_QxPrjId()
        {
            clsQxProjectsBL.BindDdl_QxPrjId(ddlPrjId);
        }

        public void SetDdl_MenuSetId(string strPrjId)
        {
            //         clsQxPrjMenuSetBL.BindDdl_MenuSetId(ddlMenuSetId);
            clsQxPrjMenuSetBLEx.BindDdl_MenuSetIdEx(ddlMenuSetId, strPrjId);
        }
        public void SetDdl_UpMenuId(string strPrjId)
        {
            clsDropDownList.BindDdl_UpMenuId(ddlUpMenuId, strPrjId);
        }
        public void SetDdl_LevelMenuId(string strMenuSetId)
        {
            BindDdl_LevelMenuId(ddlUpMenuId, strMenuSetId);
        }
        public void SetDdl_IsLeafNode()
        {
            clsDropDownList.BindDdl_TrueOrFalse(ddlIsLeafNode);
        }
        public void SetDdl_InUse()
        {
            clsDropDownList.BindDdl_TrueOrFalse(ddlInUse);
        }

        public void SetDdl_PageDispModeId()
        {
            clsQxPageDispModeBL.BindDdl_PageDispModeId(ddlPageDispModeId);
        }
        public void Set_DdlPrjNotEnabled()
        {
            this.ddlPrjId.Enabled = false;
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

        protected void ddlMenuSetId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlMenuSetId.SelectedIndex <= 0) return;
            string strMenuSetId = ddlMenuSetId.SelectedValue;
            clsQxPrjMenusBLEx.BindDdl_MenuIdByMenuSetId(ddlUpMenuId, clsCommonSession.UserPrjId4get, strMenuSetId);
        }
    }
}