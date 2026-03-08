
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:wfmQxUserRoleRelationB_QUDI
 界面名:wfmQxUserRoleRelation_QUDI(00140007)
 生成代码版本:2019.03.25.1
 生成日期:2019/03/25 06:59:23
 生成者:
 工程名称:统一平台
 工程ID:0014
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
 框架-层名:Web界面后台代码(WebViewControlCode)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */

using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;



using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;
using GeneralPlatform;
namespace GeneralPlatform.Webform
{
 /// <summary>
 /// wfmQxUserRoleRelationB_QUDI 的摘要说明。其中Q代表查询,U代表修改
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenQueryUpdDelInsRecControlCodeWithWuc4Gv)
 /// </summary>
public partial class wfmQxUserRoleRelationB_QUDI : System.Web.UI.Page
{

#region 页面启动函数
 /// <summary>
 /// 函数功能:页面导入,当页面开始运行时所发生的事件
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPage_LoadCode)
 /// </summary>
 /// <param name = "sender"></param>
 /// <param name = "e"></param>
protected void Page_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面
if (!IsPostBack)	///如果本界面是初次被调用,而不是单击按钮事件所调用
{

vsViewName = "用户角色关系维护";
vsTabName = string.Format("{0}", clsvQxUserRoleRelationEN._CurrTabName);
//生成权限有关判断权限的代码
//根据等级权限编号来确定用户可以使用什么功能,等级编号方式:1为最大2其次,依此类推
switch (vsPotenceLevel)
{
case "0":
Response.Redirect("../error.aspx");
break;
case "1":
Response.Redirect("../error.aspx");
break;
case "2":
Response.Redirect("../error.aspx");
break;
case "3":
Response.Redirect("../error.aspx");
break;
case "4":
Response.Redirect("../error.aspx");
break;
case "9":
break;
default:
Response.Redirect("../error.aspx");
break;
}


//1、为下拉框设置数据源,绑定列表数据
wucQxUserRoleRelationB1.SetDdl_UserId();
wucQxUserRoleRelationB1.SetDdl_RoleId("");
wucQxUserRoleRelationB1.SetDdl_QxPrjId();
clsQxUsersBL.BindDdl_UserId(ddlUserId_q);
clsQxDepartmentInfoBL.BindDdl_DepartmentId(ddlDepartmentId_q);
clsQxUserStateBL.BindDdl_UserStateId(ddlUserStateId_q);
clsQxRolesBL.BindDdl_RoleId(ddlRoleId_q,"");
clsQxProjectsBL.BindDdl_QxPrjId(ddlQxPrjId_q);
wucvQxUserRoleRelation4Gv1.SetSortBy(string.Format("{0} Asc", convQxUserRoleRelation.mId));
//2、显示无条件的表内容在GridView中
BindGv_vQxUserRoleRelation();
//3、设置表控件中字控件的ReadOnly属性,
// 使之只读,因为在修改功能中关键字是不能被修改的。
DispQxUserRoleRelationListRegion();
//设置逻辑层的公共函数，包含：缓存刷新函数
//clsQxUserRoleRelationBL.objCommFun4BL = new clsCommFun4BL4QxUserRoleRelation();
}
}

#endregion 页面启动函数


#region 查询相关函数
 /// <summary>
 /// 函数功能:事件函数,当单击<查询>按钮时所发生的事件
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnQuery_ClickCode)
 /// </summary>
 /// <param name = "sender"></param>
 /// <param name = "e"></param>
protected void btnQuery_Click(object sender, System.EventArgs e)
{
//把GridView的当前页索引设置为0,即第1页。
//当单击查询时,首先显示的是表记录内容的第一部分内容。
 wucvQxUserRoleRelation4Gv1.vsPageIndex = 1;
//把表记录的内容显示在GridView中
BindGv_vQxUserRoleRelation();
}
 /// <summary>
 /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在GridView中。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4WucInPage)
 /// </summary>
