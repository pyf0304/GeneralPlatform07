using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GeneralPlatform.Entity
{
    /// <summary>
    /// 根据记录序号范围获取对象列表的参数对象-Static
    /// </summary>
    public static class stuChangePasswordPara_Static
    {
        /// <summary>
        /// 根据记录范围获取记录的参数对象获取相关的字典参数
        /// </summary>
        /// <param name="objChangePasswordPara">根据范围获取记录的参数对象</param>
        /// <returns>获取的相关字典参数</returns>
        public static Dictionary<string, string> GetDictParam(this stuChangePasswordPara objChangePasswordPara)
        {
            Dictionary<string, string> dictParam = new Dictionary<string, string>()
            {
                ["strNewPassword"] = objChangePasswordPara.NewPassword,
                ["strOldPassword"] = objChangePasswordPara.OldPassword,
                ["strUserId"] = objChangePasswordPara.UserId    
            };
            return dictParam;
        }
    }
    /// <summary>
    /// 根据记录序号范围获取对象列表的参数对象
    /// </summary>
    [Serializable]
    [DataContractAttribute]
    public class stuChangePasswordPara
    {
       
        /// <summary>
        /// 用户Id
        /// </summary>
        [DataMember]//非常重要
        public string UserId { get; set; }

        /// <summary>
        /// 新密码
        /// </summary>
        [DataMember]//非常重要
        public string NewPassword { get; set; }
        /// <summary>
        /// 原密码
        /// </summary>
        [DataMember]//非常重要
        public string OldPassword { get; set; }
     

    }
}