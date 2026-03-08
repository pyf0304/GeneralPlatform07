
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:wucQxUsersB
 界面名:wfmUsers_QUDI(00140010)
 生成代码版本:2019.03.23.1
 生成日期:2019/03/23 17:41:35
 生成者:
 工程名称:统一平台
 工程ID:0014
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
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

using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;

 /// <summary>
 ///		wucQxUsersB 的摘要说明。
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public partial class wucQxUsersB : System.Web.UI.UserControl
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
 /// 用户ID
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
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
 /// 有效日期
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string EffitiveEndDate
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
 /// 学院流水号
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string IdCollege
{
get
{
return txtIdCollege.Text.Trim();
}
set
{
txtIdCollege.Text = value.ToString();
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
 /// 身份编号
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string IdentityId
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
 /// 微信OpenId
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string OpenId
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
 /// 是否同步
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public bool IsSynch
{
get
{
return chkIsSynch.Checked;
}
set
{
chkIsSynch.Checked = value;
}
}

 /// <summary>
 /// 同步日期
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
 /// </summary>
public string SynchDate
{
get
{
return txtSynchDate.Text.Trim();
}
set
{
txtSynchDate.Text = value.ToString();
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
/// 在用户自定义控件中，设置关键字的值，是否只读
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
/// </summary>
/// <param name = "bolReadonly">是否只读</param>
public void SetKeyReadOnly(bool bolReadonly)
{
txtUserId.ReadOnly = bolReadonly;
}
/// <summary>
/// 清除用户自定义控件中，所有控件的值
 /// (AutoGCLib.WebCtlControlCode4CSharp:GeneCode)
/// </summary>	
public void Clear()
{
txtUserId.Text = "";
txtUserName.Text = "";
ddlDepartmentId.SelectedIndex = 0;
ddlUserStateId.SelectedIndex = 0;
txtEffectiveDate.Text = "";
txtPassword.Text = "";
txtIdCollege.Text = "";
txtEffitiveBeginDate.Text = "";
txtEffitiveEndDate.Text = "";
txtStuTeacherId.Text = "";
txtIdentityID.Text = "";
chkIsArchive.Checked = false;
txtopenid.Text = "";
txtEmail.Text = "";
txtPhoneNumber.Text = "";
chkIsSynch.Checked = false;
txtSynchDate.Text = "";
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
txtUserId.Text = "";
txtUserName.Text = "";
ddlDepartmentId.SelectedIndex = 0;
ddlUserStateId.SelectedIndex = 0;
txtEffectiveDate.Text = "";
txtPassword.Text = "";
txtIdCollege.Text = "";
txtEffitiveBeginDate.Text = "";
txtEffitiveEndDate.Text = "";
txtStuTeacherId.Text = "";
txtIdentityID.Text = "";
chkIsArchive.Checked = false;
txtopenid.Text = "";
txtEmail.Text = "";
txtPhoneNumber.Text = "";
chkIsSynch.Checked = false;
txtSynchDate.Text = "";
txtUpdDate.Text = "";
txtUpdUser.Text = "";
txtMemo.Text = "";
}
/// <summary>
/// 为下拉框获取数据,从表:[QxDepartmentInfo]中获取
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
public System.Data.DataTable GetDepartmentId()
{
//获取某学院所有专业信息
string strSQL = "select DepartmentId, DepartmentName from QxDepartmentInfo ";
 clsSpecSQLforSql mySql = clsQxUsersBL.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public void BindDdl_DepartmentId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetDepartmentId();
objDDL.DataValueField = conQxDepartmentInfo.DepartmentId;
objDDL.DataTextField = conQxDepartmentInfo.DepartmentName;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}
/// <summary>
/// 为下拉框获取数据,从表:[QxUserState]中获取
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
/// </summary>
/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>
public System.Data.DataTable GetUserStateId()
{
//获取某学院所有专业信息
string strSQL = "select UserStateId, UserStateName from QxUserState ";
 clsSpecSQLforSql mySql = clsQxUsersBL.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public void BindDdl_UserStateId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
ListItem li = new ListItem("请选择...","0");
System.Data.DataTable objDT = GetUserStateId();
objDDL.DataValueField = conQxUserState.UserStateId;
objDDL.DataTextField = conQxUserState.UserStateName;
objDDL.DataSource = objDT;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}
public void SetDdl_DepartmentId()
{
clsQxDepartmentInfoBL.BindDdl_DepartmentId(ddlDepartmentId);
}
public void SetDdl_UserStateId()
{
clsQxUserStateBL.BindDdl_UserStateId(ddlUserStateId);
}
}
}