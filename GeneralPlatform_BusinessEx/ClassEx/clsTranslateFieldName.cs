using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC4WApi;


namespace GeneralPlatform.BusinessLogicEx
{
    public interface ITranslate
    {
        string GetFieldCnNameByFieldName(string strPrjId, string strTabName, string strFieldName);
    }
    public class clsTranslateFieldName : ITranslate
    {
        public string GetFieldCnNameByFieldName(string strPrjId, string strTabName, string strFieldName)
        {
            string strFieldCnName = clsTranslateWApi.GetFieldCnNameByFieldName(strPrjId, strTabName, strFieldName);
            return strFieldCnName;
        }

    }
}
