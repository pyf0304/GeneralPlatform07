using System;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// clsSysPara。
    /// </summary>
    public class clsSysPara4WS
    {

        /// <summary>
        /// 当前机器的IPAddress
        /// </summary>
        public static String strCurrIPAddressAndPort
        {
            set
            {
                clsSysPara.strCurrIPAddressAndPort = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public static String strCurrIPAddressAndPort_Local
        {
            set
            {
                clsSysPara.strCurrIPAddressAndPort_Local = value;
            }
        }

        /// <summary>
        /// 当前机器的端口号
        /// </summary>
        public static String strCurrPrx
        {
            set
            {
                clsSysPara.strCurrPrx = value;
            }
        }

        /// <summary>
        /// 是否本机调试状态
        /// </summary>
        public static bool bolIsLocalHost
        {
            set
            {
                clsSysPara.bolIsLocalHost = value;
            }
        }
    }
}
