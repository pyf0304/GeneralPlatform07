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

    /// <summary>
    ///		wucUserRoleRelation2 的摘要说明。
    /// </summary>
    public partial class wucUserRoleRelation2 : System.Web.UI.UserControl
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
                return txtUserId.Text.Trim();
            }
            set
            {
                txtUserId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 角色Id
        /// </summary>
        public string RoleId
        {
            get
            {
                return txtRoleId.Text.Trim();
            }
            set
            {
                txtRoleId.Text = value.ToString();
            }
        }

        /// <summary>
        /// 项目编号
        /// </summary>
        public string PrjId
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


        public void SetKeyReadOnly(bool bolReadonly)
        {
            txtRoleId.ReadOnly = bolReadonly;
        }
        public void Clear()
        {
            txtUserId.Text = "";
            txtRoleId.Text = "";
            ddlPrjId.SelectedIndex = 0;
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
            txtUserId.Text = "";
            txtRoleId.Text = "";
            ddlPrjId.SelectedIndex = 0;
            txtMemo.Text = "";
        }
        ///生成从界面层到逻辑层的数据传输函数代码
        public System.Data.DataTable GetPrjId()
        {
            //获取某学院所有专业信息
            string strSQL = "select PrjId, PrjName from Projects ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public void BindDdl_PrjId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetPrjId();
            objDDL.DataValueField = "PrjId";
            objDDL.DataTextField = "PrjName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public void SetDdl_PrjId()
        {
            clsProjectsBL.BindDdl_PrjId(ddlPrjId);
        }

        ///生成从逻辑层的数据传输到界面层的函数代码
        /// <summary>
        /// 函数功能：把类对象的属性内容显示到界面上
        ///注意：如果有两个下拉框，并且是一级、二级连带关系的，请先为一级下拉框赋值，然后再为二级下拉框赋值
        ///      如果在设置数据库时，就应该一级字段在前，二级字段在后
        /// </summary>
        /// <param name="pobjUserRoleRelation2">表实体类对象</param>
        public void GetDataFromUserRoleRelation2Class(clsUserRoleRelation2 pobjUserRoleRelation2)
        {
            this.UserId = pobjUserRoleRelation2.UserId;//    用户ID
            this.RoleId = pobjUserRoleRelation2.RoleId;//    角色Id
            this.PrjId = pobjUserRoleRelation2.PrjId;//    项目编号
            this.Memo = pobjUserRoleRelation2.Memo;//    备注
        }
        ///生成从界面层到逻辑层的数据传输函数代码
        /// <summary>
        /// 函数功能：把界面上的属性数据传到类对象中
        /// </summary>
        /// <param name="pobjUserRoleRelation2">数据传输的目的类对象</param>
        public void PutDataToUserRoleRelation2Class(ref clsUserRoleRelation2 pobjUserRoleRelation2)
        {
            pobjUserRoleRelation2.UserId = this.UserId;//    用户ID
            pobjUserRoleRelation2.RoleId = this.RoleId;//    角色Id
            pobjUserRoleRelation2.PrjId = this.PrjId;//    项目编号
            pobjUserRoleRelation2.Memo = this.Memo;//    备注
        }
        ///生成组合查询条件的代码
        /// <summary>
        /// 把所有的查询控件内容组合成一个条件串
        /// </summary>
        /// <returns>条件串(strWhereCond)</returns>
        public string CombineUserRoleRelation2Condion()
        {
            ///使条件串的初值为"1=1"，以便在该串的后面用"and "添加其他条件,
            ///例如 1=1 && UserName = '张三'
            string strWhereCond = " 1=1 ";
            ///如果该条件控件的内容不为空，就组成一个条件并添加到总条件串中。
            if (this.txtUserId.Text.Trim() != "")
            {
                strWhereCond += " And UserId like '%" + this.txtUserId.Text.Trim() + "%'";
            }
            if (this.txtRoleId.Text.Trim() != "")
            {
                strWhereCond += " And RoleId like '%" + this.txtRoleId.Text.Trim() + "%'";
            }
            if (this.ddlPrjId.SelectedValue != "" && this.ddlPrjId.SelectedValue != "0")
            {
                strWhereCond += " And PrjId='" + this.ddlPrjId.SelectedValue + "'";
            }
            if (this.txtMemo.Text.Trim() != "")
            {
                strWhereCond += " And Memo like '%" + this.txtMemo.Text.Trim() + "%'";
            }
            return strWhereCond;
        }
       
    }
}