protected void BindGv_vQxUserRoleRelation()
{
//操作步骤:(共5步)
//	1、组合界面条件串；
//	2、调用控件中的绑定GridView函数;
//	3、设置Gv控件的某些列不可见;

try
{
//	1、组合界面条件串；
string strWhereCond = CombinevQxUserRoleRelationCondition();
//	2、调用控件中的绑定GridView函数；
 wucvQxUserRoleRelation4Gv1.BindGv_QxUserRoleRelation(strWhereCond);
//	3、设置Gv控件的某些列不可见；
//wucvQxUserRoleRelation4Gv1.SetGvVisibility(convQxUserRoleRelation.UpdDate, false);
//wucvQxUserRoleRelation4Gv1.SetGvVisibility(convQxUserRoleRelation.UpdUser, false);
}
catch (Exception objException)
{
string strMsg = "(errid:WebI000019)绑定GridView出错!" + objException.Message;
clsCommonJsFunc.Alert(this, strMsg);
return;
}

}

 /// <summary>
 /// 把所有的查询控件内容组合成一个条件串
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenCombineCondition)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
protected string CombinevQxUserRoleRelationCondition()
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
clsvQxUserRoleRelationEN objvQxUserRoleRelationEN = new clsvQxUserRoleRelationEN();
try
{
if (this.ddlUserId_q.SelectedValue!= "" && this.ddlUserId_q.SelectedValue!= "0")
{
objvQxUserRoleRelationEN.UserId = this.ddlUserId_q.SelectedValue;
strWhereCond += string.Format(" And {0} = '{1}'", convQxUserRoleRelation.UserId, this.ddlUserId_q.SelectedValue);
}
if (this.txtUserName_q.Text.Trim()!= "")
{
objvQxUserRoleRelationEN.UserName = this.txtUserName_q.Text.Trim();
strWhereCond += string.Format(" And {0} like '%{1}%'", convQxUserRoleRelation.UserName, this.txtUserName_q.Text.Trim());
}
if (this.ddlDepartmentId_q.SelectedValue!= "" && this.ddlDepartmentId_q.SelectedValue!= "0")
{
objvQxUserRoleRelationEN.DepartmentId = this.ddlDepartmentId_q.SelectedValue;
strWhereCond += string.Format(" And {0} = '{1}'", convQxUserRoleRelation.DepartmentId, this.ddlDepartmentId_q.SelectedValue);
}
if (this.ddlUserStateId_q.SelectedValue!= "" && this.ddlUserStateId_q.SelectedValue!= "0")
{
objvQxUserRoleRelationEN.UserStateId = this.ddlUserStateId_q.SelectedValue;
strWhereCond += string.Format(" And {0} = '{1}'", convQxUserRoleRelation.UserStateId, this.ddlUserStateId_q.SelectedValue);
}
if (this.txtIdentityID_q.Text.Trim()!= "")
{
objvQxUserRoleRelationEN.IdentityId = this.txtIdentityID_q.Text.Trim();
strWhereCond += string.Format(" And {0} like '%{1}%'", convQxUserRoleRelation.IdentityId, this.txtIdentityID_q.Text.Trim());
}
if (this.ddlRoleId_q.SelectedValue!= "" && this.ddlRoleId_q.SelectedValue!= "0")
{
objvQxUserRoleRelationEN.RoleId = this.ddlRoleId_q.SelectedValue;
strWhereCond += string.Format(" And {0} = '{1}'", convQxUserRoleRelation.RoleId, this.ddlRoleId_q.SelectedValue);
}
if (this.ddlQxPrjId_q.SelectedValue!= "" && this.ddlQxPrjId_q.SelectedValue!= "0")
{
objvQxUserRoleRelationEN.QxPrjId = this.ddlQxPrjId_q.SelectedValue;
strWhereCond += string.Format(" And {0} = '{1}'", convQxUserRoleRelation.QxPrjId, this.ddlQxPrjId_q.SelectedValue);
}
clsvQxUserRoleRelationBL.CheckProperty4Condition(objvQxUserRoleRelationEN);
}
catch(Exception objException)
{
string strMsg = string.Format("(errid:WebI000024)在组合查询条件(CombineQxUserRoleRelationCondition)时出错!请联系管理员!" + objException.Message);
throw new Exception(strMsg);
}
return strWhereCond;
}

 /// <summary>
 /// 专门用于记录GridView中的每页记录数
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPageSizeViewState)
 /// </summary>
