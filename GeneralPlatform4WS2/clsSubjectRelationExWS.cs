using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using GeneralPlatform4WS.ServiceReferenceSubjectRelationEx;

namespace GeneralPlatform4WS
{
    public class clsSubjectRelationExWS
    {
        private static SubjectRelationServiceExSoapClient objSubjectRelationServiceExSoapClient = null;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SubjectRelationServiceExSoapClient GetSubjectRelationServiceExSoapClient()
        {
            if (objSubjectRelationServiceExSoapClient == null)
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "SubjectRelationServiceExSoap";
                binding.CloseTimeout = new System.TimeSpan(6000);

                //EndpointAddress address = new EndpointAddress("http://202.121.63.10/CalcEngineWS/SubjectRelationServiceEx.asmx");

                String strServiceUrl = String.Empty;
                if (clsSysPara.bolIsLocalHost == false)
                {
                    strServiceUrl = String.Format("http://{0}/{1}/SubjectRelationServiceEx.asmx", clsSysPara.strCurrIPAddressAndPort, clsSysPara.strCurrPrx);
                }
                else
                {
                    strServiceUrl = String.Format("http://{0}/SubjectRelationServiceEx.asmx", clsSysPara.strCurrIPAddressAndPort_Local);
                }


                //String strServiceUrl = String.Format("http://{0}/CalcEngineWS/SubjectRelationServiceEx.asmx", clsSysPara.strCurrIPAddress);
                EndpointAddress address = new EndpointAddress(strServiceUrl);

                return new SubjectRelationServiceExSoapClient(binding, address);
            }
            else
            {
                return objSubjectRelationServiceExSoapClient;
            }
        }


        /// <summary>
        /// 获取用户的所有子对象列表
        /// </summary>
        /// <param name="strLeaderId">当前用户</param>
        /// <returns>扩展用户对象，包括子对象列表</returns>
        public static List<string> GetUserIdLstByLeader(string strLeaderId)
        {

            SubjectRelationServiceExSoapClient objSubjectRelationServiceEx = GetSubjectRelationServiceExSoapClient();
            List<string> lstUserIdLst = objSubjectRelationServiceEx.GetUserIdLstByLeader(strLeaderId) as List<string>;
            return lstUserIdLst;
        }
    }
}
