using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using com.taishsoft.common;

namespace GeneralPlatform.Entity
{
    /// <summary>
    /// 根据记录序号范围获取对象列表的参数对象-Static
    /// </summary>
    public static class stuRoleMenuByRoleIdsPara_Static
    {
        /// <summary>
        /// 根据记录范围获取记录的参数对象获取相关的字典参数
        /// </summary>
        /// <param name="objRoleMenuByRoleIdsPara">根据范围获取记录的参数对象</param>
        /// <returns>获取的相关字典参数</returns>
        public static Dictionary<string, string> GetDictParam(this stuRoleMenuByRoleIdsPara objRoleMenuByRoleIdsPara)
        {
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["RoleIdLst"] = clsArray.GetSqlInStrByArray(objRoleMenuByRoleIdsPara.RoleIdLst,false),
                ["strMenuSetId"] = objRoleMenuByRoleIdsPara.MenuSetId,
                ["strQxPrjId"] = objRoleMenuByRoleIdsPara.QxPrjId,
                ["strIsUpMenuId"] = objRoleMenuByRoleIdsPara.IsUpMenuId
            };
            return dictParam;
        }
    }
    /// <summary>
    /// 根据记录序号范围获取对象列表的参数对象
    /// </summary>
    [Serializable]
    [DataContractAttribute]
    public class stuRoleMenuByRoleIdsPara
    {     

     
        /// <summary>
        /// 当前选择的工程Id
        /// </summary>
        [DataMember]//非常重要
        public string QxPrjId { get; set; }

        /// <summary>
        /// 条件串
        /// </summary>
        [DataMember]//非常重要
        public List<string> RoleIdLst { get; set; }
        /// <summary>
        /// 排序表达式
        /// </summary>
        [DataMember]//非常重要
        public string MenuSetId { get; set; }
        /// <summary>
        /// 有效日期
        /// </summary>
        [DataMember]//非常重要
        public string IsUpMenuId { get; set; }

    }
}