using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 针对转换类的公共类函数
    /// </summary>
    public class clsPubClass4WS
    {
        /// <summary>
        /// 获取Web服务的地址
        /// (AGC_CSV7.BusinessLogicEx.AutoGC6Cs_WS:Gen_4Ws_GetServiceUrl)
        /// </summary>
        /// <returns>返回当前文件中Web服务的地址</returns>
        public static string GetServiceUrl(string strPageName, ref string strDir)
        {
            String strServiceUrl = String.Empty;
            if (strDir == "0")
            {
                strDir = clsDict_PageName_Dic.GetDir4PageName(strPageName);
            }
            if (clsSysPara4WS.bolIsLocalHost == false)
            {
                if (string.IsNullOrEmpty(strDir) == true)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/{2}",
                        clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx, strPageName);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/{1}/{2}/{3}",
                        clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx, strDir, strPageName);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(strDir) == true)
                {
                    strServiceUrl = String.Format("http://{0}/{1}",
                        clsSysPara4WS.strCurrIPAddressAndPort_Local,
                        strPageName);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/{1}/{2}",
                        clsSysPara4WS.strCurrIPAddressAndPort_Local, strDir, strPageName);
                }
            }
            return strServiceUrl;
        }
    }
}
