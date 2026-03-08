
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenusEN
 表名:vQxPrjMenus(00140046)
 生成代码版本:2019.08.02.1
 生成日期:2019/08/05 11:01:47
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433GeneralPlatformTz
 PrjDataBaseId:0184
 模块中文名:菜单管理
 模块英文名:MenuManage
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
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
public struct K_MenuId_vQxPrjMenus
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
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
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
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
public const string _CurrTabName_S = "vQxPrjMenus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MenuId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 29;
public static string[] AttributeName = new string[] {"MenuId", "MenuName", "QxPrjId", "PrjName", "UpMenuId", "LinkFile", "qsParameters", "TabId", "TabName", "ImgFile", "RoleId", "RoleName", "OrderNum", "IsLeafNode", "MenuSetId", "MenuSetName", "MenuTitle", "PageDispModeId", "PageDispModeName", "InUse", "MenuControlName", "ApplicationTypeId", "ApplicationTypeName", "UpdDate", "UpdUserId", "Memo", "UpMenuName", "SubMenusNum", "RoleNum"};
//以下是属性变量

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
protected int mintOrderNum;    //排序号
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
protected int mintSubMenusNum;    //子菜单数
protected int mintRoleNum;    //角色数


 /// <summary>
 /// 常量:"MenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuId = "MenuId";    //菜单Id

 /// <summary>
 /// 常量:"MenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuName = "MenuName";    //菜单名

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PrjName = "PrjName";    //工程名

 /// <summary>
 /// 常量:"UpMenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpMenuId = "UpMenuId";    //上级菜单Id

 /// <summary>
 /// 常量:"LinkFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_LinkFile = "LinkFile";    //链接文件

 /// <summary>
 /// 常量:"qsParameters"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_qsParameters = "qsParameters";    //qs参数

 /// <summary>
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabName = "TabName";    //TabName

 /// <summary>
 /// 常量:"ImgFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ImgFile = "ImgFile";    //图像文件

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"RoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RoleName = "RoleName";    //角色名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"IsLeafNode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsLeafNode = "IsLeafNode";    //是否叶子

 /// <summary>
 /// 常量:"MenuSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuSetId = "MenuSetId";    //菜单集Id

 /// <summary>
 /// 常量:"MenuSetName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuSetName = "MenuSetName";    //菜单集名称

 /// <summary>
 /// 常量:"MenuTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuTitle = "MenuTitle";    //菜单标题

 /// <summary>
 /// 常量:"PageDispModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PageDispModeId = "PageDispModeId";    //页面显示模式Id

 /// <summary>
 /// 常量:"PageDispModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PageDispModeName = "PageDispModeName";    //页面显示模式名称

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"MenuControlName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_MenuControlName = "MenuControlName";    //MenuControlName

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

 /// <summary>
 /// 常量:"ApplicationTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ApplicationTypeName = "ApplicationTypeName";    //应用程序类型名称

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"UpMenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpMenuName = "UpMenuName";    //上级菜单名

 /// <summary>
 /// 常量:"SubMenusNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SubMenusNum = "SubMenusNum";    //子菜单数

 /// <summary>
 /// 常量:"RoleNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_RoleNum = "RoleNum";    //角色数

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxPrjMenusEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "vQxPrjMenus";
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
 _CurrTabName = "vQxPrjMenus";
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
if (strAttributeName  ==  con_MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  con_MenuName)
{
return mstrMenuName;
}
else if (strAttributeName  ==  con_QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  con_PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  con_UpMenuId)
{
return mstrUpMenuId;
}
else if (strAttributeName  ==  con_LinkFile)
{
return mstrLinkFile;
}
else if (strAttributeName  ==  con_qsParameters)
{
return mstrqsParameters;
}
else if (strAttributeName  ==  con_TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  con_TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  con_ImgFile)
{
return mstrImgFile;
}
else if (strAttributeName  ==  con_RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  con_RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  con_OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  con_IsLeafNode)
{
return mbolIsLeafNode;
}
else if (strAttributeName  ==  con_MenuSetId)
{
return mstrMenuSetId;
}
else if (strAttributeName  ==  con_MenuSetName)
{
return mstrMenuSetName;
}
else if (strAttributeName  ==  con_MenuTitle)
{
return mstrMenuTitle;
}
else if (strAttributeName  ==  con_PageDispModeId)
{
return mstrPageDispModeId;
}
else if (strAttributeName  ==  con_PageDispModeName)
{
return mstrPageDispModeName;
}
else if (strAttributeName  ==  con_InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  con_MenuControlName)
{
return mstrMenuControlName;
}
else if (strAttributeName  ==  con_ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  con_ApplicationTypeName)
{
return mstrApplicationTypeName;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  con_UpMenuName)
{
return mstrUpMenuName;
}
else if (strAttributeName  ==  con_SubMenusNum)
{
return mintSubMenusNum;
}
else if (strAttributeName  ==  con_RoleNum)
{
return mintRoleNum;
}
return null;
}
set
{
if (strAttributeName  ==  con_MenuId)
{
mstrMenuId = value.ToString();
 AddUpdatedFld(con_MenuId);
}
else if (strAttributeName  ==  con_MenuName)
{
mstrMenuName = value.ToString();
 AddUpdatedFld(con_MenuName);
}
else if (strAttributeName  ==  con_QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(con_QxPrjId);
}
else if (strAttributeName  ==  con_PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(con_PrjName);
}
else if (strAttributeName  ==  con_UpMenuId)
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(con_UpMenuId);
}
else if (strAttributeName  ==  con_LinkFile)
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(con_LinkFile);
}
else if (strAttributeName  ==  con_qsParameters)
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(con_qsParameters);
}
else if (strAttributeName  ==  con_TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(con_TabId);
}
else if (strAttributeName  ==  con_TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(con_TabName);
}
else if (strAttributeName  ==  con_ImgFile)
{
mstrImgFile = value.ToString();
 AddUpdatedFld(con_ImgFile);
}
else if (strAttributeName  ==  con_RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(con_RoleId);
}
else if (strAttributeName  ==  con_RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(con_RoleName);
}
else if (strAttributeName  ==  con_OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (strAttributeName  ==  con_IsLeafNode)
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsLeafNode);
}
else if (strAttributeName  ==  con_MenuSetId)
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(con_MenuSetId);
}
else if (strAttributeName  ==  con_MenuSetName)
{
mstrMenuSetName = value.ToString();
 AddUpdatedFld(con_MenuSetName);
}
else if (strAttributeName  ==  con_MenuTitle)
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(con_MenuTitle);
}
else if (strAttributeName  ==  con_PageDispModeId)
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(con_PageDispModeId);
}
else if (strAttributeName  ==  con_PageDispModeName)
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(con_PageDispModeName);
}
else if (strAttributeName  ==  con_InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(con_InUse);
}
else if (strAttributeName  ==  con_MenuControlName)
{
mstrMenuControlName = value.ToString();
 AddUpdatedFld(con_MenuControlName);
}
else if (strAttributeName  ==  con_ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ApplicationTypeId);
}
else if (strAttributeName  ==  con_ApplicationTypeName)
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(con_ApplicationTypeName);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (strAttributeName  ==  con_UpMenuName)
{
mstrUpMenuName = value.ToString();
 AddUpdatedFld(con_UpMenuName);
}
else if (strAttributeName  ==  con_SubMenusNum)
{
mintSubMenusNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_SubMenusNum);
}
else if (strAttributeName  ==  con_RoleNum)
{
mintRoleNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_RoleNum);
}
}
}
public object this[int intIndex]
{
get
{
if (con_MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (con_MenuName  ==  AttributeName[intIndex])
{
return mstrMenuName;
}
else if (con_QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (con_PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (con_UpMenuId  ==  AttributeName[intIndex])
{
return mstrUpMenuId;
}
else if (con_LinkFile  ==  AttributeName[intIndex])
{
return mstrLinkFile;
}
else if (con_qsParameters  ==  AttributeName[intIndex])
{
return mstrqsParameters;
}
else if (con_TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (con_TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (con_ImgFile  ==  AttributeName[intIndex])
{
return mstrImgFile;
}
else if (con_RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (con_RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (con_IsLeafNode  ==  AttributeName[intIndex])
{
return mbolIsLeafNode;
}
else if (con_MenuSetId  ==  AttributeName[intIndex])
{
return mstrMenuSetId;
}
else if (con_MenuSetName  ==  AttributeName[intIndex])
{
return mstrMenuSetName;
}
else if (con_MenuTitle  ==  AttributeName[intIndex])
{
return mstrMenuTitle;
}
else if (con_PageDispModeId  ==  AttributeName[intIndex])
{
return mstrPageDispModeId;
}
else if (con_PageDispModeName  ==  AttributeName[intIndex])
{
return mstrPageDispModeName;
}
else if (con_InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (con_MenuControlName  ==  AttributeName[intIndex])
{
return mstrMenuControlName;
}
else if (con_ApplicationTypeId  ==  AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (con_ApplicationTypeName  ==  AttributeName[intIndex])
{
return mstrApplicationTypeName;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (con_UpMenuName  ==  AttributeName[intIndex])
{
return mstrUpMenuName;
}
else if (con_SubMenusNum  ==  AttributeName[intIndex])
{
return mintSubMenusNum;
}
else if (con_RoleNum  ==  AttributeName[intIndex])
{
return mintRoleNum;
}
return null;
}
set
{
if (con_MenuId  ==  AttributeName[intIndex])
{
mstrMenuId = value.ToString();
 AddUpdatedFld(con_MenuId);
}
else if (con_MenuName  ==  AttributeName[intIndex])
{
mstrMenuName = value.ToString();
 AddUpdatedFld(con_MenuName);
}
else if (con_QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(con_QxPrjId);
}
else if (con_PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(con_PrjName);
}
else if (con_UpMenuId  ==  AttributeName[intIndex])
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(con_UpMenuId);
}
else if (con_LinkFile  ==  AttributeName[intIndex])
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(con_LinkFile);
}
else if (con_qsParameters  ==  AttributeName[intIndex])
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(con_qsParameters);
}
else if (con_TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(con_TabId);
}
else if (con_TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(con_TabName);
}
else if (con_ImgFile  ==  AttributeName[intIndex])
{
mstrImgFile = value.ToString();
 AddUpdatedFld(con_ImgFile);
}
else if (con_RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(con_RoleId);
}
else if (con_RoleName  ==  AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(con_RoleName);
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (con_IsLeafNode  ==  AttributeName[intIndex])
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsLeafNode);
}
else if (con_MenuSetId  ==  AttributeName[intIndex])
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(con_MenuSetId);
}
else if (con_MenuSetName  ==  AttributeName[intIndex])
{
mstrMenuSetName = value.ToString();
 AddUpdatedFld(con_MenuSetName);
}
else if (con_MenuTitle  ==  AttributeName[intIndex])
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(con_MenuTitle);
}
else if (con_PageDispModeId  ==  AttributeName[intIndex])
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(con_PageDispModeId);
}
else if (con_PageDispModeName  ==  AttributeName[intIndex])
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(con_PageDispModeName);
}
else if (con_InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(con_InUse);
}
else if (con_MenuControlName  ==  AttributeName[intIndex])
{
mstrMenuControlName = value.ToString();
 AddUpdatedFld(con_MenuControlName);
}
else if (con_ApplicationTypeId  ==  AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ApplicationTypeId);
}
else if (con_ApplicationTypeName  ==  AttributeName[intIndex])
{
mstrApplicationTypeName = value.ToString();
 AddUpdatedFld(con_ApplicationTypeName);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
else if (con_UpMenuName  ==  AttributeName[intIndex])
{
mstrUpMenuName = value.ToString();
 AddUpdatedFld(con_UpMenuName);
}
else if (con_SubMenusNum  ==  AttributeName[intIndex])
{
mintSubMenusNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_SubMenusNum);
}
else if (con_RoleNum  ==  AttributeName[intIndex])
{
mintRoleNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_RoleNum);
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
 AddUpdatedFld(con_MenuId);
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
 AddUpdatedFld(con_MenuName);
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
 AddUpdatedFld(con_QxPrjId);
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
 AddUpdatedFld(con_PrjName);
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
 AddUpdatedFld(con_UpMenuId);
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
 AddUpdatedFld(con_LinkFile);
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
 AddUpdatedFld(con_qsParameters);
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
 AddUpdatedFld(con_TabId);
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
 AddUpdatedFld(con_TabName);
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
 AddUpdatedFld(con_ImgFile);
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
 AddUpdatedFld(con_RoleId);
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
 AddUpdatedFld(con_RoleName);
}
}
/// <summary>
/// 排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(con_OrderNum);
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
 AddUpdatedFld(con_IsLeafNode);
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
 AddUpdatedFld(con_MenuSetId);
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
 AddUpdatedFld(con_MenuSetName);
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
 AddUpdatedFld(con_MenuTitle);
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
 AddUpdatedFld(con_PageDispModeId);
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
 AddUpdatedFld(con_PageDispModeName);
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
 AddUpdatedFld(con_InUse);
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
 AddUpdatedFld(con_MenuControlName);
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
 AddUpdatedFld(con_ApplicationTypeId);
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
 AddUpdatedFld(con_ApplicationTypeName);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
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
 AddUpdatedFld(con_UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
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
 AddUpdatedFld(con_UpdUserId);
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
 AddUpdatedFld(con_Memo);
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
 AddUpdatedFld(con_UpMenuName);
}
}
/// <summary>
/// 子菜单数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int SubMenusNum
{
get
{
return mintSubMenusNum;
}
set
{
 mintSubMenusNum = value;
//记录修改过的字段
 AddUpdatedFld(con_SubMenusNum);
}
}
/// <summary>
/// 角色数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int RoleNum
{
get
{
return mintRoleNum;
}
set
{
 mintRoleNum = value;
//记录修改过的字段
 AddUpdatedFld(con_RoleNum);
}
}

/// <summary>
/// 获取关键字Id(KeyId)
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
}