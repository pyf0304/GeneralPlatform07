
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserMenuDetailEN
 表名:QxUserMenuDetail(00140011)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:22:05
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
 /// 表QxUserMenuDetail的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_QxUserMenuDetail
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
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
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
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
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUserMenuDetail"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 12;
public static string[] AttributeName = new string[] {"mId", "MenuId", "MenuName", "IsDisp", "UpMenuId", "LinkFile", "ImgFile", "IsCustomMenu", "UserId", "QxPrjId", "OrderNum", "Memo"};

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
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUserMenuDetailEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
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
if (strAttributeName  ==  conQxUserMenuDetail.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  conQxUserMenuDetail.MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  conQxUserMenuDetail.MenuName)
{
return mstrMenuName;
}
else if (strAttributeName  ==  conQxUserMenuDetail.IsDisp)
{
return mbolIsDisp;
}
else if (strAttributeName  ==  conQxUserMenuDetail.UpMenuId)
{
return mstrUpMenuId;
}
else if (strAttributeName  ==  conQxUserMenuDetail.LinkFile)
{
return mstrLinkFile;
}
else if (strAttributeName  ==  conQxUserMenuDetail.ImgFile)
{
return mstrImgFile;
}
else if (strAttributeName  ==  conQxUserMenuDetail.IsCustomMenu)
{
return mbolIsCustomMenu;
}
else if (strAttributeName  ==  conQxUserMenuDetail.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conQxUserMenuDetail.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxUserMenuDetail.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conQxUserMenuDetail.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUserMenuDetail.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserMenuDetail.mId);
}
else if (strAttributeName  ==  conQxUserMenuDetail.MenuId)
{
mstrMenuId = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.MenuId);
}
else if (strAttributeName  ==  conQxUserMenuDetail.MenuName)
{
mstrMenuName = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.MenuName);
}
else if (strAttributeName  ==  conQxUserMenuDetail.IsDisp)
{
mbolIsDisp = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserMenuDetail.IsDisp);
}
else if (strAttributeName  ==  conQxUserMenuDetail.UpMenuId)
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.UpMenuId);
}
else if (strAttributeName  ==  conQxUserMenuDetail.LinkFile)
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.LinkFile);
}
else if (strAttributeName  ==  conQxUserMenuDetail.ImgFile)
{
mstrImgFile = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.ImgFile);
}
else if (strAttributeName  ==  conQxUserMenuDetail.IsCustomMenu)
{
mbolIsCustomMenu = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserMenuDetail.IsCustomMenu);
}
else if (strAttributeName  ==  conQxUserMenuDetail.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.UserId);
}
else if (strAttributeName  ==  conQxUserMenuDetail.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.QxPrjId);
}
else if (strAttributeName  ==  conQxUserMenuDetail.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserMenuDetail.OrderNum);
}
else if (strAttributeName  ==  conQxUserMenuDetail.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUserMenuDetail.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (conQxUserMenuDetail.MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (conQxUserMenuDetail.MenuName  ==  AttributeName[intIndex])
{
return mstrMenuName;
}
else if (conQxUserMenuDetail.IsDisp  ==  AttributeName[intIndex])
{
return mbolIsDisp;
}
else if (conQxUserMenuDetail.UpMenuId  ==  AttributeName[intIndex])
{
return mstrUpMenuId;
}
else if (conQxUserMenuDetail.LinkFile  ==  AttributeName[intIndex])
{
return mstrLinkFile;
}
else if (conQxUserMenuDetail.ImgFile  ==  AttributeName[intIndex])
{
return mstrImgFile;
}
else if (conQxUserMenuDetail.IsCustomMenu  ==  AttributeName[intIndex])
{
return mbolIsCustomMenu;
}
else if (conQxUserMenuDetail.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conQxUserMenuDetail.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxUserMenuDetail.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conQxUserMenuDetail.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxUserMenuDetail.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserMenuDetail.mId);
}
else if (conQxUserMenuDetail.MenuId  ==  AttributeName[intIndex])
{
mstrMenuId = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.MenuId);
}
else if (conQxUserMenuDetail.MenuName  ==  AttributeName[intIndex])
{
mstrMenuName = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.MenuName);
}
else if (conQxUserMenuDetail.IsDisp  ==  AttributeName[intIndex])
{
mbolIsDisp = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserMenuDetail.IsDisp);
}
else if (conQxUserMenuDetail.UpMenuId  ==  AttributeName[intIndex])
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.UpMenuId);
}
else if (conQxUserMenuDetail.LinkFile  ==  AttributeName[intIndex])
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.LinkFile);
}
else if (conQxUserMenuDetail.ImgFile  ==  AttributeName[intIndex])
{
mstrImgFile = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.ImgFile);
}
else if (conQxUserMenuDetail.IsCustomMenu  ==  AttributeName[intIndex])
{
mbolIsCustomMenu = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUserMenuDetail.IsCustomMenu);
}
else if (conQxUserMenuDetail.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.UserId);
}
else if (conQxUserMenuDetail.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.QxPrjId);
}
else if (conQxUserMenuDetail.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUserMenuDetail.OrderNum);
}
else if (conQxUserMenuDetail.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxUserMenuDetail.Memo);
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
 AddUpdatedFld(conQxUserMenuDetail.mId);
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
 AddUpdatedFld(conQxUserMenuDetail.MenuId);
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
 AddUpdatedFld(conQxUserMenuDetail.MenuName);
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
 AddUpdatedFld(conQxUserMenuDetail.IsDisp);
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
 AddUpdatedFld(conQxUserMenuDetail.UpMenuId);
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
 AddUpdatedFld(conQxUserMenuDetail.LinkFile);
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
 AddUpdatedFld(conQxUserMenuDetail.ImgFile);
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
 AddUpdatedFld(conQxUserMenuDetail.IsCustomMenu);
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
 AddUpdatedFld(conQxUserMenuDetail.UserId);
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
 AddUpdatedFld(conQxUserMenuDetail.QxPrjId);
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
 AddUpdatedFld(conQxUserMenuDetail.OrderNum);
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
 AddUpdatedFld(conQxUserMenuDetail.Memo);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// 用户菜单(QxUserMenuDetail)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUserMenuDetail
{
public const string _CurrTabName = "QxUserMenuDetail"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "MenuId", "MenuName", "IsDisp", "UpMenuId", "LinkFile", "ImgFile", "IsCustomMenu", "UserId", "QxPrjId", "OrderNum", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //流水号

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
 /// 常量:"IsDisp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDisp = "IsDisp";    //是否显示

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
 /// 常量:"ImgFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImgFile = "ImgFile";    //图像文件

 /// <summary>
 /// 常量:"IsCustomMenu"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsCustomMenu = "IsCustomMenu";    //是否定制菜单

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注
}

}