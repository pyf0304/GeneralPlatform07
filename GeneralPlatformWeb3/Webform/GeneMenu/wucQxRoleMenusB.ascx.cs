
///生成与表相关的控件控制层代码
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
    using BusinessLogicEx;

    /// <summary>
    ///		wucQxRoleMenusB 的摘要说明。
    /// </summary>
    public partial class wucQxRoleMenusB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 项目编号
        /// </summary>
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
                if (ddlPrjId.Items.Count > 0)
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
        }

        /// <summary>
        /// 角色Id
        /// </summary>
        public string RoleId
        {
            get
            {
                if (ddlRoleId.SelectedValue == "0")
                    return "";
                return ddlRoleId.SelectedValue;
            }
            set
            {
                if (ddlRoleId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlRoleId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlRoleId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 菜单Id
        /// </summary>
        public string MenuId
        {
            get
            {
                if (ddlMenuId.SelectedValue == "0")
                    return "";
                return ddlMenuId.SelectedValue;
            }
            set
            {
                if (ddlMenuId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlMenuId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlMenuId.SelectedValue = value;
                    }
                }
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
            ddlPrjId.SelectedIndex = 0;
            ddlRoleId.SelectedIndex = 0;
            ddlMenuId.SelectedIndex = 0;
            
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
            ddlPrjId.SelectedIndex = 0;
            ddlRoleId.SelectedIndex = 0;
            ddlMenuId.SelectedIndex = 0;
            
            txtMemo.Text = "";
        }
        
        public System.Data.DataTable GetRoleId()
        {
            //获取某学院所有专业信息
            string strSQL = "select RoleId, RoleName from UserRoles ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_RoleId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetRoleId();
            objDDL.DataValueField = "RoleId";
            objDDL.DataTextField = "RoleName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public System.Data.DataTable GetMenuId()
        {
            //获取某学院所有专业信息
            string strSQL = "select MenuId, MenuName from QxPrjMenus ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_MenuId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetMenuId();
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
        public void SetDdl_RoleId(string strPrjId)
        {
            clsQxRolesBL.BindDdl_RoleId(ddlRoleId, strPrjId);
        }
        public void SetDdl_MenuId(string strPrjId)
        {
            clsQxPrjMenusBLEx.BindDdl_MenuIdEx(ddlMenuId, strPrjId);
        }
        protected void ddlPrjId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strPrjId = "";
            if (ddlPrjId.SelectedIndex > 0)
            {
                strPrjId = ddlPrjId.SelectedValue.ToString();
                clsQxPrjMenusBLEx.BindDdl_MenuIdEx(ddlMenuId, strPrjId);
                clsQxRolesBLEx.BindDdl_RoleIdEx(ddlRoleId, strPrjId);
            }
        }
}
}