public int vsPageSize
{
get
{
string strPageSize;
strPageSize = (string)ViewState["PageSize"];
if (strPageSize == null)
{
strPageSize = "";
return 15;
}
return int.Parse(strPageSize);
}
set
{
string strPageSize = value.ToString();
ViewState.Add("PageSize", strPageSize);
}
}

#endregion 查询相关函数



#region 添加相关函数

 ///添加新记录的事件过程,建议在该过程中调用其他函数,不要在其中添加多行代码。
 /// <summary>
 ///添加新记录的事件过程 
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnAddNewRec4Gv_Click)
 /// </summary>
protected void btnAddNewRec4Gv_Click(object sender, System.EventArgs e)
{
AddQxUserRoleRelationRecord();
}
 /// <summary>
 /// 为插入记录做准备工作
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordCode)
 /// </summary>
protected void AddQxUserRoleRelationRecord()
{
btnOKUpd.Text = "确认添加";
btnCancelQxUserRoleRelationEdit.Text = "取消添加";
//wucQxUserRoleRelationB1.mId = clsQxUserRoleRelationBL.GetMaxStrId_S();
DispEditQxUserRoleRelationRegion();
}
 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenAddRecordSaveCode)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
protected bool AddQxUserRoleRelationRecordSave()
{
//操作步骤:
//1、检查控件中输入数据类型是否正确
//2、定义对象并初始化对象
//3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//3.2、检查唯一性
//4、把值从界面层传到逻辑层或数据实体层
//5、检查传进去的对象属性是否合法
//6、把数据实体层的数据存贮到数据库中
//7、把新添的记录内容显示在GridView中
string strMsg;	//专门用于传递信息的变量
string strResult = " ";	//用于传递在检验对象属性时结果值的变量
clsQxUserRoleRelationEN objQxUserRoleRelationEN;
//1、检查控件中输入数据类型是否正确
if (!wucQxUserRoleRelationB1.IsValid(ref strResult))
{
lblMsg_Edit.Text = "(errid:WebI000003)控件中输入数据类型不正确请检查!";
return false;
}
//2、定义对象并初始化对象
//clsQxUserRoleRelationEN objQxUserRoleRelationEN;	//定义对象
objQxUserRoleRelationEN = new clsQxUserRoleRelationEN();	//初始化新对象

//3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//4、把值从界面层传到逻辑层或数据实体层
PutDataToQxUserRoleRelationClass(objQxUserRoleRelationEN);		//把界面的值传到
 //5.1、检查传进去的对象属性是否合法
try
{
clsQxUserRoleRelationBL.CheckPropertyNew(objQxUserRoleRelationEN);
//6、把数据实体层的数据存贮到数据库中
clsQxUserRoleRelationBL.AddNewRecordBySql2(objQxUserRoleRelationEN);
}
catch(Exception objException)
{
strMsg = "(errid:WebI000005)添加记录不成功!" + objException.Message;
clsCommonJsFunc.Alert(this, strMsg);
lblMsg_Edit.Text = strMsg;
return false;
}
strMsg = "添加记录成功!";
clsCommonJsFunc.Alert(this, strMsg);
lblMsg_Edit.Text = "添加记录成功!";
//7、把新添的记录内容显示在GridView中
BindGv_vQxUserRoleRelation();
DispQxUserRoleRelationListRegion();
wucQxUserRoleRelationB1.Clear();		//清空控件中内容
 ///恢复<确认添加>变成<添加>
btnOKUpd.Text = "添加";
btnCancelQxUserRoleRelationEdit.Text = "取消编辑";
return true;
}
#endregion 添加相关函数


