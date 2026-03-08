
//生成与表相关的控件控制层代码
namespace GeneralPlatform.Webform
{
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
    using com.taishsoft.common;
    using com.taishsoft.commdb;
    using GeneralPlatform.Entity;
    using GeneralPlatform.BusinessLogic;

    /// <summary>
    ///		wucUserDownLoadLogB 的摘要说明。
    /// </summary>
    public partial class wucUserDownLoadLogB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId
        {
            get
            {
                if (ddlUserId.SelectedValue == "0")
                    return "";
                return ddlUserId.SelectedValue;
            }
            set
            {
                if (ddlUserId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlUserId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlUserId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 工程站点Id
        /// </summary>
        public string PrjSiteId
        {
            get
            {
                if (ddlPrjSiteId.SelectedValue == "0")
                    return "";
                return ddlPrjSiteId.SelectedValue;
            }
            set
            {
                if (ddlPrjSiteId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlPrjSiteId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlPrjSiteId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 下载日期
        /// </summary>
        public string DownLownDate
        {
            get
            {
                return txtDownLownDate.Text.Trim();
            }
            set
            {
                txtDownLownDate.Text = value.ToString();
            }
        }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess
        {
            get
            {
                return chkIsSuccess.Checked;
            }
            set
            {
                chkIsSuccess.Checked = value;
            }
        }

        /// <summary>
        /// 日志信息
        /// </summary>
        public string LogInfo
        {
            get
            {
                return txtLogInfo.Text.Trim();
            }
            set
            {
                txtLogInfo.Text = value.ToString();
            }
        }

        /// <summary>
        /// 备注
        /// </summary>
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


        public void Clear()
        {
            ddlUserId.SelectedIndex = 0;
            ddlPrjSiteId.SelectedIndex = 0;
            txtDownLownDate.Text = "";
            chkIsSuccess.Checked = false;
            txtLogInfo.Text = "";
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
        public bool IsValid(ref string strResult)
        {
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
            ddlUserId.SelectedIndex = 0;
            ddlPrjSiteId.SelectedIndex = 0;
            txtDownLownDate.Text = "";
            chkIsSuccess.Checked = false;
            txtLogInfo.Text = "";
            txtMemo.Text = "";
        }
        public System.Data.DataTable GetUserId()
        {
            //获取某学院所有专业信息
            string strSQL = "select UserId, UserName from Users ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetUserId();
            objDDL.DataValueField = "UserId";
            objDDL.DataTextField = "UserName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
       
        public void SetDdl_UserIdByPrjId(string strPrjId)
        {
            clsDropDownList.BindDdl_UserIdByPrjId(ddlUserId, strPrjId);
        }
        public void SetDdl_PrjSiteId(string strPrjId)
        {

            clsDropDownList.BindDdl_PrjSiteId(ddlPrjSiteId, strPrjId);
        }
        //public void SetProjectEnabled(bool bolEnabled)
        //{
        //    ddlPrjId.Enabled = bolEnabled;
        //}
    }
}