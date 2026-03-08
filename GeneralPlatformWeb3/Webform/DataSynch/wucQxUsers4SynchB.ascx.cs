
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:wucQxUsers4SynchB
 界面名:wfmQxUsers4Synch_QUDI(00140028)
 生成代码版本:2019.03.25.1
 生成日期:2019/04/01 06:49:29
 生成者:
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:数据同步
 模块英文名:DataSynch
 框架-层名:Web用户控件后台代码(WebCtlControlCode)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
using CommonTable.Entity;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;

 /// <summary>
 ///		wucQxUsers4SynchB 的摘要说明。
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public partial class wucQxUsers4SynchB : System.Web.UI.UserControl
{
 /// <summary>
 /// 函数功能:页面导入,当页面开始运行时所发生的事件
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
 /// <param name = "sender"></param>
 /// <param name = "e"></param>
protected void Page_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面

}
 /// <summary>
 /// IP地址
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
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

 /// <summary>
 /// 用户ID
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string UserId
{
get
{
if (ddlUserId.SelectedValue  ==  "0")
return "";
return ddlUserId.SelectedValue;
}
set
{
if (ddlUserId.Items.Count>0)
{
if (value  ==  "")
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
 /// 用户名
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string UserName
{
get
{
return txtUserName.Text.Trim();
}
set
{
txtUserName.Text = value.ToString();
}
}

 /// <summary>
 /// 用户状态Id
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string UserStateId
{
get
{
if (ddlUserStateId.SelectedValue  ==  "0")
return "";
return ddlUserStateId.SelectedValue;
}
set
{
if (ddlUserStateId.Items.Count>0)
{
if (value  ==  "")
{
ddlUserStateId.SelectedValue = "0";
}
else
{
ddlUserStateId.SelectedValue = value;
}
}
}
}

 /// <summary>
 /// 微信openid
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string openid
{
get
{
return txtopenid.Text.Trim();
}
set
{
txtopenid.Text = value.ToString();
}
}

 /// <summary>
 /// 身份编号
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string IdentityID
{
get
{
return txtIdentityID.Text.Trim();
}
set
{
txtIdentityID.Text = value.ToString();
}
}

 /// <summary>
 /// 学工号
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string StuTeacherId
{
get
{
return txtStuTeacherId.Text.Trim();
}
set
{
txtStuTeacherId.Text = value.ToString();
}
}

 /// <summary>
 /// 口令
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string Password
{
get
{
return txtPassword.Text.Trim();
}
set
{
txtPassword.Text = value.ToString();
}
}

 /// <summary>
 /// 电话号码
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string PhoneNumber
{
get
{
return txtPhoneNumber.Text.Trim();
}
set
{
txtPhoneNumber.Text = value.ToString();
}
}

 /// <summary>
 /// 部门Id
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string DepartmentId
{
get
{
if (ddlDepartmentId.SelectedValue  ==  "0")
return "";
return ddlDepartmentId.SelectedValue;
}
set
{
if (ddlDepartmentId.Items.Count>0)
{
if (value  ==  "")
{
ddlDepartmentId.SelectedValue = "0";
}
else
{
ddlDepartmentId.SelectedValue = value;
}
}
}
}

 /// <summary>
 /// 学院流水号
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string id_College
{
get
{
return txtid_College.Text.Trim();
}
set
{
txtid_College.Text = value.ToString();
}
}

 /// <summary>
 /// 有效日期
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string EffectiveDate
{
get
{
return txtEffectiveDate.Text.Trim();
}
set
{
txtEffectiveDate.Text = value.ToString();
}
}

 /// <summary>
 /// 有效开始日期
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string EffitiveBeginDate
{
get
{
return txtEffitiveBeginDate.Text.Trim();
}
set
{
txtEffitiveBeginDate.Text = value.ToString();
}
}

 /// <summary>
 /// 有效结束日期
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string EffitiveEndDate
{
get
{
return txtEffitiveEndDate.Text.Trim();
}
set
{
txtEffitiveEndDate.Text = value.ToString();
}
}

 /// <summary>
 /// 邮箱
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string Email
{
get
{
return txtEmail.Text.Trim();
}
set
{
txtEmail.Text = value.ToString();
}
}

 /// <summary>
 /// 是否存档
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public bool IsArchive
{
get
{
return chkIsArchive.Checked;
}
set
{
chkIsArchive.Checked = value;
}
}

 /// <summary>
 /// 修改日期
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
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
 /// 修改用户
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string UpdUser
{
get
{
return txtUpdUser.Text.Trim();
}
set
{
txtUpdUser.Text = value.ToString();
}
}

 /// <summary>
 /// 备注
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
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
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
/// </summary>	
public void Clear()
{
txtIpAddress.Text = "";
ddlUserId.SelectedIndex = 0;
txtUserName.Text = "";
ddlUserStateId.SelectedIndex = 0;
txtopenid.Text = "";
txtIdentityID.Text = "";
txtStuTeacherId.Text = "";
txtPassword.Text = "";
txtPhoneNumber.Text = "";
ddlDepartmentId.SelectedIndex = 0;
txtid_College.Text = "";
txtEffectiveDate.Text = "";
txtEffitiveBeginDate.Text = "";
txtEffitiveEndDate.Text = "";
txtEmail.Text = "";
chkIsArchive.Checked = false;
txtUpdDate.Text = "";
txtUpdUser.Text = "";
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
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
 /// <returns></returns>
public bool IsValid(ref string strResult)
{
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
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public void SetDefaultValue()
{
txtIpAddress.Text = "";
ddlUserId.SelectedIndex = 0;
txtUserName.Text = "";
ddlUserStateId.SelectedIndex = 0;
txtopenid.Text = "";
txtIdentityID.Text = "";
txtStuTeacherId.Text = "";
txtPassword.Text = "";
txtPhoneNumber.Text = "";
ddlDepartmentId.SelectedIndex = 0;
txtid_College.Text = "";
txtEffectiveDate.Text = "";
txtEffitiveBeginDate.Text = "";
txtEffitiveEndDate.Text = "";
txtEmail.Text = "";
chkIsArchive.Checked = false;
txtUpdDate.Text = "";
txtUpdUser.Text = "";
txtMemo.Text = "";
}
/// <summary>
/// 为下拉框获取数据,从表:[QxUsers]中获取
 /// (AutoGCLib.clsGeneCodeBase:GenDdlBindFunction)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
public System.Data.DataTable GetUserId()
{
//获取某学院所有专业信息
string strSQL = "select UserId, UserName from QxUsers ";
 clsSpecSQLforSql mySql = clsQxUsers4SynchBL.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.clsGeneCodeBase:GenDdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public void BindDdl_UserId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetUserId();
objDDL.DataValueField = clsQxUsersEN.con_UserId;
objDDL.DataTextField = clsQxUsersEN.con_UserName;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}
/// <summary>
/// 为下拉框获取数据,从表:[QxUserState]中获取
 /// (AutoGCLib.clsGeneCodeBase:GenDdlBindFunction)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
public System.Data.DataTable GetUserStateId()
{
//获取某学院所有专业信息
string strSQL = "select UserStateId, UserStateName from QxUserState ";
 clsSpecSQLforSql mySql = clsQxUsers4SynchBL.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.clsGeneCodeBase:GenDdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public void BindDdl_UserStateId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetUserStateId();
objDDL.DataValueField = clsQxUserStateEN.con_UserStateId;
objDDL.DataTextField = clsQxUserStateEN.con_UserStateName;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}
/// <summary>
/// 为下拉框获取数据,从表:[QxDepartmentInfo]中获取
 /// (AutoGCLib.clsGeneCodeBase:GenDdlBindFunction)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
public System.Data.DataTable GetDepartmentId()
{
//获取某学院所有专业信息
string strSQL = "select DepartmentId, DepartmentName from QxDepartmentInfo ";
 clsSpecSQLforSql mySql = clsQxUsers4SynchBL.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.clsGeneCodeBase:GenDdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public void BindDdl_DepartmentId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetDepartmentId();
objDDL.DataValueField = clsQxDepartmentInfoEN.con_DepartmentId;
objDDL.DataTextField = clsQxDepartmentInfoEN.con_DepartmentName;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}
public void SetDdl_UserId()
{
clsQxUsersBL.BindDdl_UserId(ddlUserId);
}
public void SetDdl_UserStateId()
{
clsQxUserStateBL.BindDdl_UserStateId(ddlUserStateId);
}
public void SetDdl_DepartmentId()
{
clsQxDepartmentInfoBL.BindDdl_DepartmentId(ddlDepartmentId);
}
}
}