#region 修改相关函数

 /// <summary>
 ///修改当前被选记录
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnUpdate4Gv_Click4OneKeyword)
 /// </summary>
protected void btnUpdate4Gv_Click(object sender, System.EventArgs e)
{
//1、显示该关键字的数据让用户修改该关键字记录；
long lngmId = wucvQxUserRoleRelation4Gv1.GetFirstCheckedKeyFromGv();
if (lngmId == 0) return;
UpdateQxUserRoleRelationRecord(lngmId);
}

 /// <summary>
 /// 函数功能:把以该关键字的记录内容显示在界面上,
 ///　　　   在这里是把值传到表控件中
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenShowDataCode)
 /// </summary>
 /// <param name = "lngmId">表记录的关键字,显示该表关键字的内容</param>
protected void ShowData(long lngmId)
{
//操作步骤:
//1、检查关键字是否为空；
//2、检查该关键字的记录是否存在,如果不存在就返回不显示；
//3、用提供的关键字初始化一个类对象；
//4、获取类对象的所有属性；
//5、把该对象的所有属性显示在界面上,在这里显示在表控件中

//1、检查关键字是否为空；
if (lngmId == 0) return ;		//如果关键字为空就返回退出
//2、检查该关键字的记录是否存在,如果不存在就返回不显示；
if (clsQxUserRoleRelationBL.IsExist(lngmId) == false)		//检查该关键字的记录是否存在
{
string strMsg = "(errid:WebI000010)在表[QxUserRoleRelation]中,关键字为:[lngmId]的记录不存在!";
clsCommonJsFunc.Alert(this, strMsg);
return ;
}
//3、用提供的关键字初始化一个类对象；
clsQxUserRoleRelationEN objQxUserRoleRelationEN = new clsQxUserRoleRelationEN(lngmId);
//4、获取类对象的所有属性；
try
{
clsQxUserRoleRelationBL.GetQxUserRoleRelation(ref objQxUserRoleRelationEN);
}
catch (Exception objException)
{
string strMsg = "(errid:WebI000020)在显示数据时获取记录对象不成功!" + objException.Message;
clsCommonJsFunc.Alert(this, strMsg);
lblMsg_Edit.Text = strMsg;
return;
}
Session.Add("objQxUserRoleRelationEN", objQxUserRoleRelationEN);
//5、把该对象的所有属性显示在界面上,在这里显示在表控件中
GetDataFromQxUserRoleRelationClass(objQxUserRoleRelationEN);
}
 /// <summary>
 /// 函数功能:把类对象的属性内容显示到界面上
 ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
 /// 如果在设置数据库时,就应该一级字段在前,二级字段在后
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenGetDataFromClass)
 /// </summary>
 /// <param name = "pobjQxUserRoleRelationEN">表实体类对象</param>
protected void GetDataFromQxUserRoleRelationClass(clsQxUserRoleRelationEN pobjQxUserRoleRelationEN)
{
wucQxUserRoleRelationB1.UserId = pobjQxUserRoleRelationEN.UserId;// 用户ID
wucQxUserRoleRelationB1.RoleId = pobjQxUserRoleRelationEN.RoleId;// 角色Id
wucQxUserRoleRelationB1.QxPrjId = pobjQxUserRoleRelationEN.QxPrjId;// 项目Id
wucQxUserRoleRelationB1.UpdDate = pobjQxUserRoleRelationEN.UpdDate;// 修改日期
wucQxUserRoleRelationB1.UpdUserId = pobjQxUserRoleRelationEN.UpdUser;// 修改用户Id
wucQxUserRoleRelationB1.Memo = pobjQxUserRoleRelationEN.Memo;// 备注
}
 ///
