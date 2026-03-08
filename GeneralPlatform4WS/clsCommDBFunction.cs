using System;
using System.Collections.Generic;
using System.Text;
using GeneralPlatform4WS.ServiceReferenceCommDBFunction;

using System.Collections;
using System.ServiceModel;

namespace GeneralPlatform4WS
{
    public class clsCommDBFunctionWS
    {
        private static CommDBFunctionSoapClient objCommDBFunctionSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static CommDBFunctionSoapClient GetCommDBFunctionSoapClient()
        {
            if (objCommDBFunctionSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "CommDBFunctionSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);
                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/CommDBFunction.asmx", clsSysPara.CurrIPAddressAndPort, clsSysPara.CurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/CommDBFunction.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }
                EndpointAddress address = new EndpointAddress(strServiceUrl);
                return new CommDBFunctionSoapClient(binding, address);
            }
            else
            {
                return objCommDBFunctionSoapClient;
            }
        }

        public clsCommDBFunctionWS()
        {
        }

        /// <summary>
        /// 获取表的记录数
        /// </summary>
        /// <param name="strTabName"></param>
        /// <param name="strCondtion"></param>
        /// <returns></returns>
        //public static int funGetRecCountByCond(string strTabName, string strCondtion)
        //{
        //    CommDBFunctionSoapClient objCommDBFunctionService = GetCommDBFunctionSoapClient();
        //    int intRecNum = 0;
        //    try
        //    {
        //        intRecNum = objCommDBFunctionService.funGetRecCountByCond(strTabName, strCondtion);

        //    }
        //    catch (Exception objException)
        //    {
        //        throw new Exception("获取表记录数出错！\r\n" + objException.Message);
        //    }
        //    return intRecNum;
        //}

        public static List<String> funGetFldValue(string strTableName, string strFieldName, string WhereConditionString)
        {
            CommDBFunctionSoapClient objCommDBFunctionService = GetCommDBFunctionSoapClient();
            List<String> arr = null;
            try
            {
                arr = objCommDBFunctionService.funGetFldValue(strTableName, strFieldName, WhereConditionString);

            }
            catch (Exception objException)
            {
                throw new Exception("获取表记录数出错！\r\n" + objException.Message);
            }
            return arr;
        }


        public static int funSetFldValue(string strTabName, string strFldName, string strValue, string strCondition)
        {
            CommDBFunctionSoapClient objCommDBFunctionService = GetCommDBFunctionSoapClient();
            try
            {

                return objCommDBFunctionService.funSetFldValue(strTabName, strFldName, strValue, strCondition);

            }
            catch (Exception objException)
            {
                throw new Exception("获取表记录数出错！\r\n" + objException.Message);
            }
        
        }

        public static bool IsExistRecord(string strTable, string strCondition)
        {
            CommDBFunctionSoapClient objCommDBFunctionService = GetCommDBFunctionSoapClient();
            bool bolExist = false;
            try
            {
                bolExist = objCommDBFunctionService.IsExistRecord(strTable, strCondition);

            }
            catch (Exception objException)
            {
                throw new Exception("获取表记录数出错！\r\n" + objException.Message);
            }
            return bolExist;
        }

    }
}
