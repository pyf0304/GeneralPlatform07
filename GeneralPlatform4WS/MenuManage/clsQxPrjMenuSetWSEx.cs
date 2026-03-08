

/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxPrjMenuSetWS
表名:QxPrjMenuSet
生成代码版本:2018.03.11.1
生成日期:2018/03/15 14:19:16
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:统一平台
工程ID:0014
模块中文名:菜单管理
模块英文名:MenuManage
框架-层名:Web服务转换层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.common;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferenceQxPrjMenuSet;
using System.Collections.Generic;
using GeneralPlatform.Entity;

namespace GeneralPlatform4WS
{

    /// <summary>
    /// 菜单集(QxPrjMenuSet)
    /// (AutoGCLib.AutoGC6Cs_WS:A_GenWebServiceTransCode)
    /// </summary>
    public class clsQxPrjMenuSetWSEx : clsQxPrjMenuSetWS
    {
        private static string mstrPageName = "QxPrjMenuSetService.asmx";
        private static string mstrDir = "0";


        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// (AutoGCLib.AutoGC6Cs_WS:Gen_4Ws_GetFirstID_S)
        /// </summary>
        /// <param name = "strMenuSetName">菜单集名</param>
        /// <param name = "strQxPrjId">工程Id</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public static string GetFirstIDByMenuSetName(string strMenuSetName, string strQxPrjId)
        {
            string strWhereCond = string.Format("{0}='{1}' and {2}='{3}'",
                conQxPrjMenuSet.MenuSetName,
                strMenuSetName, 
                conQxPrjMenuSet.QxPrjId,
                strQxPrjId);
        
            QxPrjMenuSetServiceSoapClient objQxPrjMenuSetService = GetQxPrjMenuSetServiceSoapClient();
            try
            {
                string strMenuSetId = objQxPrjMenuSetService.QxPrjMenuSet_GetFirstID_S(strWhereCond);
                return strMenuSetId;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("执行WebService功能出错。文件地址:{0},函数名:{1}. 调用函数名:{2}.",
                     GetServiceUrl(mstrPageName, ref mstrDir), "QxPrjMenuSet_GetFirstID_S", "clsQxPrjMenuSetWS:GetFirstID_S", objException.Message);
                strMsg += string.Format("出错信息:{0}",
                     objException.Message);
                throw new Exception(strMsg);
            }
        }
        
    }
}