/// <summary>
/// 事件函数:在Gv列表控件中，当GeidView行单击修改时发生的事件。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvUpdateClick)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void wucvQxUserRoleRelation4Gv1_GvUpdateClick(object sender, clsEventArgs4Update e)
{
long lngmId = long.Parse(e.KeyId);
  UpdateQxUserRoleRelationRecord(lngmId);
}
 /// <summary>
 /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordCode)
 /// </summary>
protected void UpdateQxUserRoleRelationRecord(long lngmId)
{
//操作步骤:(总共2步)
//1、显示该关键字记录的内容在界面上；
//2、清空提示信息的内容,同时使<确定修改>按钮可用；

//1、显示该关键字记录的内容在界面上；
ShowData(lngmId);
//2、清空提示信息的内容,同时使<确定修改>按钮可用；
btnOKUpd.Enabled = true;
btnOKUpd.Text = "确认修改";
btnCancelQxUserRoleRelationEdit.Text = "取消修改";
lblMsg_Edit.Text = "";
DispEditQxUserRoleRelationRegion();
}
 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenUpdateRecordSaveCode)
 /// </summary>
 /// <param name = "objQxUserRoleRelationEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
protected bool UpdateQxUserRoleRelationRecordSave(clsQxUserRoleRelationEN objQxUserRoleRelationEN)
{
//操作步骤:
//1、检查控件中输入数据类型是否正确
//2、把值从界面层传到逻辑层或数据实体层
//3.1、检查传进去的对象属性是否合法
//3.2、检查唯一性
//4、把数据实体层的数据存贮到数据库中
//5、把修改后的内容显示在GridView中
string strMsg;	//专门用于传递信息的变量
string strResult = " ";	//用于传递在检验对象属性时结果值的变量
//1、检查控件中输入数据类型是否正确
if (!wucQxUserRoleRelationB1.IsValid(ref strResult))
{
lblMsg_Edit.Text = "(errid:WebI000011)控件中输入数据类型不正确请检查!";
return false;
}
//2、把值从界面层传到逻辑层或数据实体层
PutDataToQxUserRoleRelationClass(objQxUserRoleRelationEN);		//把界面的值传到
//3.1、检查传进去的对象属性是否合法
try
{
clsQxUserRoleRelationBL.CheckPropertyNew(objQxUserRoleRelationEN);
//4、把数据实体层的数据存贮到数据库中
clsQxUserRoleRelationBL.UpdateBySql2(objQxUserRoleRelationEN);
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
clsCommonJsFunc.Alert(this, strMsg);
lblMsg_Edit.Text = strMsg;
return false; 
}
strMsg = "修改记录成功!";
clsCommonJsFunc.Alert(this, strMsg);
lblMsg_Edit.Text = "修改记录成功!";
//5、把修改后的内容显示在GridView中
BindGv_vQxUserRoleRelation();
DispQxUserRoleRelationListRegion();
wucQxUserRoleRelationB1.Clear();//添空控件中的内容
//恢复<确认修改>变成<添加>
btnOKUpd.Text = "添加";
btnCancelQxUserRoleRelationEdit.Text = "取消编辑";
//跳转到列表中刚刚的记录处,使用锚点功能。
this.ClientScript.RegisterStartupScript(this.GetType(), "Go-Anchor", string.Format("this.location.href = '#A_QxUserRoleRelation{0}'", objQxUserRoleRelationEN.mId.ToString().Trim()), true);
return true; 
}
#endregion 修改相关函数


#region 添加修改共用函数
 /// <summary>
 /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
 /// 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnOKUpd_ClickCode)
 /// </summary>
 /// <param name = "sender"></param>
 /// <param name = "e"></param>
