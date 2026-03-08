
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenusEN
 表名:vQxPrjMenus(00140046)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:33:11
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:菜单管理(MenuManage_GP)
 框架-层名:实体层(CS)(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace GeneralPlatform.Entity
{
 /// <summary>
 /// 表vQxPrjMenus的关键字(MenuId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MenuId_vQxPrjMenus
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strMenuId">表关键字</param>
public K_MenuId_vQxPrjMenus(string strMenuId)
{
if (IsValid(strMenuId)) Value = strMenuId;
else
{
Value = null;
}
}
private static bool IsValid(string strMenuId)
{
if (string.IsNullOrEmpty(strMenuId) == true) return false;
if (strMenuId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MenuId_vQxPrjMenus]类型的对象</returns>
public static implicit operator K_MenuId_vQxPrjMenus(string value)
{
return new K_MenuId_vQxPrjMenus(value);
}
}
 /// <summary>
 /// v工程菜单(vQxPrjMenus)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxPrjMenusEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxPrjMenus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MenuId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 29;
public static string[] AttributeName = new string[] {"MenuId", "MenuName", "QxPrjId", "PrjName", "UpMenuId", "LinkFile", "qsParameters", "TabId", "TabName", "ImgFile", "RoleId", "RoleName", "OrderNum", "IsLeafNode", "MenuSetId", "MenuSetName", "MenuTitle", "PageDispModeId", "PageDispModeName", "InUse", "MenuControlName", "ApplicationTypeId", "ApplicationTypeName", "UpdDate", "UpdUserId", "Memo", "UpMenuName", "SubMenusNum", "RoleNum"};

protected string mstrMenuId;    //菜单Id
protected string mstrMenuName;    //菜单名
protected string mstrQxPrjId;    //项目Id
protected string mstrPrjName;    //工程名
protected string mstrUpMenuId;    //上级菜单Id
protected string mstrLinkFile;    //链接文件
protected string mstrqsParameters;    //qs参数
protected string mstrTabId;    //表ID
protected string mstrTabName;    //TabName
protected string mstrImgFile;    //图像文件
protected string mstrRoleId;    //角色Id
protected string mstrRoleName;    //角色名称
protected int? mintOrderNum;    //排序号
protected bool mbolIsLeafNode;    //是否叶子
protected string mstrMenuSetId;    //菜单集Id
protected string mstrMenuSetName;    //菜单集名称
protected string mstrMenuTitle;    //菜单标题
protected string mstrPageDispModeId;    //页面显示模式Id
protected string mstrPageDispModeName;    //页面显示模式名称
protected bool mbolInUse;    //是否在用
protected string mstrMenuControlName;    //MenuControlName
protected int mintApplicationTypeId;    //应用程序类型ID
protected string mstrApplicationTypeName;    //应用程序类型名称
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected string mstrUpMenuName;    //上级菜单名
protected int? mintSubMenusNum;    //子菜单数
protected int? mintRoleNum;    //角色数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxPrjMenusEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MenuId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strMenuId">关键字:菜单Id</param>
public clsvQxPrjMenusEN(string strMenuId)
 {
strMenuId = strMenuId.Replace("'", "''");
if (strMenuId.Length > 8)
{
throw new Exception("在表:vQxPrjMenus中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strMenuId)  ==  true)
{
throw new Exception("在表:vQxPrjMenus中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMenuId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrMenuId = strMenuId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MenuId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  convQxPrjMenus.MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  convQxPrjMenus.MenuName)
{
return mstrMenuName;
}
else if (strAttributeName  ==  convQxPrjMenus.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxPrjMenus.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxPrjMenus.UpMenuId)
{
return mstrUpMenuId;
}
else if (strAttributeName  ==  convQxPrjMenus.LinkFile)
{
return mstrLinkFile;
}
else if (strAttributeName  ==  convQxPrjMenus.qsParameters)
{
return mstrqsParameters;
}
else if (strAttributeName  ==  convQxPrjMenus.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  convQxPrjMenus.TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  convQxPrjMenus.ImgFile)
{
return mstrImgFile;
}
else if (strAttributeName  ==  convQxPrjMenus.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convQxPrjMenus.RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  convQxPrjMenus.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convQxPrjMenus.IsLeafNode)
{
return mbolIsLeafNode;
}
else if (strAttributeName  ==  convQxPrjMenus.MenuSetId)
{
return mstrMenuSetId;
}
else if (strAttributeName  ==  convQxPrjMenus.MenuSetName)
{
return mstrMenuSetName;
}
else if (strAttributeName  ==  convQxPrjMenus.MenuTitle)
{
return mstrMenuTitle;
}
else if (strAttributeName  ==  convQxPrjMenus.PageDispModeId)
{
return mstrPageDispModeId;
}
else if (strAttributeName  ==  convQxPrjMenus.PageDispModeName)
{
return mstrPageDispModeName;
}
else if (strAttributeName  ==  convQxPrjMenus.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convQxPrjMenus.MenuControlName)
{
return mstrMenuControlName;
}
else if (strAttributeName  ==  convQxPrjMenus.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  convQxPrjMenus.ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  convQxPrjMenus.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxPrjMenus.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convQxPrjMenus.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convQxPrjMenus.UpMenuName)
{
return mstrUpMenuName;
}
else if (strAttributeName  ==  convQxPrjMenus.SubMenusNum)
{
return mintSubMenusNum;
}
else if (strAttributeName  ==  convQxPrjMenus.RoleNum)
{
return mintRoleNum;
}
return null;
}
set
{
if (strAttributeName  ==  convQxPrjMenus.MenuId)
{
mstrMenuId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.MenuId);
}
else if (strAttributeName  ==  convQxPrjMenus.MenuName)
{
mstrMenuName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.MenuName);
}
else if (strAttributeName  ==  convQxPrjMenus.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.QxPrjId);
}
else if (strAttributeName  ==  convQxPrjMenus.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.PrjName);
}
else if (strAttributeName  ==  convQxPrjMenus.UpMenuId)
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.UpMenuId);
}
else if (strAttributeName  ==  convQxPrjMenus.LinkFile)
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(convQxPrjMenus.LinkFile);
}
else if (strAttributeName  ==  convQxPrjMenus.qsParameters)
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(convQxPrjMenus.qsParameters);
}
else if (strAttributeName  ==  convQxPrjMenus.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.TabId);
}
else if (strAttributeName  ==  convQxPrjMenus.TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.TabName);
}
else if (strAttributeName  ==  convQxPrjMenus.ImgFile)
{
mstrImgFile = value.ToString();
 AddUpdatedFld(convQxPrjMenus.ImgFile);
}
else if (strAttributeName  ==  convQxPrjMenus.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.RoleId);
}
else if (strAttributeName  ==  convQxPrjMenus.RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.RoleName);
}
else if (strAttributeName  ==  convQxPrjMenus.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjMenus.OrderNum);
}
else if (strAttributeName  ==  convQxPrjMenus.IsLeafNode)
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjMenus.IsLeafNode);
}
else if (strAttributeName  ==  convQxPrjMenus.MenuSetId)
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.MenuSetId);
}
else if (strAttributeName  ==  convQxPrjMenus.MenuSetName)
{
mstrMenuSetName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.MenuSetName);
}
else if (strAttributeName  ==  convQxPrjMenus.MenuTitle)
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(convQxPrjMenus.MenuTitle);
}
else if (strAttributeName  ==  convQxPrjMenus.PageDispModeId)
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.PageDispModeId);
}
else if (strAttributeName  ==  convQxPrjMenus.PageDispModeName)
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.PageDispModeName);
}
else if (strAttributeName  ==  convQxPrjMenus.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjMenus.InUse);
}
else if (strAttributeName  ==  convQxPrjMenus.MenuControlName)
{
mstrMenuControlName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.MenuControlName);
}
else if (strAttributeName  ==  convQxPrjMenus.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjMenus.ApplicationTypeId);
}
else if (strAttributeName  ==  convQxPrjMenus.ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.ApplicationTypeName);
}
else if (strAttributeName  ==  convQxPrjMenus.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxPrjMenus.UpdDate);
}
else if (strAttributeName  ==  convQxPrjMenus.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.UpdUserId);
}
else if (strAttributeName  ==  convQxPrjMenus.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPrjMenus.Memo);
}
else if (strAttributeName  ==  convQxPrjMenus.UpMenuName)
{
mstrUpMenuName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.UpMenuName);
}
else if (strAttributeName  ==  convQxPrjMenus.SubMenusNum)
{
mintSubMenusNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjMenus.SubMenusNum);
}
else if (strAttributeName  ==  convQxPrjMenus.RoleNum)
{
mintRoleNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjMenus.RoleNum);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxPrjMenus.MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (convQxPrjMenus.MenuName  ==  AttributeName[intIndex])
{
return mstrMenuName;
}
else if (convQxPrjMenus.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxPrjMenus.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxPrjMenus.UpMenuId  ==  AttributeName[intIndex])
{
return mstrUpMenuId;
}
else if (convQxPrjMenus.LinkFile  ==  AttributeName[intIndex])
{
return mstrLinkFile;
}
else if (convQxPrjMenus.qsParameters  ==  AttributeName[intIndex])
{
return mstrqsParameters;
}
else if (convQxPrjMenus.TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (convQxPrjMenus.TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (convQxPrjMenus.ImgFile  ==  AttributeName[intIndex])
{
return mstrImgFile;
}
else if (convQxPrjMenus.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convQxPrjMenus.RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (convQxPrjMenus.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convQxPrjMenus.IsLeafNode  ==  AttributeName[intIndex])
{
return mbolIsLeafNode;
}
else if (convQxPrjMenus.MenuSetId  ==  AttributeName[intIndex])
{
return mstrMenuSetId;
}
else if (convQxPrjMenus.MenuSetName  ==  AttributeName[intIndex])
{
return mstrMenuSetName;
}
else if (convQxPrjMenus.MenuTitle  ==  AttributeName[intIndex])
{
return mstrMenuTitle;
}
else if (convQxPrjMenus.PageDispModeId  ==  AttributeName[intIndex])
{
return mstrPageDispModeId;
}
else if (convQxPrjMenus.PageDispModeName  ==  AttributeName[intIndex])
{
return mstrPageDispModeName;
}
else if (convQxPrjMenus.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convQxPrjMenus.MenuControlName  ==  AttributeName[intIndex])
{
return mstrMenuControlName;
}
else if (convQxPrjMenus.ApplicationTypeId  ==  AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (convQxPrjMenus.ApplicationTypeName  ==  AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (convQxPrjMenus.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxPrjMenus.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convQxPrjMenus.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convQxPrjMenus.UpMenuName  ==  AttributeName[intIndex])
{
return mstrUpMenuName;
}
else if (convQxPrjMenus.SubMenusNum  ==  AttributeName[intIndex])
{
return mintSubMenusNum;
}
else if (convQxPrjMenus.RoleNum  ==  AttributeName[intIndex])
{
return mintRoleNum;
}
return null;
}
set
{
if (convQxPrjMenus.MenuId  ==  AttributeName[intIndex])
{
mstrMenuId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.MenuId);
}
else if (convQxPrjMenus.MenuName  ==  AttributeName[intIndex])
{
mstrMenuName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.MenuName);
}
else if (convQxPrjMenus.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.QxPrjId);
}
else if (convQxPrjMenus.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.PrjName);
}
else if (convQxPrjMenus.UpMenuId  ==  AttributeName[intIndex])
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.UpMenuId);
}
else if (convQxPrjMenus.LinkFile  ==  AttributeName[intIndex])
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(convQxPrjMenus.LinkFile);
}
else if (convQxPrjMenus.qsParameters  ==  AttributeName[intIndex])
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(convQxPrjMenus.qsParameters);
}
else if (convQxPrjMenus.TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.TabId);
}
else if (convQxPrjMenus.TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.TabName);
}
else if (convQxPrjMenus.ImgFile  ==  AttributeName[intIndex])
{
mstrImgFile = value.ToString();
 AddUpdatedFld(convQxPrjMenus.ImgFile);
}
else if (convQxPrjMenus.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.RoleId);
}
else if (convQxPrjMenus.RoleName  ==  AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.RoleName);
}
else if (convQxPrjMenus.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjMenus.OrderNum);
}
else if (convQxPrjMenus.IsLeafNode  ==  AttributeName[intIndex])
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjMenus.IsLeafNode);
}
else if (convQxPrjMenus.MenuSetId  ==  AttributeName[intIndex])
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.MenuSetId);
}
else if (convQxPrjMenus.MenuSetName  ==  AttributeName[intIndex])
{
mstrMenuSetName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.MenuSetName);
}
else if (convQxPrjMenus.MenuTitle  ==  AttributeName[intIndex])
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(convQxPrjMenus.MenuTitle);
}
else if (convQxPrjMenus.PageDispModeId  ==  AttributeName[intIndex])
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.PageDispModeId);
}
else if (convQxPrjMenus.PageDispModeName  ==  AttributeName[intIndex])
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.PageDispModeName);
}
else if (convQxPrjMenus.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjMenus.InUse);
}
else if (convQxPrjMenus.MenuControlName  ==  AttributeName[intIndex])
{
mstrMenuControlName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.MenuControlName);
}
else if (convQxPrjMenus.ApplicationTypeId  ==  AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjMenus.ApplicationTypeId);
}
else if (convQxPrjMenus.ApplicationTypeName  ==  AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.ApplicationTypeName);
}
else if (convQxPrjMenus.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxPrjMenus.UpdDate);
}
else if (convQxPrjMenus.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxPrjMenus.UpdUserId);
}
else if (convQxPrjMenus.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPrjMenus.Memo);
}
else if (convQxPrjMenus.UpMenuName  ==  AttributeName[intIndex])
{
mstrUpMenuName = value.ToString();
 AddUpdatedFld(convQxPrjMenus.UpMenuName);
}
else if (convQxPrjMenus.SubMenusNum  ==  AttributeName[intIndex])
{
mintSubMenusNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjMenus.SubMenusNum);
}
else if (convQxPrjMenus.RoleNum  ==  AttributeName[intIndex])
{
mintRoleNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjMenus.RoleNum);
}
}
}

