
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserMenuDetailEN
 表名:QxUserMenuDetail(00140011)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 09:59:47
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
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
 /// 表QxUserMenuDetail的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_mId_QxUserMenuDetail
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_QxUserMenuDetail(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_QxUserMenuDetail]类型的对象</returns>
public static implicit operator K_mId_QxUserMenuDetail(long value)
{
return new K_mId_QxUserMenuDetail(value);
}
}
 /// <summary>
 /// 用户菜单(QxUserMenuDetail)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUserMenuDetailEN : clsEntityBase2
{
public const string _CurrTabName_S = "QxUserMenuDetail"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"mId", "MenuId", "MenuName", "IsDisp", "UpMenuId", "LinkFile", "ImgFile", "IsCustomMenu", "UserId", "QxPrjId", "OrderNum", "Memo"};
//以下是属性变量

protected long mlngmId;    //流水号
protected string mstrMenuId;    //菜单Id
protected string mstrMenuName;    //菜单名
protected bool mbolIsDisp;    //是否显示
protected string mstrUpMenuId;    //上级菜单Id
protected string mstrLinkFile;    //链接文件
protected string mstrImgFile;    //图像文件
protected bool mbolIsCustomMenu;    //是否定制菜单
protected string mstrUserId;    //用户ID
protected string mstrQxPrjId;    //项目Id
protected int mintOrderNum;    //排序号
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId = "mId";    //流水号

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
 /// 常量:"IsDisp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsDisp = "IsDisp";    //是否显示

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
 /// 常量:"ImgFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ImgFile = "ImgFile";    //图像文件

 /// <summary>
 /// 常量:"IsCustomMenu"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsCustomMenu = "IsCustomMenu";    //是否定制菜单

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserMenuDetailEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxUserMenuDetail";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:流水号</param>
public clsQxUserMenuDetailEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "QxUserMenuDetail";
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  con_mId)
{
return mlngmId;
}
else if (strAttributeName  ==  con_MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  con_MenuName)
{
return mstrMenuName;
}
else if (strAttributeName  ==  con_IsDisp)
{
return mbolIsDisp;
}
else if (strAttributeName  ==  con_UpMenuId)
{
return mstrUpMenuId;
}
else if (strAttributeName  ==  con_LinkFile)
{
return mstrLinkFile;
}
else if (strAttributeName  ==  con_ImgFile)
{
return mstrImgFile;
}
else if (strAttributeName  ==  con_IsCustomMenu)
{
return mbolIsCustomMenu;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  con_OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (strAttributeName  ==  con_MenuId)
{
mstrMenuId = value.ToString();
 AddUpdatedFld(con_MenuId);
}
else if (strAttributeName  ==  con_MenuName)
{
mstrMenuName = value.ToString();
 AddUpdatedFld(con_MenuName);
}
else if (strAttributeName  ==  con_IsDisp)
{
mbolIsDisp = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDisp);
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
else if (strAttributeName  ==  con_ImgFile)
{
mstrImgFile = value.ToString();
 AddUpdatedFld(con_ImgFile);
}
else if (strAttributeName  ==  con_IsCustomMenu)
{
mbolIsCustomMenu = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsCustomMenu);
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName  ==  con_QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(con_QxPrjId);
}
else if (strAttributeName  ==  con_OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (con_mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (con_MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (con_MenuName  ==  AttributeName[intIndex])
{
return mstrMenuName;
}
else if (con_IsDisp  ==  AttributeName[intIndex])
{
return mbolIsDisp;
}
else if (con_UpMenuId  ==  AttributeName[intIndex])
{
return mstrUpMenuId;
}
else if (con_LinkFile  ==  AttributeName[intIndex])
{
return mstrLinkFile;
}
else if (con_ImgFile  ==  AttributeName[intIndex])
{
return mstrImgFile;
}
else if (con_IsCustomMenu  ==  AttributeName[intIndex])
{
return mbolIsCustomMenu;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (con_MenuId  ==  AttributeName[intIndex])
{
mstrMenuId = value.ToString();
 AddUpdatedFld(con_MenuId);
}
else if (con_MenuName  ==  AttributeName[intIndex])
{
mstrMenuName = value.ToString();
 AddUpdatedFld(con_MenuName);
}
else if (con_IsDisp  ==  AttributeName[intIndex])
{
mbolIsDisp = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDisp);
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
else if (con_ImgFile  ==  AttributeName[intIndex])
{
mstrImgFile = value.ToString();
 AddUpdatedFld(con_ImgFile);
}
else if (con_IsCustomMenu  ==  AttributeName[intIndex])
{
mbolIsCustomMenu = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsCustomMenu);
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(con_QxPrjId);
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(con_mId);
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
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDisp
{
get
{
return mbolIsDisp;
}
set
{
 mbolIsDisp = value;
//记录修改过的字段
 AddUpdatedFld(con_IsDisp);
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
/// 是否定制菜单(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsCustomMenu
{
get
{
return mbolIsCustomMenu;
}
set
{
 mbolIsCustomMenu = value;
//记录修改过的字段
 AddUpdatedFld(con_IsCustomMenu);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserId);
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
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mlngmId.ToString();
 }
 }
}
}