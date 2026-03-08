
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
    using com.taishsoft.datetime;
    using com.taishsoft.commdb;
    using GeneralPlatform.Entity;
    using GeneralPlatform.BusinessLogic;

    /// <summary>
    ///		wucUserMenuDetailB 的摘要说明。
    /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
    /// </summary>
    public partial class wucUserMenuDetailB : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面

        }
        /// <summary>
        /// 菜单Id
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// 菜单名
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
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

        /// <summary>
        /// 是否显示
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsDisp
        {
            get
            {
                return chkIsDisp.Checked;
            }
            set
            {
                chkIsDisp.Checked = value;
            }
        }

        /// <summary>
        /// 上级菜单Id
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string UpMenuId
        {
            get
            {
                if (ddlUpMenuId.SelectedValue == "0")
                    return "";
                return ddlUpMenuId.SelectedValue;
            }
            set
            {
                if (ddlUpMenuId.Items.Count > 0)
                {
                    if (value == "")
                    {
                        ddlUpMenuId.SelectedValue = "0";
                    }
                    else
                    {
                        ddlUpMenuId.SelectedValue = value;
                    }
                }
            }
        }

        /// <summary>
        /// 链接文件
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string LinkFile
        {
            get
            {
                return txtLinkFile.Text.Trim();
            }
            set
            {
                txtLinkFile.Text = value.ToString();
            }
        }

        /// <summary>
        /// 图像文件
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public string ImgFile
        {
            get
            {
                return txtImgFile.Text.Trim();
            }
            set
            {
                txtImgFile.Text = value.ToString();
            }
        }

        /// <summary>
        /// 是否定制菜单
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public bool IsCustomMenu
        {
            get
            {
                return chkIsCustomMenu.Checked;
            }
            set
            {
                chkIsCustomMenu.Checked = value;
            }
        }

        /// <summary>
        /// 用户ID
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// 项目Id
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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
        /// 排序号
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
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

        /// <summary>
        /// 备注
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
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


        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>	
        public void Clear()
        {
            ddlMenuId.SelectedIndex = 0;
            txtMenuName.Text = "";
            chkIsDisp.Checked = false;
            ddlUpMenuId.SelectedIndex = 0;
            txtLinkFile.Text = "";
            txtImgFile.Text = "";
            chkIsCustomMenu.Checked = false;
            ddlUserId.SelectedIndex = 0;
            ddlPrjId.SelectedIndex = 0;
            txtOrderNum.Text = "0";
            txtMemo.Text = "";
        }
        /// <summary>
        /// 校验自定义控件中自子控件的类型数值是否是合法正确的。
        /// 一般规则:
        ///		1、首先校验类型:整型、浮点型、日期型等,
        ///			这些代码由自动生成代码帮助生成
        ///		2、校验最值,即最大值和最小值等
        ///			这些代码由自动生成代码帮助生成
        ///		这些生成内容可以修改
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        /// <returns></returns>
        public bool IsValid(ref string strResult)
        {
            ComValid_OrderNum.Validate();
            if (!ComValid_OrderNum.IsValid) return false;
            if (clsString.IsNumeric(txtOrderNum.Text) == false)
            {
                strResult = "请输入正确的整型!";
                return false;
            }
            return true;
        }
        /// <summary>
        /// 设置该控件在插入状态下的缺省值
        /// 一般规则:
        ///		1、如果是整型就默认为0；
        ///		2、如果是浮点型不默认为0.0；
        ///		3、如果是日期型就默认为当前的日期；
        ///		4、如果是位(bit)型就默认为false;
        ///		这些默认值可以再行修改
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDefaultValue()
        {
            ddlMenuId.SelectedIndex = 0;
            txtMenuName.Text = "";
            chkIsDisp.Checked = false;
            ddlUpMenuId.SelectedIndex = 0;
            txtLinkFile.Text = "";
            txtImgFile.Text = "";
            chkIsCustomMenu.Checked = false;
            ddlUserId.SelectedIndex = 0;
            ddlPrjId.SelectedIndex = 0;
            txtOrderNum.Text = "0";
            txtMemo.Text = "";
        }
        /// <summary>
        /// 为下拉框获取数据,从表：[QxPrjMenus]中获取
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetMenuId()
        {
            //获取某学院所有专业信息
            string strSQL = "select MenuId, MenuName from QxPrjMenus ";
            clsSpecSQLforSql mySql = clsQxUserMenuDetailBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_MenuId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetMenuId();
            objDDL.DataValueField = conQxPrjMenus.MenuId;
            objDDL.DataTextField = conQxPrjMenus.MenuName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 为下拉框获取数据,从表：[QxPrjMenus]中获取
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetUpMenuId()
        {
            //获取某学院所有专业信息
            string strSQL = "select MenuId, MenuName from QxPrjMenus ";
            clsSpecSQLforSql mySql = clsQxUserMenuDetailBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_UpMenuId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetUpMenuId();
            objDDL.DataValueField = conQxPrjMenus.MenuId;
            objDDL.DataTextField = conQxPrjMenus.MenuName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 为下拉框获取数据,从表：[Users]中获取
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
        public System.Data.DataTable GetUserId()
        {
            //获取某学院所有专业信息
            string strSQL = "select UserId, UserName from Users ";
            clsSpecSQLforSql mySql = clsQxUserMenuDetailBL.GetSpecSQLObj();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:GenDdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetUserId();
            objDDL.DataValueField = conQxUsers.UserId;
            objDDL.DataTextField = conQxUsers.UserName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
      
        /// <summary>
        /// 设置绑定下拉框，针对字段：[MenuId]
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDdl_MenuId()
        {
            //clsQxPrjMenusBL.BindDdl_MenuId(ddlMenuId, "");
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段：[UpMenuId]
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDdl_UpMenuId()
        {
            //clsQxPrjMenusBL.BindDdl_MenuId(ddlUpMenuId, "");
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段：[UserId]
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDdl_UserId()
        {
            clsQxUsersBL.BindDdl_UserId(ddlUserId);
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段：[QxPrjId]
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_CWeb_Net2005:A_GenCtlControlCodeforTab)
        /// </summary>
        public void SetDdl_QxPrjId()
        {
            clsQxProjectsBL.BindDdl_QxPrjId(ddlPrjId);
        }
    }
}