/// <summary>
/// 菜单Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuId
{
get
{
return mstrMenuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuId = value;
}
else
{
 mstrMenuId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.MenuId);
}
}
/// <summary>
/// 菜单名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuName
{
get
{
return mstrMenuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuName = value;
}
else
{
 mstrMenuName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.MenuName);
}
}
/// <summary>
/// 项目Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QxPrjId
{
get
{
return mstrQxPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQxPrjId = value;
}
else
{
 mstrQxPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.QxPrjId);
}
}
/// <summary>
/// 工程名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.PrjName);
}
}
/// <summary>
/// 上级菜单Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpMenuId
{
get
{
return mstrUpMenuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpMenuId = value;
}
else
{
 mstrUpMenuId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.UpMenuId);
}
}
/// <summary>
/// 链接文件(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LinkFile
{
get
{
return mstrLinkFile;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLinkFile = value;
}
else
{
 mstrLinkFile = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.LinkFile);
}
}
/// <summary>
/// qs参数(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string qsParameters
{
get
{
return mstrqsParameters;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrqsParameters = value;
}
else
{
 mstrqsParameters = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.qsParameters);
}
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.TabId);
}
}
/// <summary>
/// TabName(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.TabName);
}
}
/// <summary>
/// 图像文件(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImgFile
{
get
{
return mstrImgFile;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImgFile = value;
}
else
{
 mstrImgFile = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.ImgFile);
}
}
/// <summary>
/// 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleId = value;
}
else
{
 mstrRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.RoleId);
}
}
/// <summary>
/// 角色名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleName
{
get
{
return mstrRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleName = value;
}
else
{
 mstrRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.RoleName);
}
}
/// <summary>
/// 排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.OrderNum);
}
}
/// <summary>
/// 是否叶子(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsLeafNode
{
get
{
return mbolIsLeafNode;
}
set
{
 mbolIsLeafNode = value;
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.IsLeafNode);
}
}
/// <summary>
/// 菜单集Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuSetId
{
get
{
return mstrMenuSetId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuSetId = value;
}
else
{
 mstrMenuSetId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.MenuSetId);
}
}
/// <summary>
/// 菜单集名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuSetName
{
get
{
return mstrMenuSetName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuSetName = value;
}
else
{
 mstrMenuSetName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.MenuSetName);
}
}
/// <summary>
/// 菜单标题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuTitle
{
get
{
return mstrMenuTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuTitle = value;
}
else
{
 mstrMenuTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.MenuTitle);
}
}
/// <summary>
/// 页面显示模式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageDispModeId
{
get
{
return mstrPageDispModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageDispModeId = value;
}
else
{
 mstrPageDispModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.PageDispModeId);
}
}
/// <summary>
/// 页面显示模式名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageDispModeName
{
get
{
return mstrPageDispModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageDispModeName = value;
}
else
{
 mstrPageDispModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.PageDispModeName);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.InUse);
}
}
/// <summary>
/// MenuControlName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuControlName
{
get
{
return mstrMenuControlName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuControlName = value;
}
else
{
 mstrMenuControlName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.MenuControlName);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.ApplicationTypeId);
}
}
/// <summary>
/// 应用程序类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ApplicationTypeName
{
get
{
return mstrApplicationTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrApplicationTypeName = value;
}
else
{
 mstrApplicationTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.ApplicationTypeName);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.UpdUserId);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.Memo);
}
}
/// <summary>
/// 上级菜单名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpMenuName
{
get
{
return mstrUpMenuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpMenuName = value;
}
else
{
 mstrUpMenuName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.UpMenuName);
}
}
/// <summary>
/// 子菜单数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? SubMenusNum
{
get
{
return mintSubMenusNum;
}
set
{
 mintSubMenusNum = value;
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.SubMenusNum);
}
}
/// <summary>
/// 角色数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? RoleNum
{
get
{
return mintRoleNum;
}
set
{
 mintRoleNum = value;
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus.RoleNum);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrMenuId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrMenuName;
 }
 }
}
 /// <summary>
 /// v工程菜单(vQxPrjMenus)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxPrjMenus
{
public const string _CurrTabName = "vQxPrjMenus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MenuId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MenuId", "MenuName", "QxPrjId", "PrjName", "UpMenuId", "LinkFile", "qsParameters", "TabId", "TabName", "ImgFile", "RoleId", "RoleName", "OrderNum", "IsLeafNode", "MenuSetId", "MenuSetName", "MenuTitle", "PageDispModeId", "PageDispModeName", "InUse", "MenuControlName", "ApplicationTypeId", "ApplicationTypeName", "UpdDate", "UpdUserId", "Memo", "UpMenuName", "SubMenusNum", "RoleNum"};
//以下是属性变量


 /// <summary>
 /// 常量:"MenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuId = "MenuId";    //菜单Id

 /// <summary>
 /// 常量:"MenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuName = "MenuName";    //菜单名

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名

 /// <summary>
 /// 常量:"UpMenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpMenuId = "UpMenuId";    //上级菜单Id

 /// <summary>
 /// 常量:"LinkFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LinkFile = "LinkFile";    //链接文件

 /// <summary>
 /// 常量:"qsParameters"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string qsParameters = "qsParameters";    //qs参数

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabName = "TabName";    //TabName

 /// <summary>
 /// 常量:"ImgFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImgFile = "ImgFile";    //图像文件

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"RoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleName = "RoleName";    //角色名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"IsLeafNode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsLeafNode = "IsLeafNode";    //是否叶子

 /// <summary>
 /// 常量:"MenuSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuSetId = "MenuSetId";    //菜单集Id

 /// <summary>
 /// 常量:"MenuSetName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuSetName = "MenuSetName";    //菜单集名称

 /// <summary>
 /// 常量:"MenuTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuTitle = "MenuTitle";    //菜单标题

 /// <summary>
 /// 常量:"PageDispModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageDispModeId = "PageDispModeId";    //页面显示模式Id

 /// <summary>
 /// 常量:"PageDispModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageDispModeName = "PageDispModeName";    //页面显示模式名称

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"MenuControlName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuControlName = "MenuControlName";    //MenuControlName

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"UpMenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpMenuName = "UpMenuName";    //上级菜单名

 /// <summary>
 /// 常量:"SubMenusNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string SubMenusNum = "SubMenusNum";    //子菜单数

 /// <summary>
 /// 常量:"RoleNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleNum = "RoleNum";    //角色数
}

}