protected void btnOKUpd_Click(object sender, System.EventArgs e)
{
string strCommandText;
clsQxUserRoleRelationEN objQxUserRoleRelationEN;
Button btnTemp;
btnTemp = (Button) sender;
strCommandText = btnTemp.Text;
switch(strCommandText)
{
case "添加":
AddQxUserRoleRelationRecord();
break;				
case "确认添加":
//这是一个单表的插入的代码,由于逻辑层太简单,
//就把逻辑层合并到控制层,
AddQxUserRoleRelationRecordSave();
break;
case "确认修改":
//这是一个单表的修改的代码,由于逻辑层太简单,
//就把逻辑层合并到控制层,
objQxUserRoleRelationEN = (clsQxUserRoleRelationEN) Session["objQxUserRoleRelationEN"];
UpdateQxUserRoleRelationRecordSave(objQxUserRoleRelationEN);
break;
}
}
/// <summary>
/// 事件函数:取消编辑状态，退回到列表状态
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_btnCancelEdit_Click)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void btnCancelQxUserRoleRelationEdit_Click(object sender, EventArgs e)
{
DispQxUserRoleRelationListRegion();
}
 /// <summary>
 /// 函数功能:把界面上的属性数据传到类对象中
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPutDataToClass)
 /// </summary>
 /// <param name = "pobjQxUserRoleRelationEN">数据传输的目的类对象</param>
protected void PutDataToQxUserRoleRelationClass(clsQxUserRoleRelationEN pobjQxUserRoleRelationEN)
{
pobjQxUserRoleRelationEN.UserId = wucQxUserRoleRelationB1.UserId;// 用户ID
pobjQxUserRoleRelationEN.RoleId = wucQxUserRoleRelationB1.RoleId;// 角色Id
pobjQxUserRoleRelationEN.QxPrjId = wucQxUserRoleRelationB1.QxPrjId;// 项目Id
pobjQxUserRoleRelationEN.UpdDate = wucQxUserRoleRelationB1.UpdDate;// 修改日期
pobjQxUserRoleRelationEN.UpdUser = wucQxUserRoleRelationB1.UpdUserId;// 修改用户Id
pobjQxUserRoleRelationEN.Memo = wucQxUserRoleRelationB1.Memo;// 备注
}

#endregion 添加修改共用函数


#region 删除相关函数

 /// <summary>
 ///删除当前被选记录
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenbtnDelete4Gv_Click4OneKeyword)
 /// </summary>
protected void btnDelete4Gv_Click(object sender, System.EventArgs e)
{
List<long> lstMId = wucvQxUserRoleRelation4Gv1.GetAllCheckedKeysFromGv();
if (lstMId == null) return;
lblMsg_List.Text = "";
try
{
foreach (long lngmId in lstMId)
{
clsQxUserRoleRelationBL.DelRecord(lngmId);
}
}
catch (Exception objException)
{
string strMsg = "(errid:WebI000021)删除记录不成功!" + objException.Message;
clsCommonJsFunc.Alert(this, strMsg);
lblMsg_List.Text = strMsg;
return;
}
BindGv_vQxUserRoleRelation();
}
 ///
/// <summary>
/// 事件函数:在Gv列表控件中，当GeidView行单击删除时发生的事件。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_Wuc4Gv_GvDeleteClick)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void wucvQxUserRoleRelation4Gv1_GvDeleteClick(object sender, clsEventArgs4Delete e)
{
long lngmId = long.Parse(e.KeyId);
  DeleteQxUserRoleRelationRecord(lngmId);
}
 /// <summary>
 /// 根据给定关键字删除记录
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDelRecordCode)
 /// </summary>
 /// <param name = "lngmId">给定关键字</param>
protected void DeleteQxUserRoleRelationRecord(long lngmId)
{
try
{
clsQxUserRoleRelationBL.DelRecord(lngmId);
}
catch (Exception objException)
{
string strMsg = "(errid:WebI000022)删除记录不成功!" + objException.Message;
clsCommonJsFunc.Alert(this, strMsg);
lblMsg_List.Text = strMsg;
return;
}
BindGv_vQxUserRoleRelation();
}
#endregion 删除相关函数


