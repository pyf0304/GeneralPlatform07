using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;
using ResManage;

/// <summary>
///clsUserManage 的摘要说明
/// </summary>
public class clsUserManage
{
    public clsUserManage()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }
    /// <summary>
    /// 获取用户对象的层次结构
    /// </summary>
    /// <returns></returns>
    public static GeneralPlatform.Entity.clsUsersEx GetUserEx()
    {
        GeneralPlatform.Entity.clsUsersEx objUsersEx = new clsCommonSession().objUsersEx;
        return objUsersEx;
    }
    /// <summary>
    /// 是否包含某权限名称
    /// </summary>
    /// <param name="strPotenceName">给定的权限名称</param>
    /// <returns>是否包含？</returns>
    public static bool IsHavePotenceName(string strPotenceName)
    {
        GeneralPlatform.Entity.clsUsersEx objUsersEx = new clsCommonSession().objUsersEx;
        foreach(clsPrjPotence objPrjPotence in objUsersEx.arrPrjPotenceObjLst)
        {
            if (objPrjPotence.PotenceName == strPotenceName)
            {
                return true;
            }
        }
        
        return false;
    }
    /// <summary>
    /// 是否包含某权限Id
    /// </summary>
    /// <param name="strPotenceName">给定的权限名称</param>
    /// <returns>是否包含？</returns>
    public static bool IsHavePotenceId(string strPotenceId)
    {
        GeneralPlatform.Entity.clsUsersEx objUsersEx = new clsCommonSession().objUsersEx;
        foreach (clsPrjPotence objPrjPotence in objUsersEx.arrPrjPotenceObjLst)
        {
            if (objPrjPotence.PotenceId == strPotenceId)
            {
                return true;
            }
        }
        return false;
    }
    /// <summary>
    /// 是否包含某权限名称
    /// </summary>
    /// <param name="strPotenceName">给定的权限名称</param>
    /// <returns>是否包含？</returns>
    public static clsPrjPotence GetPrjPotenceObjByPotenceName(string strPotenceName)
    {
        GeneralPlatform.Entity.clsUsersEx objUsersEx = new clsCommonSession().objUsersEx;
        if (objUsersEx == null)
        {
            return null;
        }
        foreach (clsPrjPotence objPrjPotence in objUsersEx.arrPrjPotenceObjLst)
        {
            if (objPrjPotence.PotenceName == strPotenceName)
            {
                return objPrjPotence;
            }
        }
        return null;
    }

    /// <summary>
    /// 是否包含某权限名称
    /// </summary>
    /// <param name="strPotenceName">给定的权限名称</param>
    /// <returns>是否包含？</returns>
    public static clsPrjPotence GetPrjPotenceObjByPotenceName4CurrRole(string strPotenceName)
    {
        GeneralPlatform.Entity.clsUsersEx objUsersEx = new clsCommonSession().objUsersEx;
        foreach (clsPrjPotence objPrjPotence in objUsersEx.arrPrjPotenceObjLst4CurrRole)
        {
            if (objPrjPotence.PotenceName == strPotenceName)
            {
                return objPrjPotence;
            }
        }
        return null;
    }
    /// <summary>
    /// 是否包含某权限名称
    /// </summary>
    /// <param name="strPotenceName">给定的权限名称</param>
    /// <returns>是否包含？</returns>
    public static bool IsHavePotenceNameAndSymbol(string strPotenceName, string strSymbolName)
    {
        GeneralPlatform.Entity.clsUsersEx objUsersEx = new clsCommonSession().objUsersEx;
        clsPrjPotence objPrjPotence = GetPrjPotenceObjByPotenceName(strPotenceName);
        if (objPrjPotence == null)
        {
            return false;
        }
        foreach (clsRelaOfPotenceAndSymbol objRelaOfPotenceAndSymbol in objUsersEx.arrPrjPotenceAndSymbolObjLst)
        {
            if (objRelaOfPotenceAndSymbol.SymbolName == strSymbolName && objRelaOfPotenceAndSymbol.PotenceId == objPrjPotence.PotenceId)
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// 是否包含某权限名称
    /// </summary>
    /// <param name="strPotenceName">给定的权限名称</param>
    /// <returns>是否包含？</returns>
    public static bool IsHavePotenceNameAndSymbol4CurrRole1(string strPotenceName, string strSymbolName)
    {
        GeneralPlatform.Entity.clsUsersEx objUsersEx = new clsCommonSession().objUsersEx;
        clsPrjPotence objPrjPotence = GetPrjPotenceObjByPotenceName4CurrRole(strPotenceName);
        if (objPrjPotence == null)
        {
            return false;
        }
        foreach (clsRelaOfPotenceAndSymbol objRelaOfPotenceAndSymbol in objUsersEx.arrPrjPotenceAndSymbolObjLst4CurrRole)
        {
            if (objRelaOfPotenceAndSymbol.SymbolName == strSymbolName && objRelaOfPotenceAndSymbol.PotenceId == objPrjPotence.PotenceId)
            {
                return true;
            }
        }
        return false;
    }
}
