
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
///		wucRelaOfPotenceAndSymbolB 的摘要说明。
/// </summary>
public partial class wucRelaOfPotenceAndSymbolB : System.Web.UI.UserControl
{
protected void Page_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面

}
/// <summary>
/// 权限ID
/// </summary>
public string PotenceId
{
get
{
if (ddlPotenceId.SelectedValue == "0")
return "";
return ddlPotenceId.SelectedValue;
}
set
{
if (ddlPotenceId.Items.Count>0)
{
if (value == "")
{
ddlPotenceId.SelectedValue = "0";
}
else
{
ddlPotenceId.SelectedValue = value;
}
}
}
}

/// <summary>
/// 编程标志
/// </summary>
public string SymbolForProgramme
{
get
{
return txtSymbolForProgramme.Text.Trim();
}
set
{
txtSymbolForProgramme.Text = value.ToString();
}
}

/// <summary>
/// 标志名称
/// </summary>
public string SymbolName
{
get
{
return txtSymbolName.Text.Trim();
}
set
{
txtSymbolName.Text = value.ToString();
}
}

/// <summary>
/// 修改日期
/// </summary>
public string UpdDate
{
get
{
return txtUpdDate.Text.Trim();
}
set
{
txtUpdDate.Text = value.ToString();
}
}

/// <summary>
/// 修改用户Id
/// </summary>
public string UpdUserId
{
get
{
return txtUpdUserId.Text.Trim();
}
set
{
txtUpdUserId.Text = value.ToString();
}
}

/// <summary>
/// 项目Id
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
if (ddlPrjId.Items.Count>0)
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


public void Clear()
{
ddlPotenceId.SelectedIndex = 0;
txtSymbolForProgramme.Text = "";
txtSymbolName.Text = "";
txtUpdDate.Text = "";
txtUpdUserId.Text = "";
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
ddlPotenceId.SelectedIndex = 0;
txtSymbolForProgramme.Text = "";
txtSymbolName.Text = "";
txtUpdDate.Text = "";
txtUpdUserId.Text = "";
ddlPrjId.SelectedIndex = 0;
txtMemo.Text = "";
}
public System.Data.DataTable GetPotenceId()
{
//获取某学院所有专业信息
string strSQL = "select PotenceId, PotenceName from PrjPotence ";
clsSpecSQLforSql mySql=new clsSpecSQLforSql();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
public void BindDdl_PotenceId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
ListItem li=new ListItem("请选择...","0");
System.Data.DataTable objDT = GetPotenceId();
objDDL.DataValueField="PotenceId";
objDDL.DataTextField="PotenceName";
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

public void SetDdl_PotenceId()
{
clsQxPrjPotenceBL.BindDdl_PotenceId(ddlPotenceId);
}
public void SetDdl_QxPrjId()
{
clsQxProjectsBL.BindDdl_QxPrjId(ddlPrjId);
}
}
}