#region 导出函数

/// <summary>
/// 事件函数:把查询条件的表记录，导出到Excel.
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void btnExportExcel4Gv_Click(object sender, System.EventArgs e)
{
//导出Excel函数
ExportExcel();
}


 /// <summary>
 /// 导出Excel。根据查询区组合的查询条件,从[vQxUserRoleRelation]表中获取记录集,最终导出到Excel
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenExportExcel)
 /// </summary>
private void ExportExcel()
{
//	1、组合界面条件串；
string strWhereCond = CombinevQxUserRoleRelationCondition();
//	2、根据条件串获取该表满足条件的DataTable；
System.Data.DataTable objDT = null;
List<string> arrCnName = new List<string>();
List<string> arrColName = new List<string>();
string strFileName = "QxUserRoleRelation信息导出.xls";
string strFolderName;
string strDownLoadFileName;
arrColName.Add(convQxUserRoleRelation.UserName); arrCnName.Add("用户名");
arrColName.Add(convQxUserRoleRelation.DepartmentName); arrCnName.Add("部门名");
arrColName.Add(convQxUserRoleRelation.UserStateName); arrCnName.Add("用户状态名");
arrColName.Add(convQxUserRoleRelation.IdentityDesc); arrCnName.Add("身份描述");
arrColName.Add(convQxUserRoleRelation.RoleName); arrCnName.Add("角色名称");
arrColName.Add(convQxUserRoleRelation.PrjName); arrCnName.Add("工程名");
arrColName.Add(convQxUserRoleRelation.Memo); arrCnName.Add("备注");
strFolderName = clsSysParaEN.TempFileFolder;
strDownLoadFileName = strFolderName + strFileName;
//初始化需要导出的Excel文件,即复制标准Excel文件作为母版,复制不成功即不能导出
if (clsPubVar.InitExcelFile(this, strFolderName, strDownLoadFileName) == false)
{
return;
}
try
{
//	2、根据条件串获取该表满足条件的DataTable；
objDT = clsvQxUserRoleRelationBL.GetDataTable(strWhereCond);
}
catch (Exception objException)
{
string strMsg = string.Format("获取数据出错,请联系管理员！错误:{0}.({1})",
objException.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
return;
}
  try
  {
//用户Odbc的方式来导出Excel,在Web服务器不需要安装Excel,目前是Excel2003,如果希望2007,可以换下面一条语句。
GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4Odbc(objDT, arrColName, arrCnName, strDownLoadFileName);
}
 catch (Exception objException)
 {
 try
 {
clsSysParaEN.objErrorLog.WriteDebugLog(objException.Message);
GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr4OdbcExcel2007(objDT, arrColName, arrCnName, strDownLoadFileName);
//GetExcelFromDataTable.clsGetExcelFromDataTable.GetExcelFromDataTableByArr(objDT, arrColName, arrCnName, strDownLoadFileName);
}
catch (Exception objException2)
{
string strMsg = string.Format("导出Excel出错,请联系管理员！错误:{0}.({1})",
objException2.Message, clsStackTrace.GetCurrClassFunction());
clsCommonJsFunc.Alert(this, strMsg);
return;
}
}
clsCommForWebForm.DownLoadFile(strDownLoadFileName);
}
#endregion 导出函数


#region 布局控制函数
 /// <summary>
 /// 布局控制函数,显示数据列表区,并隐藏用于编辑的用户控件
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispListRegion)
 /// </summary>
private void DispQxUserRoleRelationListRegion()
{
divList.Visible = true;
tabEditQxUserRoleRelationRegion.Visible = false;
}
 /// <summary>
 /// 布局控制函数,显示用于编辑的用户控件,并隐藏数据列表区
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenDispEditRegion)
 /// </summary>
private void DispEditQxUserRoleRelationRegion()
{
divList.Visible = false;
tabEditQxUserRoleRelationRegion.Visible = true;
}
#endregion 布局控制函数


