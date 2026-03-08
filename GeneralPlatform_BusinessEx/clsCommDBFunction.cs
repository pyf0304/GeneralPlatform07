using System;
using System.Collections.Generic;
using System.Text;
using com.taishsoft.commdb;
using System.Collections;

namespace GeneralPlatform.BusinessLogic
{
    public class clsCommDBFunction
    {
        public static int funGetRecCountByCond(string strTabName, string strCondtion)
        {
            return clsGeneralTab.funGetRecCountByCond(strTabName, strCondtion);
        }

        public static List<string>  funGetFldValue(string strTableName, string strFieldName, string WhereConditionString)
        {
            return clsGeneralTab.funGetFldValue( strTableName,  strFieldName,  WhereConditionString);
        }

        public static int funSetFldValue(string strTabName, string strFldName, string strValue, string strCondition)
        {
            return clsGeneralTab.funSetFldValue( strTabName, strFldName,  strValue,  strCondition);
        }
        public static  bool IsExistRecord(string strTable, string strCondition)
        {
            return clsGeneralTab.IsExistCondRec(strTable, strCondition);
        }

    }
}