#region 错误处理函数

 /// <summary>
 /// Session属性:错误信息的Session属性,该Session传递给显示出错页面,显示相应的错误内容。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenErrMessageSession)
 /// </summary>
protected string seErrMessage
{
get
{
string strErrMessage;
strErrMessage = (string)Session["ErrMessage"];
if (strErrMessage == null) 
{
strErrMessage = "";
}
return strErrMessage;
}
set
{
string strErrMessage = value;
Session.Add("ErrMessage", strErrMessage);
}
}


 /// <summary>
 /// Session属性:返回链接串的Session属性,该Session用于告诉出错页面,哪一个页面是需要返回的页面。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBackLinkStrSession)
 /// </summary>
protected string seBackErrPageLinkStr
{
get
{
string strBackErrPageLinkStr;
strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
if (strBackErrPageLinkStr == null) 
{
strBackErrPageLinkStr = "";
}
return strBackErrPageLinkStr;
}
set
{
string strBackErrPageLinkStr = value;
Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
}
}

#endregion 错误处理函数


#region 权限处理函数

 /// <summary>
 /// ViewState属性:当前操作的界面功能名称
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
 /// </summary>
protected string vsViewName
{
get
{
string sViewName;
sViewName = (string)ViewState["ViewName"];
if (sViewName == null)
{
sViewName = "";
}
return sViewName;
}
set
{
string sViewName = value;
ViewState.Add("ViewName", sViewName);
}
}
 /// <summary>
 /// ViewState属性:当前操作的导出表名称
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
 /// </summary>
protected string vsTabName
{
get
{
string sTabName;
sTabName = (string)ViewState["TabName"];
if (sTabName == null)
{
sTabName = "";
}
return sTabName;
}
set
{
string sTabName = value;
ViewState.Add("TabName", sTabName);
}
}
 /// <summary>
 /// QueryString属性:通过QueryString传递过来的UserId参数。这里是样例,大家可以参考这个样例。
 /// 姓名:
 /// 日期:
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
 /// </summary>
private string qsUserId
{
get
{
string strUserId = Request.QueryString[ "UserId"] ?? "".ToString();
if ((strUserId != null) && (strUserId != ""))
{
return strUserId;
}
else
{
return "";
}
}
}
/// <summary>
/// 与权限相关的界面编号
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceRelaVar)
/// </summary>
protected const string ViewId4Potence = "00260203";		//界面编号


/// <summary>
/// ViewState属性:用于记录当前用户在当前界面的权限等级
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPotenceLevelProperty)
/// </summary>
protected string vsPotenceLevel
{
get
{
string sPotenceLevel;
sPotenceLevel = (string)ViewState["PotenceLevel"];
if (sPotenceLevel == null) 
{
//					sPotenceLevel = new General_Platform_Dll.MenuAndPotence().Get_PotenceLevel(ViewId4Potence);
sPotenceLevel = "9";
ViewState.Add("PotenceLevel", sPotenceLevel);
}
return sPotenceLevel;
}
}


 /// <summary>
 /// Session属性:登录的用户ID,用于检查用户权限
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenLoginUserSession)
 /// </summary>
protected string seUserId
{
get
{
string strUserId;
strUserId = (string)Session["UserId"];
if (strUserId == null) 
{
strUserId = "";
}
return strUserId;
}
set
{
string strUserId = value;
Session.Add("UserId", strUserId);
}
}
 ///protected clsUsersEN objUser
 ///{
 ///get
 ///{
 ///clsUsersEN pobjUser;
 ///pobjUser = (clsUsersEN)Session["objUser"];
 ///if (pobjUser == null) 
 ///{
 ///pobjUser = null;
 ///}
 ///return pobjUser;
 ///}
 ///set
 ///{
 ///clsUsersEN pobjUser = value;
 ///Session.Add("objUser", pobjUser);
 ///}
 ///}



#endregion 权限处理函数

}
}